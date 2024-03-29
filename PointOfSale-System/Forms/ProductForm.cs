﻿using PointOfSale_System.Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using PointOfSale_System;

namespace PointOfSale_System.Forms
{
    public partial class ProductForm : Form
    {


        BaseService baseService = new BaseService();
       
        Product product = new Product();
        ProductService productService = new ProductService();

        int id;
        bool result;
        public ProductForm()
        {
            InitializeComponent();
        }


        //Ensure valid inputs
        private void EnsureValidNumericInput(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                // Allow backspace (ASCII code 8)
                e.Handled = false;
            }
            else if (ch == 46)
            {
                // Allow period/dot (ASCII code 46)
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Reset textboxes
        private void ResetFields()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }

        
        //insert product data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtPrice.Text == string.Empty || txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please fill all the fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                product.Name = txtName.Text.Trim();
                product.Price = double.Parse(txtPrice.Text.Trim());
                product.Quantity = int.Parse(txtQuantity.Text.Trim());

                result = productService.Add(product);

                if (result == true)
                {
                    MessageBox.Show("Product data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGridView();
                    ResetFields();
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("Data failed to be inserted", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        //load proudct data into datagridview
        void BindGridView()
        {
            dgvProductData.DataSource = baseService.LoadProductData();
            dgvProductData.Columns["Id"].Visible = false;
            dgvProductData.Columns["IsActive"].Visible = false;

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            BindGridView();
            dgvProductData.ClearSelection();
        }



        //update product data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtPrice.Text == string.Empty || txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please first select a row which you want to be updated!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                product.Name = txtName.Text.Trim();
                product.Price = Convert.ToDouble(txtPrice.Text.Trim());
                product.Quantity = Convert.ToInt32(txtQuantity.Text.Trim());


                result = productService.Update(product,id);
                //result = productService.Update(product);

                if (result == true)
                {
                    MessageBox.Show("Data Updated successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindGridView();
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Failed to Update Data: Something went wrong during the update process", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
            
            
        }

        //delete product data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtPrice.Text == string.Empty || txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please first select a row which you want to be deleted!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {

                    result = productService.Delete(id);

                    if (result == true)
                    {
                        MessageBox.Show("Data deleted successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BindGridView();
                        ResetFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Data: Something went wrong during the deletion process", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            
        }


        //reset text fields
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ResetFields();
        }


        //search product by name
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                MessageBox.Show("Please first enter a name in the search bar!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string productName = txtSearch.Text;
                DataTable searchResult = productService.Search(productName);

                if (searchResult.Rows.Count == 0)
                {
                    MessageBox.Show("No product found with the provided name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Focus();
                }
                else
                {
                    dgvProductData.DataSource = searchResult;
                }
            }

        }

        private void btnBackToHomePage_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void dgvProductData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProductData.SelectedRows[0];

                
                id = Convert.ToInt32(selectedRow.Cells[0].Value);
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtPrice.Text = selectedRow.Cells[2].Value.ToString();
                txtQuantity.Text = selectedRow.Cells[3].Value.ToString();
            }
            else
            {
               ResetFields();
            }
        }
    }
}
