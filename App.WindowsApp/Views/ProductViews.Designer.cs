namespace App.WindowsApp.Views
{
    partial class ProductViews
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductViews));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            toolStrip2 = new ToolStrip();
            Add = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            label = new Label();
            pnlgrid = new FlowLayoutPanel();
            DGVproducts = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            Colname = new DataGridViewTextBoxColumn();
            Colcategory = new DataGridViewTextBoxColumn();
            Colprice = new DataGridViewTextBoxColumn();
            Colstock = new DataGridViewTextBoxColumn();
            Colstatus = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVproducts).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlgrid, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(918, 701);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip2);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 62);
            panel1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Fill;
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { Add, toolStripButton2, toolStripButton3, toolStripButton4, toolStripSeparator1, toolStripButton5 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(912, 62);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "Add";
            // 
            // Add
            // 
            Add.Image = (Image)resources.GetObject("Add.Image");
            Add.ImageTransparentColor = Color.Magenta;
            Add.Name = "Add";
            Add.Size = new Size(61, 59);
            Add.Text = "Add";
            Add.Click += tsbAdd_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(59, 59);
            toolStripButton2.Text = "Edit";
            toolStripButton2.Click += tsbedit_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(65, 59);
            toolStripButton3.Text = "View";
            toolStripButton3.Click += tsbview_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(77, 59);
            toolStripButton4.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(82, 59);
            toolStripButton5.Text = "Refresh";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 74);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(12);
            flowLayoutPanel1.Size = new Size(912, 97);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(cmbCategory, 1, 1);
            tableLayoutPanel2.Controls.Add(cmbStockStatus, 2, 1);
            tableLayoutPanel2.Controls.Add(label, 1, 0);
            tableLayoutPanel2.Location = new Point(15, 16);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(888, 80);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(624, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "StockStatus";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 44);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(358, 44);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 28);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(624, 44);
            cmbStockStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(121, 28);
            cmbStockStatus.TabIndex = 5;
            cmbStockStatus.SelectedIndexChanged += cmbStockStatus_SelectedIndexChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(358, 0);
            label.Name = "label";
            label.Size = new Size(69, 20);
            label.TabIndex = 1;
            label.Text = "Category";
            // 
            // pnlgrid
            // 
            pnlgrid.BackColor = SystemColors.ButtonHighlight;
            pnlgrid.Controls.Add(DGVproducts);
            pnlgrid.Dock = DockStyle.Fill;
            pnlgrid.Location = new Point(3, 179);
            pnlgrid.Margin = new Padding(3, 4, 3, 4);
            pnlgrid.Name = "pnlgrid";
            pnlgrid.Padding = new Padding(12, 15, 12, 15);
            pnlgrid.Size = new Size(912, 518);
            pnlgrid.TabIndex = 2;
            // 
            // DGVproducts
            // 
            DGVproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVproducts.Columns.AddRange(new DataGridViewColumn[] { ColId, Colname, Colcategory, Colprice, Colstock, Colstatus });
            DGVproducts.Location = new Point(15, 19);
            DGVproducts.Margin = new Padding(3, 4, 3, 4);
            DGVproducts.MultiSelect = false;
            DGVproducts.Name = "DGVproducts";
            DGVproducts.ReadOnly = true;
            DGVproducts.RowHeadersVisible = false;
            DGVproducts.RowHeadersWidth = 51;
            DGVproducts.RowTemplate.Height = 24;
            DGVproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVproducts.Size = new Size(826, 364);
            DGVproducts.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "id";
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // Colname
            // 
            Colname.DataPropertyName = "Name";
            Colname.HeaderText = "Name";
            Colname.MinimumWidth = 6;
            Colname.Name = "Colname";
            Colname.ReadOnly = true;
            // 
            // Colcategory
            // 
            Colcategory.DataPropertyName = "Category";
            Colcategory.HeaderText = "Category";
            Colcategory.MinimumWidth = 6;
            Colcategory.Name = "Colcategory";
            Colcategory.ReadOnly = true;
            // 
            // Colprice
            // 
            Colprice.DataPropertyName = "Price";
            Colprice.HeaderText = "Price";
            Colprice.MinimumWidth = 6;
            Colprice.Name = "Colprice";
            Colprice.ReadOnly = true;
            // 
            // Colstock
            // 
            Colstock.DataPropertyName = "Stock";
            Colstock.HeaderText = "Stock";
            Colstock.MinimumWidth = 6;
            Colstock.Name = "Colstock";
            Colstock.ReadOnly = true;
            // 
            // Colstatus
            // 
            Colstatus.DataPropertyName = "Status";
            Colstatus.HeaderText = "Status";
            Colstatus.MinimumWidth = 6;
            Colstatus.Name = "Colstatus";
            Colstatus.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ProductViews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductViews";
            Size = new Size(918, 701);
            Load += ProductViews_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pnlgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVproducts).EndInit();
            ResumeLayout(false);

        }

        private void tsbview_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Add;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel pnlgrid;
        private System.Windows.Forms.DataGridView DGVproducts;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn Colname;
        private DataGridViewTextBoxColumn Colcategory;
        private DataGridViewTextBoxColumn Colprice;
        private DataGridViewTextBoxColumn Colstock;
        private DataGridViewTextBoxColumn Colstatus;
    }
}
