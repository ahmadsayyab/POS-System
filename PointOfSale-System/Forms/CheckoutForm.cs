using iTextSharp.text.pdf;
using iTextSharp.text;
using PointOfSale_System.Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Font = System.Drawing.Font;

namespace PointOfSale_System.Forms
{
    public partial class CheckoutForm : Form
    {
        private List<SaleDetail> saleDetails;
        private decimal grandTotal;
        public CheckoutForm(List<SaleDetail> saleDetails, decimal grandTotal)
        {
            InitializeComponent();
            this.saleDetails = saleDetails;
            this.grandTotal = grandTotal;
        }

       
        //generate Receipt

        private void GenerateReceipt()
        {
            rtxReceipt.Clear();

            // Set the center alignment
            rtxReceipt.SelectionAlignment = HorizontalAlignment.Center;

            StringBuilder receiptContent = new StringBuilder();
            receiptContent.AppendLine("Receipt\n---------\nItems Purchased:\n");

            foreach (var item in saleDetails)
            {
                receiptContent.AppendLine($"{item.ProductName} - Quantity: {item.Quantity} - Total: ${item.TotalAmount} - DiscountPerItem: {item.DiscountPerItem} %");
            }

            receiptContent.AppendLine($"\nGrand Total: ${grandTotal}");
            rtxReceipt.Text = receiptContent.ToString();

          
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            GenerateReceipt();
        
        }


        //download Receipt in pdf form
        private void SaveReceiptAsPdf()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF file (*.pdf)|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDoc.Open();
                    pdfDoc.Add(new Paragraph(rtxReceipt.Text));
                    pdfDoc.Close();
                    MessageBox.Show("Receipt saved as PDF.","Receipt Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDownloadReceipt_Click(object sender, EventArgs e)
        {
            SaveReceiptAsPdf();
        }

        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            PaymentMethodForm paymentMethodForm = new PaymentMethodForm();
            paymentMethodForm.Show();
            this.Hide();
        }

        private void btnBackToSalePage_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.Show();
            this.Hide();
        }
    }
}
