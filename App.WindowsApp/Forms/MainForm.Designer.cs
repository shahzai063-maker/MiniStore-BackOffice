namespace App.WindowsApp.Forms
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
            Pnlheader = new Panel();
            flpright = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flpleft = new FlowLayoutPanel();
            Pvlogo = new PictureBox();
            PnlSidebar = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnproduct = new Button();
            btnOrder = new Button();
            btnSync = new Button();
            btnReports = new Button();
            btnLogs = new Button();
            btnSetting = new Button();
            flpNav = new FlowLayoutPanel();
            statusStrip1 = new StatusStrip();
            statusStrip = new ToolStripStatusLabel();
            PnlContent = new FlowLayoutPanel();
            Pnlheader.SuspendLayout();
            flpright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flpleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pvlogo).BeginInit();
            PnlSidebar.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Pnlheader
            // 
            Pnlheader.Controls.Add(flpright);
            Pnlheader.Controls.Add(flpleft);
            Pnlheader.Dock = DockStyle.Top;
            Pnlheader.Location = new Point(0, 0);
            Pnlheader.Margin = new Padding(3, 4, 3, 4);
            Pnlheader.Name = "Pnlheader";
            Pnlheader.Size = new Size(800, 56);
            Pnlheader.TabIndex = 0;
            // 
            // flpright
            // 
            flpright.Controls.Add(pictureBox1);
            flpright.Controls.Add(label1);
            flpright.Dock = DockStyle.Right;
            flpright.Location = new Point(679, 0);
            flpright.Margin = new Padding(3, 4, 3, 4);
            flpright.Name = "flpright";
            flpright.Size = new Size(121, 56);
            flpright.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WindowsApp.Properties.Resources.user_exclamation;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 38);
            label1.TabIndex = 1;
            label1.Text = "Admin";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpleft
            // 
            flpleft.Controls.Add(Pvlogo);
            flpleft.Dock = DockStyle.Left;
            flpleft.Location = new Point(0, 0);
            flpleft.Margin = new Padding(3, 4, 3, 4);
            flpleft.Name = "flpleft";
            flpleft.Size = new Size(134, 56);
            flpleft.TabIndex = 0;
            // 
            // Pvlogo
            // 
            Pvlogo.Image = WindowsApp.Properties.Resources.svgviewer_png_output;
            Pvlogo.Location = new Point(3, 3);
            Pvlogo.Name = "Pvlogo";
            Pvlogo.Size = new Size(32, 32);
            Pvlogo.TabIndex = 0;
            Pvlogo.TabStop = false;
            // 
            // PnlSidebar
            // 
            PnlSidebar.Controls.Add(btnDashboard);
            PnlSidebar.Controls.Add(btnproduct);
            PnlSidebar.Controls.Add(btnOrder);
            PnlSidebar.Controls.Add(btnSync);
            PnlSidebar.Controls.Add(btnReports);
            PnlSidebar.Controls.Add(btnLogs);
            PnlSidebar.Controls.Add(btnSetting);
            PnlSidebar.Controls.Add(flpNav);
            PnlSidebar.Dock = DockStyle.Left;
            PnlSidebar.FlowDirection = FlowDirection.TopDown;
            PnlSidebar.Location = new Point(0, 56);
            PnlSidebar.Margin = new Padding(3, 4, 3, 4);
            PnlSidebar.MinimumSize = new Size(200, 40);
            PnlSidebar.Name = "PnlSidebar";
            PnlSidebar.Size = new Size(200, 480);
            PnlSidebar.TabIndex = 1;
            PnlSidebar.Paint += PnlSidebar_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = WindowsApp.Properties.Resources.dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 4);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.MinimumSize = new Size(200, 40);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(200, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnproduct
            // 
            btnproduct.FlatAppearance.BorderSize = 0;
            btnproduct.FlatStyle = FlatStyle.Flat;
            btnproduct.Image = WindowsApp.Properties.Resources.brand_producthunt;
            btnproduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnproduct.Location = new Point(3, 52);
            btnproduct.Margin = new Padding(3, 4, 3, 4);
            btnproduct.MinimumSize = new Size(200, 40);
            btnproduct.Name = "btnproduct";
            btnproduct.Padding = new Padding(10, 0, 0, 0);
            btnproduct.Size = new Size(200, 40);
            btnproduct.TabIndex = 3;
            btnproduct.Text = "Product";
            btnproduct.TextAlign = ContentAlignment.MiddleLeft;
            btnproduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnproduct.UseVisualStyleBackColor = true;
            btnproduct.Click += btnproduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Image = WindowsApp.Properties.Resources.circle_number_0;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(3, 100);
            btnOrder.Margin = new Padding(3, 4, 3, 4);
            btnOrder.MinimumSize = new Size(200, 40);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(10, 0, 0, 0);
            btnOrder.Size = new Size(200, 40);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Orders";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnSync
            // 
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Image = WindowsApp.Properties.Resources.cloud_down;
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(3, 148);
            btnSync.Margin = new Padding(3, 4, 3, 4);
            btnSync.MinimumSize = new Size(200, 40);
            btnSync.Name = "btnSync";
            btnSync.Padding = new Padding(10, 0, 0, 0);
            btnSync.Size = new Size(200, 40);
            btnSync.TabIndex = 4;
            btnSync.Text = "Sync";
            btnSync.TextAlign = ContentAlignment.MiddleLeft;
            btnSync.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(3, 196);
            btnReports.Margin = new Padding(3, 4, 3, 4);
            btnReports.MinimumSize = new Size(200, 40);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(10, 0, 0, 0);
            btnReports.Size = new Size(200, 40);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogs
            // 
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Image = WindowsApp.Properties.Resources.brand_loom;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(3, 244);
            btnLogs.Margin = new Padding(3, 4, 3, 4);
            btnLogs.MinimumSize = new Size(200, 40);
            btnLogs.Name = "btnLogs";
            btnLogs.Padding = new Padding(10, 0, 0, 0);
            btnLogs.Size = new Size(200, 40);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnSetting
            // 
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Image = WindowsApp.Properties.Resources.settings__1_;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(3, 292);
            btnSetting.Margin = new Padding(3, 4, 3, 4);
            btnSetting.MinimumSize = new Size(200, 40);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(10, 0, 0, 0);
            btnSetting.Size = new Size(200, 40);
            btnSetting.TabIndex = 7;
            btnSetting.Text = "Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // flpNav
            // 
            flpNav.Dock = DockStyle.Fill;
            flpNav.FlowDirection = FlowDirection.TopDown;
            flpNav.Location = new Point(3, 340);
            flpNav.Margin = new Padding(3, 4, 3, 4);
            flpNav.Name = "flpNav";
            flpNav.Size = new Size(200, 0);
            flpNav.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusStrip });
            statusStrip1.Location = new Point(0, 536);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(50, 20);
            statusStrip.Text = "Ready";
            // 
            // PnlContent
            // 
            PnlContent.Dock = DockStyle.Fill;
            PnlContent.Location = new Point(200, 56);
            PnlContent.Margin = new Padding(3, 4, 3, 4);
            PnlContent.Name = "PnlContent";
            PnlContent.Size = new Size(600, 480);
            PnlContent.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(PnlContent);
            Controls.Add(PnlSidebar);
            Controls.Add(statusStrip1);
            Controls.Add(Pnlheader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Pnlheader.ResumeLayout(false);
            flpright.ResumeLayout(false);
            flpright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flpleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pvlogo).EndInit();
            PnlSidebar.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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