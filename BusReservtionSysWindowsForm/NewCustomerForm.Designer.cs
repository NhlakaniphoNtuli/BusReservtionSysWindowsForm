namespace BusReservtionSysWindowsForm
{
    partial class NewCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomerForm));
            this.pnlNewCustomer = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNewCustomer = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNextKin = new System.Windows.Forms.Label();
            this.txtKinName = new System.Windows.Forms.TextBox();
            this.pnlNextKin = new System.Windows.Forms.Panel();
            this.lblKinName = new System.Windows.Forms.Label();
            this.lblKinPhone = new System.Windows.Forms.Label();
            this.txtKinPhone = new System.Windows.Forms.TextBox();
            this.pnlNewCustomer.SuspendLayout();
            this.pnlNextKin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewCustomer
            // 
            this.pnlNewCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNewCustomer.BackgroundImage")));
            this.pnlNewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNewCustomer.Controls.Add(this.pnlNextKin);
            this.pnlNewCustomer.Controls.Add(this.txtPhone);
            this.pnlNewCustomer.Controls.Add(this.lblPhone);
            this.pnlNewCustomer.Controls.Add(this.lblNewCustomer);
            this.pnlNewCustomer.Controls.Add(this.txtSurname);
            this.pnlNewCustomer.Controls.Add(this.lblSurname);
            this.pnlNewCustomer.Controls.Add(this.txtName);
            this.pnlNewCustomer.Controls.Add(this.lblName);
            this.pnlNewCustomer.Location = new System.Drawing.Point(2, 2);
            this.pnlNewCustomer.Name = "pnlNewCustomer";
            this.pnlNewCustomer.Size = new System.Drawing.Size(794, 445);
            this.pnlNewCustomer.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPhone.Location = new System.Drawing.Point(286, 184);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(259, 20);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "(e.g 072 105 4356)";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(215, 187);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // lblNewCustomer
            // 
            this.lblNewCustomer.AutoSize = true;
            this.lblNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCustomer.Location = new System.Drawing.Point(279, 7);
            this.lblNewCustomer.Name = "lblNewCustomer";
            this.lblNewCustomer.Size = new System.Drawing.Size(256, 38);
            this.lblNewCustomer.TabIndex = 4;
            this.lblNewCustomer.Text = "New Customer:";
            // 
            // txtSurname
            // 
            this.txtSurname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSurname.Location = new System.Drawing.Point(286, 156);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(259, 20);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.Text = "(e.g Ntuli)";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(215, 159);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Location = new System.Drawing.Point(286, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "(e.g Nhlakanipho)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(215, 132);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblNextKin
            // 
            this.lblNextKin.AutoSize = true;
            this.lblNextKin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextKin.Location = new System.Drawing.Point(12, 11);
            this.lblNextKin.Name = "lblNextKin";
            this.lblNextKin.Size = new System.Drawing.Size(85, 16);
            this.lblNextKin.TabIndex = 7;
            this.lblNextKin.Text = "Next of Kin:";
            // 
            // txtKinName
            // 
            this.txtKinName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtKinName.Location = new System.Drawing.Point(65, 41);
            this.txtKinName.Name = "txtKinName";
            this.txtKinName.Size = new System.Drawing.Size(262, 20);
            this.txtKinName.TabIndex = 8;
            this.txtKinName.Text = "(e.g Slindile Biyela)";
            // 
            // pnlNextKin
            // 
            this.pnlNextKin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlNextKin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNextKin.Controls.Add(this.txtKinPhone);
            this.pnlNextKin.Controls.Add(this.txtKinName);
            this.pnlNextKin.Controls.Add(this.lblKinPhone);
            this.pnlNextKin.Controls.Add(this.lblKinName);
            this.pnlNextKin.Controls.Add(this.lblNextKin);
            this.pnlNextKin.Location = new System.Drawing.Point(218, 210);
            this.pnlNextKin.Name = "pnlNextKin";
            this.pnlNextKin.Size = new System.Drawing.Size(343, 100);
            this.pnlNextKin.TabIndex = 9;
            // 
            // lblKinName
            // 
            this.lblKinName.AutoSize = true;
            this.lblKinName.Location = new System.Drawing.Point(15, 44);
            this.lblKinName.Name = "lblKinName";
            this.lblKinName.Size = new System.Drawing.Size(38, 13);
            this.lblKinName.TabIndex = 8;
            this.lblKinName.Text = "Name:";
            // 
            // lblKinPhone
            // 
            this.lblKinPhone.AutoSize = true;
            this.lblKinPhone.Location = new System.Drawing.Point(15, 66);
            this.lblKinPhone.Name = "lblKinPhone";
            this.lblKinPhone.Size = new System.Drawing.Size(41, 13);
            this.lblKinPhone.TabIndex = 9;
            this.lblKinPhone.Text = "Phone:";
            // 
            // txtKinPhone
            // 
            this.txtKinPhone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtKinPhone.Location = new System.Drawing.Point(65, 63);
            this.txtKinPhone.Name = "txtKinPhone";
            this.txtKinPhone.Size = new System.Drawing.Size(262, 20);
            this.txtKinPhone.TabIndex = 10;
            this.txtKinPhone.Text = "(e.g 072 456 3378)";
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlNewCustomer);
            this.Name = "NewCustomerForm";
            this.Text = "New Customer";
            this.Shown += new System.EventHandler(this.NewCustomerForm_Shown);
            this.pnlNewCustomer.ResumeLayout(false);
            this.pnlNewCustomer.PerformLayout();
            this.pnlNextKin.ResumeLayout(false);
            this.pnlNextKin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewCustomer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblNewCustomer;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel pnlNextKin;
        private System.Windows.Forms.TextBox txtKinPhone;
        private System.Windows.Forms.TextBox txtKinName;
        private System.Windows.Forms.Label lblKinPhone;
        private System.Windows.Forms.Label lblKinName;
        private System.Windows.Forms.Label lblNextKin;
    }
}