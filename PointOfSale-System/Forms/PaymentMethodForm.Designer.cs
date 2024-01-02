namespace PointOfSale_System.Forms
{
    partial class PaymentMethodForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBackToSalePage = new System.Windows.Forms.Button();
            this.pnlUP.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUP
            // 
            this.pnlUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUP.Controls.Add(this.lblMainHeading);
            this.pnlUP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUP.Location = new System.Drawing.Point(0, 0);
            this.pnlUP.Name = "pnlUP";
            this.pnlUP.Size = new System.Drawing.Size(589, 61);
            this.pnlUP.TabIndex = 3;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(111, 22);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(275, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Choose Payment Method";
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 477);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(589, 14);
            this.pnlDown.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 352);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cash";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Credit Card";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBackToSalePage
            // 
            this.btnBackToSalePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToSalePage.Location = new System.Drawing.Point(116, 436);
            this.btnBackToSalePage.Name = "btnBackToSalePage";
            this.btnBackToSalePage.Size = new System.Drawing.Size(261, 35);
            this.btnBackToSalePage.TabIndex = 6;
            this.btnBackToSalePage.Text = "Back to Sale Page";
            this.btnBackToSalePage.UseVisualStyleBackColor = true;
            this.btnBackToSalePage.Click += new System.EventHandler(this.btnBackToCheckOutPage_Click);
            // 
            // PaymentMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 491);
            this.Controls.Add(this.btnBackToSalePage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlUP);
            this.Name = "PaymentMethodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentMethodForm";
            this.pnlUP.ResumeLayout(false);
            this.pnlUP.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUP;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBackToSalePage;
    }
}