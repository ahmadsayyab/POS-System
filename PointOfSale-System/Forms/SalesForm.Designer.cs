namespace PointOfSale_System.Forms
{
    partial class SalesForm
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
            this.pnlUP = new System.Windows.Forms.Panel();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.lstProductList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.nudEnterQuantity = new System.Windows.Forms.NumericUpDown();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnAddToSale = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnBackToHomePage = new System.Windows.Forms.Button();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.lblProductList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDiscountPerItem = new System.Windows.Forms.NumericUpDown();
            this.lblPerInvoiceDiscount = new System.Windows.Forms.Label();
            this.pnlUP.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnterQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountPerItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUP
            // 
            this.pnlUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUP.Controls.Add(this.lblMainHeading);
            this.pnlUP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUP.Location = new System.Drawing.Point(0, 0);
            this.pnlUP.Name = "pnlUP";
            this.pnlUP.Size = new System.Drawing.Size(710, 61);
            this.pnlUP.TabIndex = 2;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(266, 21);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(202, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Sales Transaction";
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 619);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(710, 14);
            this.pnlDown.TabIndex = 3;
            // 
            // lstProductList
            // 
            this.lstProductList.FormattingEnabled = true;
            this.lstProductList.Location = new System.Drawing.Point(12, 105);
            this.lstProductList.Name = "lstProductList";
            this.lstProductList.Size = new System.Drawing.Size(197, 459);
            this.lstProductList.TabIndex = 4;
            this.lstProductList.SelectedIndexChanged += new System.EventHandler(this.lstProductList_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.43195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.56805F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudEnterQuantity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudDiscountPerItem, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(234, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 131);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(3, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 16);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(3, 77);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 16);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Location = new System.Drawing.Point(138, 10);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrice.Location = new System.Drawing.Point(138, 45);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // nudEnterQuantity
            // 
            this.nudEnterQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudEnterQuantity.Location = new System.Drawing.Point(138, 75);
            this.nudEnterQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudEnterQuantity.Name = "nudEnterQuantity";
            this.nudEnterQuantity.Size = new System.Drawing.Size(200, 20);
            this.nudEnterQuantity.TabIndex = 0;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(234, 416);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.Size = new System.Drawing.Size(405, 150);
            this.dgvSales.TabIndex = 6;
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToSale.Location = new System.Drawing.Point(285, 367);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(140, 30);
            this.btnAddToSale.TabIndex = 1;
            this.btnAddToSale.Text = "Add to Sale";
            this.btnAddToSale.UseVisualStyleBackColor = true;
            this.btnAddToSale.Click += new System.EventHandler(this.btnAddToSale_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(231, 317);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(97, 16);
            this.lblGrandTotal.TabIndex = 7;
            this.lblGrandTotal.Text = "Grand Total: ";
            // 
            // btnBackToHomePage
            // 
            this.btnBackToHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomePage.Location = new System.Drawing.Point(234, 572);
            this.btnBackToHomePage.Name = "btnBackToHomePage";
            this.btnBackToHomePage.Size = new System.Drawing.Size(405, 26);
            this.btnBackToHomePage.TabIndex = 8;
            this.btnBackToHomePage.Text = "Back to Home Page";
            this.btnBackToHomePage.UseVisualStyleBackColor = true;
            this.btnBackToHomePage.Click += new System.EventHandler(this.btnBackToHomePage_Click);
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPayment.Location = new System.Drawing.Point(442, 367);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(140, 30);
            this.btnProcessPayment.TabIndex = 9;
            this.btnProcessPayment.Text = "Process payment";
            this.btnProcessPayment.UseVisualStyleBackColor = true;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click);
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.Location = new System.Drawing.Point(12, 73);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(114, 20);
            this.lblProductList.TabIndex = 10;
            this.lblProductList.Text = "Products List";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discount (%)";
            // 
            // nudDiscountPerItem
            // 
            this.nudDiscountPerItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudDiscountPerItem.Location = new System.Drawing.Point(138, 105);
            this.nudDiscountPerItem.Name = "nudDiscountPerItem";
            this.nudDiscountPerItem.Size = new System.Drawing.Size(200, 20);
            this.nudDiscountPerItem.TabIndex = 3;
            // 
            // lblPerInvoiceDiscount
            // 
            this.lblPerInvoiceDiscount.AutoSize = true;
            this.lblPerInvoiceDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerInvoiceDiscount.Location = new System.Drawing.Point(231, 282);
            this.lblPerInvoiceDiscount.Name = "lblPerInvoiceDiscount";
            this.lblPerInvoiceDiscount.Size = new System.Drawing.Size(157, 16);
            this.lblPerInvoiceDiscount.TabIndex = 11;
            this.lblPerInvoiceDiscount.Text = "Per Invoice Discount: ";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 633);
            this.Controls.Add(this.lblPerInvoiceDiscount);
            this.Controls.Add(this.lblProductList);
            this.Controls.Add(this.btnProcessPayment);
            this.Controls.Add(this.btnBackToHomePage);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.btnAddToSale);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lstProductList);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlUP);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.pnlUP.ResumeLayout(false);
            this.pnlUP.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnterQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountPerItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUP;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.ListBox lstProductList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown nudEnterQuantity;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnAddToSale;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnBackToHomePage;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDiscountPerItem;
        private System.Windows.Forms.Label lblPerInvoiceDiscount;
    }
}