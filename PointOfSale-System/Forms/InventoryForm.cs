using PointOfSale_System.Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_System.Forms
{
    public partial class InventoryForm : Form
    {
        Services services = new Services();
        public InventoryForm()
        {
            InitializeComponent();
        }


        //load proudcts data into datagridview
        void BindGridView()
        {
            dgvStockDetail.DataSource = services.LoadProductData();

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void btnBackToHomePage_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
