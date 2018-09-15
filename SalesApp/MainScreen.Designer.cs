namespace SalesApp
{
    partial class MainScreen
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabAddSale = new System.Windows.Forms.TabPage();
            this.tabEditAssets = new System.Windows.Forms.TabPage();
            this.tabMonthlyReport = new System.Windows.Forms.TabPage();
            this.addSaleControl = new SalesApp.AddSale();
            this.monthlyReportControl = new SalesApp.MonthlyReport();
            this.tabControlMain.SuspendLayout();
            this.tabAddSale.SuspendLayout();
            this.tabMonthlyReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabAddSale);
            this.tabControlMain.Controls.Add(this.tabEditAssets);
            this.tabControlMain.Controls.Add(this.tabMonthlyReport);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 561);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabAddSale
            // 
            this.tabAddSale.Controls.Add(this.addSaleControl);
            this.tabAddSale.Location = new System.Drawing.Point(4, 22);
            this.tabAddSale.Name = "tabAddSale";
            this.tabAddSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddSale.Size = new System.Drawing.Size(776, 535);
            this.tabAddSale.TabIndex = 0;
            this.tabAddSale.Text = "Add Sale";
            this.tabAddSale.UseVisualStyleBackColor = true;
            // 
            // tabEditAssets
            // 
            this.tabEditAssets.Location = new System.Drawing.Point(4, 22);
            this.tabEditAssets.Name = "tabEditAssets";
            this.tabEditAssets.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditAssets.Size = new System.Drawing.Size(776, 535);
            this.tabEditAssets.TabIndex = 1;
            this.tabEditAssets.Text = "Edit Assets";
            this.tabEditAssets.UseVisualStyleBackColor = true;
            // 
            // tabMonthlyReport
            // 
            this.tabMonthlyReport.Controls.Add(this.monthlyReportControl);
            this.tabMonthlyReport.Location = new System.Drawing.Point(4, 22);
            this.tabMonthlyReport.Name = "tabMonthlyReport";
            this.tabMonthlyReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthlyReport.Size = new System.Drawing.Size(776, 535);
            this.tabMonthlyReport.TabIndex = 2;
            this.tabMonthlyReport.Text = "Monthly Report";
            this.tabMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // addSaleControl
            // 
            this.addSaleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSaleControl.Location = new System.Drawing.Point(3, 3);
            this.addSaleControl.Name = "addSaleControl";
            this.addSaleControl.Size = new System.Drawing.Size(770, 529);
            this.addSaleControl.TabIndex = 0;
            // 
            // monthlyReportControl
            // 
            this.monthlyReportControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyReportControl.Location = new System.Drawing.Point(3, 3);
            this.monthlyReportControl.Name = "monthlyReportControl";
            this.monthlyReportControl.Size = new System.Drawing.Size(770, 529);
            this.monthlyReportControl.TabIndex = 0;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainScreen";
            this.Text = "Add Sale";
            this.tabControlMain.ResumeLayout(false);
            this.tabAddSale.ResumeLayout(false);
            this.tabMonthlyReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabAddSale;
        private System.Windows.Forms.TabPage tabEditAssets;
        private AddSale addSaleControl;
        private System.Windows.Forms.TabPage tabMonthlyReport;
        private MonthlyReport monthlyReportControl;
    }
}

