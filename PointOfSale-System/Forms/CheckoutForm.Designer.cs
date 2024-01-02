namespace PointOfSale_System.Forms
{
    partial class CheckoutForm
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
            this.rtxReceipt = new System.Windows.Forms.RichTextBox();
            this.btnPaymentMethod = new System.Windows.Forms.Button();
            this.btnDownloadReceipt = new System.Windows.Forms.Button();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.btnBackToSalePage = new System.Windows.Forms.Button();
            this.pnlUP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUP
            // 
            this.pnlUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUP.Controls.Add(this.lblMainHeading);
            this.pnlUP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUP.Location = new System.Drawing.Point(0, 0);
            this.pnlUP.Name = "pnlUP";
            this.pnlUP.Size = new System.Drawing.Size(581, 61);
            this.pnlUP.TabIndex = 2;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(211, 21);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(118, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Checkout ";
            // 
            // rtxReceipt
            // 
            this.rtxReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxReceipt.Location = new System.Drawing.Point(25, 67);
            this.rtxReceipt.Name = "rtxReceipt";
            this.rtxReceipt.ReadOnly = true;
            this.rtxReceipt.Size = new System.Drawing.Size(526, 246);
            this.rtxReceipt.TabIndex = 4;
            this.rtxReceipt.Text = "";
            // 
            // btnPaymentMethod
            // 
            this.btnPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentMethod.Location = new System.Drawing.Point(49, 332);
            this.btnPaymentMethod.Name = "btnPaymentMethod";
            this.btnPaymentMethod.Size = new System.Drawing.Size(136, 34);
            this.btnPaymentMethod.TabIndex = 5;
            this.btnPaymentMethod.Text = "Payment Method";
            this.btnPaymentMethod.UseVisualStyleBackColor = true;
            this.btnPaymentMethod.Click += new System.EventHandler(this.btnPaymentMethod_Click);
            // 
            // btnDownloadReceipt
            // 
            this.btnDownloadReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadReceipt.Location = new System.Drawing.Point(216, 332);
            this.btnDownloadReceipt.Name = "btnDownloadReceipt";
            this.btnDownloadReceipt.Size = new System.Drawing.Size(145, 34);
            this.btnDownloadReceipt.TabIndex = 5;
            this.btnDownloadReceipt.Text = "Download Receipt";
            this.btnDownloadReceipt.UseVisualStyleBackColor = true;
            this.btnDownloadReceipt.Click += new System.EventHandler(this.btnDownloadReceipt_Click);
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 388);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(581, 14);
            this.pnlDown.TabIndex = 3;
            // 
            // btnBackToSalePage
            // 
            this.btnBackToSalePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToSalePage.Location = new System.Drawing.Point(377, 332);
            this.btnBackToSalePage.Name = "btnBackToSalePage";
            this.btnBackToSalePage.Size = new System.Drawing.Size(146, 34);
            this.btnBackToSalePage.TabIndex = 6;
            this.btnBackToSalePage.Text = "Back to Sale page";
            this.btnBackToSalePage.UseVisualStyleBackColor = true;
            this.btnBackToSalePage.Click += new System.EventHandler(this.btnBackToSalePage_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 402);
            this.Controls.Add(this.btnBackToSalePage);
            this.Controls.Add(this.btnDownloadReceipt);
            this.Controls.Add(this.btnPaymentMethod);
            this.Controls.Add(this.rtxReceipt);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlUP);
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.pnlUP.ResumeLayout(false);
            this.pnlUP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUP;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.RichTextBox rtxReceipt;
        private System.Windows.Forms.Button btnPaymentMethod;
        private System.Windows.Forms.Button btnDownloadReceipt;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Button btnBackToSalePage;
    }
}