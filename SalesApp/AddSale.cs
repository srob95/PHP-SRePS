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
            sales_data.DataSource = dt;

            dt.Columns.Add("ItemNo");
            dt.Columns.Add("Description");
            dt.Columns.Add("Item Price");
            dt.Columns.Add("Qty");
            dt.Columns.Add("SubPrice");

            sales_data.Columns["Description"].ReadOnly = true;
            sales_data.Columns["Item Price"].ReadOnly = true;
            sales_data.Columns["SubPrice"].ReadOnly = true;

            sales_data.Columns["ItemNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sales_data.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sales_data.Columns["Item Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sales_data.Columns["Qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sales_data.Columns["SubPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void data_changed(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = sales_data.DataSource as DataTable;
            update_row_info(sales_data.DataSource as DataTable, e.RowIndex);
        }

        private void data_row_added(object sender, DataGridViewRowsAddedEventArgs e)
        {
            update_row_info(sales_data.DataSource as DataTable, e.RowIndex);
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
                } catch (FormatException e)
                {
                    qty = 1;
                    dt.Rows[row]["Qty"] = qty;
                }
                float subPrice = price * qty;
                dt.Rows[row]["SubPrice"] = subPrice;
            }
        }

        private void finalise_sale(object sender, EventArgs e)
        {
            DataTable dt = sales_data.DataSource as DataTable;
            // TODO save the data to a database
        }
    }
}
