using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale_System.Forms;

namespace PointOfSale_System.Forms
{
    public partial class PaymentMethodForm : Form
    {
        public PaymentMethodForm()
        {
            InitializeComponent();
        }

        private void btnBackToCheckOutPage_Click(object sender, EventArgs e)
        {
            SalesForm form = new SalesForm();
            form.Show();
            this.Hide();

        }
    }
}
