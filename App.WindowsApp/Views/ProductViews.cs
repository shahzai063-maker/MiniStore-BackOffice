using App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App.Core.Utilities;
using App.WindowsApp.Forms;
using App.Core.Models;

namespace App.WindowsApp.Views
{
    public partial class ProductViews : UserControl
    {


        IProductService _service;
        BindingSource _dgvBindingSource = new BindingSource();


        public ProductViews(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
            DGVproducts.DataSource = _dgvBindingSource;
        }

        private void ProductViews_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--All--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--All--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbStockStatus.SelectedIndex = 0;


            if (_service == null)
                return;

            _service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();





        }

        private void tsbedit_Click(object sender, EventArgs e)
        {
            Product? SelectedProduct = _dgvBindingSource.Current as Product;
            if (SelectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, SelectedProduct);
                prodForm.ShowDialog();
            }

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null);
            prodForm.ShowDialog();

        }

        private void tsbview_Click(object sender, EventArgs e)
        {
            Product? SelectedProduct = _dgvBindingSource.Current as Product;
            if (SelectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, SelectedProduct);
                prodForm.ShowDialog();
            }

        }
    }
}