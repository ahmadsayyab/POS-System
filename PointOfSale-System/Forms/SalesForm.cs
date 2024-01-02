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
    public partial class SalesForm : Form
    {
        Services services = new Services();
        Sale sale = new Sale();
        SaleServices saleServices = new SaleServices();



        int productId;
        public SalesForm()
        {
            InitializeComponent();
        }


        // Add columns to DataGridView
        private void InitializeDataGridView()
        {
            
            dgvSales.Columns.Clear();
            

            dgvSales.Columns.Add("ProductName", "Product Name");
            dgvSales.Columns.Add("ProductPrice", "Price");
            dgvSales.Columns.Add("Quantity", "Quantity");
            dgvSales.Columns.Add("TotalAmount", "Total Amount");
            dgvSales.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }


        //display products name in the listbox
        void BindListView()
        {
            DataTable products = services.LoadProductData();
            lstProductList.DataSource = products;
            lstProductList.DisplayMember = "Name";

        }
        private void SalesForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            BindListView();
            lstProductList.SelectedIndex = -1;

        }

        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            if (lstProductList.SelectedIndex != -1)
            {
                
                DataRowView drv = (DataRowView)lstProductList.SelectedItem;

                
                productId = Convert.ToInt32(drv["Id"]); 
                string productName = drv["Name"].ToString();
                double productPrice = Convert.ToDouble(drv["Price"]); 

                
                txtName.Text = productName;
                txtPrice.Text = productPrice.ToString();
            }
            else
            {
                
                txtName.Text = "";
                txtPrice.Text = "";
            }
        }

        private void btnAddToSale_Click(object sender, EventArgs e)
        {

            if (lstProductList.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Extract product details from the selected item
            DataRowView selectedDataRow = (DataRowView)lstProductList.SelectedItem;
            int productId = Convert.ToInt32(selectedDataRow["Id"]); 
            string productName = selectedDataRow["Name"].ToString();
            double productPrice = Convert.ToDouble(selectedDataRow["Price"]);


             sale.QuantitySold = (int)nudEnterQuantity.Value;
             sale.TotalAmount = productPrice * sale.QuantitySold;


            // Add to DataGridView
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgvSales);
            newRow.SetValues(productName, productPrice, sale.QuantitySold, sale.TotalAmount);
            dgvSales.Rows.Add(newRow);

            saleServices.Add(productId, sale);
            CalculateGrandTotal();

        }


        //calculate grand total
        private decimal CalculateGrandTotal()
        {
            decimal grandTotal = 0;
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                grandTotal += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
            }
            lblGrandTotal.Text = $"Grand Total: {grandTotal:C}";

            return grandTotal;
        }

        private void btnBackToHomePage_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        //Extract Data from datagridview
        private List<SaleDetail> ExtractSalesDetailsFromGrid()
        {
            var details = new List<SaleDetail>();

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                var detail = new SaleDetail
                {
                    ProductName = row.Cells["ProductName"].Value.ToString(),
                    Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    TotalAmount = Convert.ToDouble(row.Cells["TotalAmount"].Value)
                };
                details.Add(detail);
            }

            return details;
        }


        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            var salesDetails = ExtractSalesDetailsFromGrid();
            var grandTotal = CalculateGrandTotal();  

            CheckoutForm checkoutForm = new CheckoutForm(salesDetails, grandTotal);

            checkoutForm.Show();
            this.Hide();
        }

          
        
    }
}
