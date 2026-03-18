namespace App.WinForms.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Pnlheader = new System.Windows.Forms.Panel();
            this.flpright = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpleft = new System.Windows.Forms.FlowLayoutPanel();
            this.Pvlogo = new System.Windows.Forms.PictureBox();
            this.PnlSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.PnlContent = new System.Windows.Forms.FlowLayoutPanel();
            this.Pnlheader.SuspendLayout();
            this.flpright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flpleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pvlogo)).BeginInit();
            this.PnlSidebar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnlheader
            // 
            this.Pnlheader.Controls.Add(this.flpright);
            this.Pnlheader.Controls.Add(this.flpleft);
            this.Pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlheader.Location = new System.Drawing.Point(0, 0);
            this.Pnlheader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnlheader.Name = "Pnlheader";
            this.Pnlheader.Size = new System.Drawing.Size(800, 125);
            this.Pnlheader.TabIndex = 0;
            // 
            // flpright
            // 
            this.flpright.Controls.Add(this.pictureBox1);
            this.flpright.Controls.Add(this.label1);
            this.flpright.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpright.Location = new System.Drawing.Point(679, 0);
            this.flpright.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpright.Name = "flpright";
            this.flpright.Size = new System.Drawing.Size(121, 125);
            this.flpright.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App.WinForms.Properties.Resources.user_exclamation;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpleft
            // 
            this.flpleft.Controls.Add(this.Pvlogo);
            this.flpleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpleft.Location = new System.Drawing.Point(0, 0);
            this.flpleft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpleft.Name = "flpleft";
            this.flpleft.Size = new System.Drawing.Size(134, 125);
            this.flpleft.TabIndex = 0;
            // 
            // Pvlogo
            // 
            this.Pvlogo.Image = global::App.WinForms.Properties.Resources.svgviewer_png_output;
            this.Pvlogo.Location = new System.Drawing.Point(3, 3);
            this.Pvlogo.Name = "Pvlogo";
            this.Pvlogo.Size = new System.Drawing.Size(32, 32);
            this.Pvlogo.TabIndex = 0;
            this.Pvlogo.TabStop = false;
            // 
            // PnlSidebar
            // 
            this.PnlSidebar.Controls.Add(this.btnDashboard);
            this.PnlSidebar.Controls.Add(this.btnproduct);
            this.PnlSidebar.Controls.Add(this.btnOrder);
            this.PnlSidebar.Controls.Add(this.btnSync);
            this.PnlSidebar.Controls.Add(this.btnReports);
            this.PnlSidebar.Controls.Add(this.btnLogs);
            this.PnlSidebar.Controls.Add(this.btnSetting);
            this.PnlSidebar.Controls.Add(this.flpNav);
            this.PnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PnlSidebar.Location = new System.Drawing.Point(0, 125);
            this.PnlSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlSidebar.MinimumSize = new System.Drawing.Size(200, 40);
            this.PnlSidebar.Name = "PnlSidebar";
            this.PnlSidebar.Size = new System.Drawing.Size(200, 411);
            this.PnlSidebar.TabIndex = 1;
            this.PnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSidebar_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 4);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 40);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.FlatAppearance.BorderSize = 0;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduct.Image = ((System.Drawing.Image)(resources.GetObject("btnproduct.Image")));
            this.btnproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.Location = new System.Drawing.Point(3, 52);
            this.btnproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnproduct.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnproduct.Size = new System.Drawing.Size(200, 40);
            this.btnproduct.TabIndex = 3;
            this.btnproduct.Text = "Product";
            this.btnproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(3, 100);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrder.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(200, 40);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Orders";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSync
            // 
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(3, 148);
            this.btnSync.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSync.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnSync.Name = "btnSync";
            this.btnSync.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSync.Size = new System.Drawing.Size(200, 40);
            this.btnSync.TabIndex = 4;
            this.btnSync.Text = "Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 196);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReports.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(200, 40);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnLogs.Image")));
            this.btnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Location = new System.Drawing.Point(3, 244);
            this.btnLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogs.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogs.Size = new System.Drawing.Size(200, 40);
            this.btnLogs.TabIndex = 5;
            this.btnLogs.Text = "Logs";
            this.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(3, 292);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetting.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(200, 40);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // flpNav
            // 
            this.flpNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNav.Location = new System.Drawing.Point(3, 340);
            this.flpNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpNav.Name = "flpNav";
            this.flpNav.Size = new System.Drawing.Size(200, 0);
            this.flpNav.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(50, 20);
            this.statusStrip.Text = "Ready";
            // 
            // PnlContent
            // 
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(200, 125);
            this.PnlContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(600, 411);
            this.PnlContent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlSidebar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Pnlheader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Pnlheader.ResumeLayout(false);
            this.flpright.ResumeLayout(false);
            this.flpright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flpleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pvlogo)).EndInit();
            this.PnlSidebar.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnlheader;
        private System.Windows.Forms.FlowLayoutPanel PnlSidebar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpright;
        private System.Windows.Forms.FlowLayoutPanel flpleft;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.FlowLayoutPanel PnlContent;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.PictureBox Pvlogo;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}