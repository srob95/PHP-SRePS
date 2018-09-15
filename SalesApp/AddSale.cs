﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class AddSale : UserControl
    {
        private Database db;

        public AddSale()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            SalesData.DataSource = dt;

            dt.Columns.Add("ItemNo");
            dt.Columns.Add("Description");
            dt.Columns.Add("Item Price");
            dt.Columns.Add("Qty");
            dt.Columns.Add("SubPrice");

            SalesData.Columns["Description"].ReadOnly = true;
            SalesData.Columns["Item Price"].ReadOnly = true;
            SalesData.Columns["SubPrice"].ReadOnly = true;

            SalesData.Columns["ItemNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SalesData.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SalesData.Columns["Item Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SalesData.Columns["Qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SalesData.Columns["SubPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void setDatabase(Database db)
        {
            this.db = db;
        }

        private void data_changed(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = SalesData.DataSource as DataTable;
            update_row_info(SalesData.DataSource as DataTable, e.RowIndex);
        }

        private void data_row_added(object sender, DataGridViewRowsAddedEventArgs e)
        {
            update_row_info(SalesData.DataSource as DataTable, e.RowIndex);
        }

        private void update_row_info(DataTable dt, int row)
        {
            // TODO: This doesn't update properly when a row is added because the DataTable doesn't get the row added until after the event
            if (row < dt.Rows.Count)
            {
                int itemno = Int32.TryParse(dt.Rows[row]["ItemNo"].ToString(), out itemno) ? itemno : 0;
                string name = db.GetAssetName(itemno);
                double price = db.GetAssetPrice(itemno);
                dt.Rows[row]["Description"] = name;
                dt.Rows[row]["Item Price"] = price;

                int qty = Int32.TryParse(dt.Rows[row]["Qty"].ToString(), out qty) ? qty : 0;
                double subPrice = price * qty;
                dt.Rows[row]["SubPrice"] = subPrice;
            }

            update_totals_info(dt);
        }

        private void update_totals_info(DataTable dt)
        {
            double sum = 0.0;
            foreach (DataRow row in dt.Rows)
            {
                String s_value = row["SubPrice"].ToString();
                double value = Double.TryParse(s_value, out value) ? value : 0;
                sum += value;
            }

            // TODO refractor these calcs into a new function and unit test it.
            // Make sure that it's not possible to be sub-cents in the calcs
            // Also, unit test that the sum is calculated right
            double tax = Math.Floor(sum * 100 * 0.1) / 100; // assume tax is 10%
            double total = tax + sum;

            SubTotalValue.Text = sum.ToString();
            TaxValue.Text = tax.ToString();
            TotalValue.Text = total.ToString();

            UpdateFinaliseStatus();
        }

        private void finalise_sale(object sender, MouseEventArgs e)
        {
            DataTable dt = SalesData.DataSource as DataTable;

            List<SaleItem> items = new List<SaleItem>();
            foreach (DataRow row in dt.Rows)
            {
                string s_item = row["ItemNo"].ToString();
                string s_qty = row["Qty"].ToString();

                int item = -1, qty = 1;
                try
                {
                    // if either the item or qty are improperlly formatted, ignore the row
                    item = int.Parse(s_item);
                    qty = int.Parse(s_qty);

                    items.Add(new SaleItem(item, qty));
                }
                catch (FormatException) { };
            }

            double amountPaid = (double)(CashValue.Value + EftposValue.Value);
            db.AddSale(items, amountPaid);

            dt.Clear();
        }

        private void EftposChanged(object sender, EventArgs e)
        {
            CashValue.Value = 0;
            UpdateFinaliseStatus();
        }

        private void CashChanged(object sender, EventArgs e)
        {
            EftposValue.Value = 0;
            UpdateFinaliseStatus();
        }

        private void UpdateFinaliseStatus()
        {
            decimal total = Decimal.TryParse(TotalValue.Text, out total) ? total : 0;
            FinaliseButton.Enabled = CashValue.Value + EftposValue.Value >= total;
        }
    }
}
