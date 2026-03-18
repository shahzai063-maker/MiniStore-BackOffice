using App.Core.Contracts;
using App.Core.Services;
using App.WindowsApp.Views;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void PnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnLogs_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            this.PnlContent.Controls.Clear();
            this.PnlContent.Controls.Add(new ProductViews(new InMemoryProductService()));


        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.PnlContent.Controls.Clear();
            this.PnlContent.Controls.Add(new App.WindowsApp.Views.DashboardView());
            new DashboardView();
        }
        private void ShowView<T>(Func<T> factory) where T : UserControl
        {

            var key = typeof(T);

            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }
            if (!PnlContent.Controls.Contains(view))
            {
                PnlContent.Controls.Clear();
                PnlContent.Controls.Add(view);
            }

            view.BringToFront();
        }
    }
}
