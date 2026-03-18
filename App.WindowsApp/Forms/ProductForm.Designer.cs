namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblName = new Label();
            cmbCat = new Label();
            nuPrice = new Label();
            nuStock = new Label();
            lblStatus = new Label();
            textid = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            numPrice = new NumericUpDown();
            numStock = new NumericUpDown();
            cmbStatus = new ComboBox();
            txtID = new TextBox();
            flpBottom = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            flpBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Controls.Add(cmbCat, 0, 1);
            tableLayoutPanel1.Controls.Add(nuPrice, 0, 2);
            tableLayoutPanel1.Controls.Add(nuStock, 0, 3);
            tableLayoutPanel1.Controls.Add(lblStatus, 0, 4);
            tableLayoutPanel1.Controls.Add(textid, 0, 5);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(numPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(numStock, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbStatus, 1, 4);
            tableLayoutPanel1.Controls.Add(txtID, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(640, 267);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(2, 0);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // cmbCat
            // 
            cmbCat.AutoSize = true;
            cmbCat.Location = new Point(2, 40);
            cmbCat.Margin = new Padding(2, 0, 2, 0);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(69, 20);
            cmbCat.TabIndex = 1;
            cmbCat.Text = "Category";
            // 
            // nuPrice
            // 
            nuPrice.AutoSize = true;
            nuPrice.Location = new Point(2, 80);
            nuPrice.Margin = new Padding(2, 0, 2, 0);
            nuPrice.Name = "nuPrice";
            nuPrice.Size = new Size(41, 20);
            nuPrice.TabIndex = 2;
            nuPrice.Text = "Price";
            // 
            // nuStock
            // 
            nuStock.AutoSize = true;
            nuStock.Location = new Point(2, 120);
            nuStock.Margin = new Padding(2, 0, 2, 0);
            nuStock.Name = "nuStock";
            nuStock.Size = new Size(45, 20);
            nuStock.TabIndex = 3;
            nuStock.Text = "Stock";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(2, 160);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // textid
            // 
            textid.AutoSize = true;
            textid.Location = new Point(2, 200);
            textid.Margin = new Padding(2, 0, 2, 0);
            textid.Name = "textid";
            textid.Size = new Size(24, 20);
            textid.TabIndex = 5;
            textid.Text = "ID";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(162, 2);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(476, 27);
            txtName.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(162, 42);
            cmbCategory.Margin = new Padding(2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(476, 28);
            cmbCategory.TabIndex = 7;
            // 
            // numPrice
            // 
            numPrice.Dock = DockStyle.Fill;
            numPrice.Location = new Point(162, 82);
            numPrice.Margin = new Padding(2);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(476, 27);
            numPrice.TabIndex = 8;
            // 
            // numStock
            // 
            numStock.Dock = DockStyle.Fill;
            numStock.Location = new Point(162, 122);
            numStock.Margin = new Padding(2);
            numStock.Name = "numStock";
            numStock.Size = new Size(476, 27);
            numStock.TabIndex = 9;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(162, 162);
            cmbStatus.Margin = new Padding(2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(476, 28);
            cmbStatus.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Dock = DockStyle.Fill;
            txtID.Location = new Point(162, 202);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(476, 27);
            txtID.TabIndex = 11;
            // 
            // flpBottom
            // 
            flpBottom.Controls.Add(btnSave);
            flpBottom.Controls.Add(btnCancel);
            flpBottom.Dock = DockStyle.Bottom;
            flpBottom.FlowDirection = FlowDirection.RightToLeft;
            flpBottom.Location = new Point(0, 268);
            flpBottom.Margin = new Padding(2);
            flpBottom.Name = "flpBottom";
            flpBottom.Size = new Size(640, 92);
            flpBottom.TabIndex = 1;
            flpBottom.Paint += flpBottom_Paint;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(548, 2);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(454, 2);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(flpBottom);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            flpBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblName;
        private Label cmbCat;
        private Label nuPrice;
        private Label nuStock;
        private Label lblStatus;
        private Label textid;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private NumericUpDown numPrice;
        private NumericUpDown numStock;
        private ComboBox cmbStatus;
        private TextBox txtID;
        private FlowLayoutPanel flpBottom;
        private Button btnCancel;
        private Button btnSave;
    }
}