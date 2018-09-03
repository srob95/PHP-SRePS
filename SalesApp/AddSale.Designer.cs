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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesData)).BeginInit();
            this.TotalsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.Controls.Add(this.SalesData, 1, 1);
            this.MainLayout.Controls.Add(this.FinaliseButton, 1, 3);
            this.MainLayout.Controls.Add(this.TotalsTable, 1, 2);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.Size = new System.Drawing.Size(784, 561);
            this.MainLayout.TabIndex = 0;
            // 
            // SalesData
            // 
            this.SalesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesData.Location = new System.Drawing.Point(81, 59);
            this.SalesData.Name = "SalesData";
            this.SalesData.Size = new System.Drawing.Size(542, 358);
            this.SalesData.TabIndex = 0;
            this.SalesData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_changed);
            this.SalesData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.data_row_added);
            // 
            // FinaliseButton
            // 
            this.FinaliseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinaliseButton.Location = new System.Drawing.Point(81, 507);
            this.FinaliseButton.Name = "FinaliseButton";
            this.FinaliseButton.Size = new System.Drawing.Size(542, 42);
            this.FinaliseButton.TabIndex = 1;
            this.FinaliseButton.Text = "Finalise Sale";
            this.FinaliseButton.UseVisualStyleBackColor = true;
            this.FinaliseButton.Click += new System.EventHandler(this.finalise_sale);
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
            this.TotalsTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalsTable.Location = new System.Drawing.Point(423, 423);
            this.TotalsTable.Name = "TotalsTable";
            this.TotalsTable.RowCount = 3;
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TotalsTable.Size = new System.Drawing.Size(200, 78);
            this.TotalsTable.TabIndex = 2;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubTotalLabel.Location = new System.Drawing.Point(4, 1);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(92, 24);
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
            this.SubTotalValue.Size = new System.Drawing.Size(93, 24);
            this.SubTotalValue.TabIndex = 1;
            this.SubTotalValue.Text = "0.0";
            this.SubTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaxLabel.Location = new System.Drawing.Point(4, 26);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(92, 24);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "Tax";
            this.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxValue
            // 
            this.TaxValue.AutoSize = true;
            this.TaxValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaxValue.Location = new System.Drawing.Point(103, 26);
            this.TaxValue.Name = "TaxValue";
            this.TaxValue.Size = new System.Drawing.Size(93, 24);
            this.TaxValue.TabIndex = 3;
            this.TaxValue.Text = "0.0";
            this.TaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalLabel.Location = new System.Drawing.Point(4, 51);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(92, 26);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalValue
            // 
            this.TotalValue.AutoSize = true;
            this.TotalValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalValue.Location = new System.Drawing.Point(103, 51);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(93, 26);
            this.TotalValue.TabIndex = 5;
            this.TotalValue.Text = "0.0";
            this.TotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(SalesApp.Program);
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataSource = typeof(SalesApp.Program);
            // 
            // programBindingSource2
            // 
            this.programBindingSource2.DataSource = typeof(SalesApp.Program);
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainLayout);
            this.Name = "AddSale";
            this.Text = "Add Sale";
            this.MainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesData)).EndInit();
            this.TotalsTable.ResumeLayout(false);
            this.TotalsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.DataGridView SalesData;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Windows.Forms.BindingSource programBindingSource2;
        private System.Windows.Forms.Button FinaliseButton;
        private System.Windows.Forms.TableLayoutPanel TotalsTable;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SubTotalValue;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TaxValue;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalValue;
    }
}

