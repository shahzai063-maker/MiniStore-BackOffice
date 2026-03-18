namespace App.WinForms.Views
{
    partial class DashboardView
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
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.tblKpi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKpiSales = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.pnlKpiOrders = new System.Windows.Forms.Panel();
            this.lblOrderV = new System.Windows.Forms.Label();
            this.lblOrderT = new System.Windows.Forms.Label();
            this.pnlKpiRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnllowStock = new System.Windows.Forms.Panel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.clmProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbllowStock = new System.Windows.Forms.Label();
            this.pnlRecentOrder = new System.Windows.Forms.Panel();
            this.lvRecentOrder = new System.Windows.Forms.ListView();
            this.clmOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCostumerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrder = new System.Windows.Forms.Label();
            this.tblDashboard.SuspendLayout();
            this.tblKpi.SuspendLayout();
            this.pnlKpiSales.SuspendLayout();
            this.pnlKpiOrders.SuspendLayout();
            this.pnlKpiRevenue.SuspendLayout();
            this.pnllowStock.SuspendLayout();
            this.pnlRecentOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.BackColor = System.Drawing.Color.White;
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.tblKpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnllowStock, 2, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrder, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(783, 448);
            this.tblDashboard.TabIndex = 0;
            // 
            // tblKpi
            // 
            this.tblKpi.ColumnCount = 3;
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.11258F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.11259F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77484F));
            this.tblKpi.Controls.Add(this.pnlKpiSales, 0, 0);
            this.tblKpi.Controls.Add(this.pnlKpiOrders, 1, 0);
            this.tblKpi.Controls.Add(this.pnlKpiRevenue, 2, 0);
            this.tblKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKpi.Location = new System.Drawing.Point(17, 15);
            this.tblKpi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblKpi.Name = "tblKpi";
            this.tblKpi.RowCount = 1;
            this.tblKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tblKpi.Size = new System.Drawing.Size(749, 92);
            this.tblKpi.TabIndex = 0;
            // 
            // pnlKpiSales
            // 
            this.pnlKpiSales.BackColor = System.Drawing.Color.White;
            this.pnlKpiSales.Controls.Add(this.lblSalesT);
            this.pnlKpiSales.Controls.Add(this.lblSalesV);
            this.pnlKpiSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiSales.Location = new System.Drawing.Point(3, 2);
            this.pnlKpiSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlKpiSales.Name = "pnlKpiSales";
            this.pnlKpiSales.Size = new System.Drawing.Size(242, 88);
            this.pnlKpiSales.TabIndex = 0;
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesT.Location = new System.Drawing.Point(36, 28);
            this.lblSalesT.Margin = new System.Windows.Forms.Padding(36, 28, 33, 0);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(48, 23);
            this.lblSalesT.TabIndex = 1;
            this.lblSalesT.Text = "Sales";
            // 
            // lblSalesV
            // 
            this.lblSalesV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesV.Location = new System.Drawing.Point(128, 31);
            this.lblSalesV.Margin = new System.Windows.Forms.Padding(11, 28, 33, 0);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(36, 20);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "234";
            // 
            // pnlKpiOrders
            // 
            this.pnlKpiOrders.BackColor = System.Drawing.Color.White;
            this.pnlKpiOrders.Controls.Add(this.lblOrderV);
            this.pnlKpiOrders.Controls.Add(this.lblOrderT);
            this.pnlKpiOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiOrders.Location = new System.Drawing.Point(251, 2);
            this.pnlKpiOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlKpiOrders.Name = "pnlKpiOrders";
            this.pnlKpiOrders.Size = new System.Drawing.Size(242, 88);
            this.pnlKpiOrders.TabIndex = 1;
            // 
            // lblOrderV
            // 
            this.lblOrderV.AutoSize = true;
            this.lblOrderV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderV.Location = new System.Drawing.Point(126, 28);
            this.lblOrderV.Margin = new System.Windows.Forms.Padding(27, 28, 33, 0);
            this.lblOrderV.Name = "lblOrderV";
            this.lblOrderV.Size = new System.Drawing.Size(27, 20);
            this.lblOrderV.TabIndex = 1;
            this.lblOrderV.Text = "54";
            // 
            // lblOrderT
            // 
            this.lblOrderT.AutoSize = true;
            this.lblOrderT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderT.Location = new System.Drawing.Point(36, 30);
            this.lblOrderT.Margin = new System.Windows.Forms.Padding(27, 28, 33, 0);
            this.lblOrderT.Name = "lblOrderT";
            this.lblOrderT.Size = new System.Drawing.Size(55, 20);
            this.lblOrderT.TabIndex = 1;
            this.lblOrderT.Text = "Orders";
            // 
            // pnlKpiRevenue
            // 
            this.pnlKpiRevenue.BackColor = System.Drawing.Color.White;
            this.pnlKpiRevenue.Controls.Add(this.lblRevenueV);
            this.pnlKpiRevenue.Controls.Add(this.lblRevenueT);
            this.pnlKpiRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiRevenue.Location = new System.Drawing.Point(499, 2);
            this.pnlKpiRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlKpiRevenue.Name = "pnlKpiRevenue";
            this.pnlKpiRevenue.Size = new System.Drawing.Size(247, 88);
            this.pnlKpiRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueV.Location = new System.Drawing.Point(140, 28);
            this.lblRevenueV.Margin = new System.Windows.Forms.Padding(27, 28, 33, 0);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(91, 20);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "32,765 PKR";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueT.Location = new System.Drawing.Point(27, 28);
            this.lblRevenueT.Margin = new System.Windows.Forms.Padding(27, 28, 33, 0);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(68, 20);
            this.lblRevenueT.TabIndex = 1;
            this.lblRevenueT.Text = "Revenue";
            this.lblRevenueT.Click += new System.EventHandler(this.lblRevenueT_Click);
            // 
            // pnllowStock
            // 
            this.pnllowStock.Controls.Add(this.lvLowStock);
            this.pnllowStock.Controls.Add(this.lbllowStock);
            this.pnllowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnllowStock.Location = new System.Drawing.Point(17, 111);
            this.pnllowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnllowStock.Name = "pnllowStock";
            this.pnllowStock.Size = new System.Drawing.Size(749, 159);
            this.pnllowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmProduct,
            this.clmStock});
            this.lvLowStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLowStock.FullRowSelect = true;
            this.lvLowStock.GridLines = true;
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(0, 21);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(749, 138);
            this.lvLowStock.TabIndex = 1;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            this.lvLowStock.SelectedIndexChanged += new System.EventHandler(this.lvLowStock_SelectedIndexChanged);
            // 
            // clmProduct
            // 
            this.clmProduct.Text = "Product Name";
            // 
            // clmStock
            // 
            this.clmStock.Text = "Stock";
            // 
            // lbllowStock
            // 
            this.lbllowStock.AutoSize = true;
            this.lbllowStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbllowStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllowStock.Location = new System.Drawing.Point(0, 0);
            this.lbllowStock.Name = "lbllowStock";
            this.lbllowStock.Size = new System.Drawing.Size(80, 20);
            this.lbllowStock.TabIndex = 0;
            this.lbllowStock.Text = "Low Stock";
            // 
            // pnlRecentOrder
            // 
            this.pnlRecentOrder.Controls.Add(this.lvRecentOrder);
            this.pnlRecentOrder.Controls.Add(this.lblOrder);
            this.pnlRecentOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrder.Location = new System.Drawing.Point(17, 275);
            this.pnlRecentOrder.Name = "pnlRecentOrder";
            this.pnlRecentOrder.Size = new System.Drawing.Size(749, 157);
            this.pnlRecentOrder.TabIndex = 2;
            // 
            // lvRecentOrder
            // 
            this.lvRecentOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmOrder,
            this.clmCostumerId,
            this.clmTotal,
            this.clmStatus});
            this.lvRecentOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvRecentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRecentOrder.FullRowSelect = true;
            this.lvRecentOrder.GridLines = true;
            this.lvRecentOrder.HideSelection = false;
            this.lvRecentOrder.Location = new System.Drawing.Point(0, 25);
            this.lvRecentOrder.Name = "lvRecentOrder";
            this.lvRecentOrder.Size = new System.Drawing.Size(749, 132);
            this.lvRecentOrder.TabIndex = 1;
            this.lvRecentOrder.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrder.View = System.Windows.Forms.View.Details;
            // 
            // clmOrder
            // 
            this.clmOrder.Text = "Order Id";
            // 
            // clmCostumerId
            // 
            this.clmCostumerId.Text = "Costumer Name";
            // 
            // clmTotal
            // 
            this.clmTotal.Text = "Total";
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(0, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(108, 20);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(783, 448);
            this.tblDashboard.ResumeLayout(false);
            this.tblKpi.ResumeLayout(false);
            this.pnlKpiSales.ResumeLayout(false);
            this.pnlKpiSales.PerformLayout();
            this.pnlKpiOrders.ResumeLayout(false);
            this.pnlKpiOrders.PerformLayout();
            this.pnlKpiRevenue.ResumeLayout(false);
            this.pnlKpiRevenue.PerformLayout();
            this.pnllowStock.ResumeLayout(false);
            this.pnllowStock.PerformLayout();
            this.pnlRecentOrder.ResumeLayout(false);
            this.pnlRecentOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblKpi;
        private System.Windows.Forms.FlowLayoutPanel pnlKpiSales;
        private System.Windows.Forms.Panel pnlKpiOrders;
        private System.Windows.Forms.Panel pnlKpiRevenue;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnllowStock;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.Label lbllowStock;
        private System.Windows.Forms.ColumnHeader clmProduct;
        private System.Windows.Forms.ColumnHeader clmStock;
        private System.Windows.Forms.Panel pnlRecentOrder;
        private System.Windows.Forms.ListView lvRecentOrder;
        private System.Windows.Forms.ColumnHeader clmOrder;
        private System.Windows.Forms.ColumnHeader clmCostumerId;
        private System.Windows.Forms.ColumnHeader clmTotal;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.Label lblOrder;
    }
}
