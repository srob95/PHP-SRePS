namespace SalesApp
{
    partial class AddSale
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SalesData = new System.Windows.Forms.DataGridView();
            this.FinaliseButton = new System.Windows.Forms.Button();
            this.TotalsTable = new System.Windows.Forms.TableLayoutPanel();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalValue = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxValue = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalValue = new System.Windows.Forms.Label();
            this.CashLabel = new System.Windows.Forms.Label();
            this.EftposLabel = new System.Windows.Forms.Label();
            this.CashValue = new System.Windows.Forms.NumericUpDown();
            this.EftposValue = new System.Windows.Forms.NumericUpDown();
            this.PaymentMethod = new System.Windows.Forms.Label();
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesData)).BeginInit();
            this.TotalsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EftposValue)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.SalesData, 0, 0);
            this.MainLayout.Controls.Add(this.FinaliseButton, 0, 2);
            this.MainLayout.Controls.Add(this.TotalsTable, 0, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.Size = new System.Drawing.Size(658, 519);
            this.MainLayout.TabIndex = 1;
            // 
            // SalesData
            // 
            this.SalesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesData.Location = new System.Drawing.Point(3, 3);
            this.SalesData.Name = "SalesData";
            this.SalesData.Size = new System.Drawing.Size(652, 305);
            this.SalesData.TabIndex = 0;
            this.SalesData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_changed);
            this.SalesData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.data_row_added);
            // 
            // FinaliseButton
            // 
            this.FinaliseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinaliseButton.Location = new System.Drawing.Point(3, 469);
            this.FinaliseButton.Name = "FinaliseButton";
            this.FinaliseButton.Size = new System.Drawing.Size(652, 47);
            this.FinaliseButton.TabIndex = 1;
            this.FinaliseButton.Text = "Finalise Sale";
            this.FinaliseButton.UseVisualStyleBackColor = true;
            this.FinaliseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.finalise_sale);
            // 
            // TotalsTable
            // 
            this.TotalsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TotalsTable.ColumnCount = 2;
            this.TotalsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TotalsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TotalsTable.Controls.Add(this.SubTotalLabel, 0, 0);
            this.TotalsTable.Controls.Add(this.SubTotalValue, 1, 0);
            this.TotalsTable.Controls.Add(this.TaxLabel, 0, 1);
            this.TotalsTable.Controls.Add(this.TaxValue, 1, 1);
            this.TotalsTable.Controls.Add(this.TotalLabel, 0, 2);
            this.TotalsTable.Controls.Add(this.TotalValue, 1, 2);
            this.TotalsTable.Controls.Add(this.CashLabel, 0, 4);
            this.TotalsTable.Controls.Add(this.EftposLabel, 0, 5);
            this.TotalsTable.Controls.Add(this.CashValue, 1, 4);
            this.TotalsTable.Controls.Add(this.EftposValue, 1, 5);
            this.TotalsTable.Controls.Add(this.PaymentMethod, 0, 3);
            this.TotalsTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalsTable.Location = new System.Drawing.Point(455, 314);
            this.TotalsTable.Name = "TotalsTable";
            this.TotalsTable.RowCount = 6;
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TotalsTable.Size = new System.Drawing.Size(200, 149);
            this.TotalsTable.TabIndex = 2;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubTotalLabel.Location = new System.Drawing.Point(4, 1);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(92, 27);
            this.SubTotalLabel.TabIndex = 0;
            this.SubTotalLabel.Text = "Sub Total";
            this.SubTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubTotalValue
            // 
            this.SubTotalValue.AutoSize = true;
            this.SubTotalValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubTotalValue.Location = new System.Drawing.Point(103, 1);
            this.SubTotalValue.Name = "SubTotalValue";
            this.SubTotalValue.Size = new System.Drawing.Size(93, 27);
            this.SubTotalValue.TabIndex = 1;
            this.SubTotalValue.Text = "0.0";
            this.SubTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaxLabel.Location = new System.Drawing.Point(4, 29);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(92, 27);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "Tax";
            this.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxValue
            // 
            this.TaxValue.AutoSize = true;
            this.TaxValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaxValue.Location = new System.Drawing.Point(103, 29);
            this.TaxValue.Name = "TaxValue";
            this.TaxValue.Size = new System.Drawing.Size(93, 27);
            this.TaxValue.TabIndex = 3;
            this.TaxValue.Text = "0.0";
            this.TaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalLabel.Location = new System.Drawing.Point(4, 57);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(92, 27);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalValue
            // 
            this.TotalValue.AutoSize = true;
            this.TotalValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalValue.Location = new System.Drawing.Point(103, 57);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(93, 27);
            this.TotalValue.TabIndex = 5;
            this.TotalValue.Text = "0.0";
            this.TotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CashLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashLabel.Location = new System.Drawing.Point(4, 106);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(92, 20);
            this.CashLabel.TabIndex = 6;
            this.CashLabel.Text = "Cash";
            this.CashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EftposLabel
            // 
            this.EftposLabel.AutoSize = true;
            this.EftposLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EftposLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EftposLabel.Location = new System.Drawing.Point(4, 127);
            this.EftposLabel.Name = "EftposLabel";
            this.EftposLabel.Size = new System.Drawing.Size(92, 21);
            this.EftposLabel.TabIndex = 8;
            this.EftposLabel.Text = "Eftpos";
            this.EftposLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashValue
            // 
            this.CashValue.DecimalPlaces = 2;
            this.CashValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashValue.Location = new System.Drawing.Point(103, 109);
            this.CashValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CashValue.Name = "CashValue";
            this.CashValue.Size = new System.Drawing.Size(93, 20);
            this.CashValue.TabIndex = 10;
            this.CashValue.ValueChanged += new System.EventHandler(this.CashChanged);
            // 
            // EftposValue
            // 
            this.EftposValue.DecimalPlaces = 2;
            this.EftposValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EftposValue.Location = new System.Drawing.Point(103, 130);
            this.EftposValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.EftposValue.Name = "EftposValue";
            this.EftposValue.Size = new System.Drawing.Size(93, 20);
            this.EftposValue.TabIndex = 11;
            this.EftposValue.ValueChanged += new System.EventHandler(this.EftposChanged);
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSize = true;
            this.PaymentMethod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalsTable.SetColumnSpan(this.PaymentMethod, 2);
            this.PaymentMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(4, 85);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(192, 20);
            this.PaymentMethod.TabIndex = 12;
            this.PaymentMethod.Text = "Payment Method";
            this.PaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayout);
            this.Name = "AddSale";
            this.Size = new System.Drawing.Size(658, 519);
            this.MainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesData)).EndInit();
            this.TotalsTable.ResumeLayout(false);
            this.TotalsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EftposValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.DataGridView SalesData;
        private System.Windows.Forms.Button FinaliseButton;
        private System.Windows.Forms.TableLayoutPanel TotalsTable;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SubTotalValue;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TaxValue;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalValue;
        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.Label EftposLabel;
        private System.Windows.Forms.NumericUpDown CashValue;
        private System.Windows.Forms.NumericUpDown EftposValue;
        private System.Windows.Forms.Label PaymentMethod;
    }
}
