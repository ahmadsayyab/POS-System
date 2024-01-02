namespace PointOfSale_System
{
    partial class frmMain
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
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnManageInventory = new System.Windows.Forms.Button();
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
            this.pnlUP.Size = new System.Drawing.Size(395, 47);
            this.pnlUP.TabIndex = 0;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(79, 9);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(231, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Point of Sale System";
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 300);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(395, 14);
            this.pnlDown.TabIndex = 1;
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagement.Location = new System.Drawing.Point(84, 90);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(226, 34);
            this.btnProductManagement.TabIndex = 0;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Process Sales";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInventory.Location = new System.Drawing.Point(84, 224);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(226, 34);
            this.btnManageInventory.TabIndex = 3;
            this.btnManageInventory.Text = "Manage inventory";
            this.btnManageInventory.UseVisualStyleBackColor = true;
            this.btnManageInventory.Click += new System.EventHandler(this.btnManageInventory_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 314);
            this.Controls.Add(this.btnManageInventory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProductManagement);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlUP);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale System";
            this.pnlUP.ResumeLayout(false);
            this.pnlUP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUP;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManageInventory;
    }
}

