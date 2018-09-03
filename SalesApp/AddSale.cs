using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class AddSale : Form
    {

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
                string itemno = dt.Rows[row]["ItemNo"].ToString();
                string name = ItemManager.GetItemName(itemno);
                float price = ItemManager.GetItemPrice(itemno);
                dt.Rows[row]["Description"] = name;
                dt.Rows[row]["Item Price"] = price;

                int qty;
                try {
                    qty = Int32.Parse(dt.Rows[row]["Qty"].ToString());
                } catch (FormatException)
                {
                    qty = 1;
                    dt.Rows[row]["Qty"] = qty;
                }
                float subPrice = price * qty;
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
                double value = Double.Parse(s_value); // since we set s_value, this should never crash...
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
        }

        private void finalise_sale(object sender, EventArgs e)
        {
            DataTable dt = SalesData.DataSource as DataTable;
            // TODO save the data to a database
        }
    }
}
