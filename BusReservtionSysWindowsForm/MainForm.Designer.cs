namespace BusReservtionSysWindowsForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.picEditAgent = new System.Windows.Forms.PictureBox();
            this.lblAgentId = new System.Windows.Forms.Label();
            this.lblAgentUsername = new System.Windows.Forms.Label();
            this.picAgent = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblManageRental = new System.Windows.Forms.Label();
            this.picMnageRental = new System.Windows.Forms.PictureBox();
            this.lblManageTicket = new System.Windows.Forms.Label();
            this.picManageTicket = new System.Windows.Forms.PictureBox();
            this.btnReservationReport = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnNewBus = new System.Windows.Forms.Button();
            this.bntNewCustomer = new System.Windows.Forms.Button();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMnageRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageTicket)).BeginInit();
            this.pnlNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeading
            // 
            this.pnlHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeading.Controls.Add(this.picEditAgent);
            this.pnlHeading.Controls.Add(this.lblAgentId);
            this.pnlHeading.Controls.Add(this.lblAgentUsername);
            this.pnlHeading.Controls.Add(this.picAgent);
            this.pnlHeading.Controls.Add(this.picLogo);
            this.pnlHeading.Location = new System.Drawing.Point(4, 4);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(793, 86);
            this.pnlHeading.TabIndex = 0;
            // 
            // picEditAgent
            // 
            this.picEditAgent.Image = ((System.Drawing.Image)(resources.GetObject("picEditAgent.Image")));
            this.picEditAgent.Location = new System.Drawing.Point(112, 62);
            this.picEditAgent.Name = "picEditAgent";
            this.picEditAgent.Size = new System.Drawing.Size(59, 21);
            this.picEditAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEditAgent.TabIndex = 4;
            this.picEditAgent.TabStop = false;
            // 
            // lblAgentId
            // 
            this.lblAgentId.AutoSize = true;
            this.lblAgentId.Location = new System.Drawing.Point(109, 18);
            this.lblAgentId.Name = "lblAgentId";
            this.lblAgentId.Size = new System.Drawing.Size(54, 13);
            this.lblAgentId.TabIndex = 3;
            this.lblAgentId.Text = "lblAgentId";
            // 
            // lblAgentUsername
            // 
            this.lblAgentUsername.AutoSize = true;
            this.lblAgentUsername.Location = new System.Drawing.Point(109, 5);
            this.lblAgentUsername.Name = "lblAgentUsername";
            this.lblAgentUsername.Size = new System.Drawing.Size(93, 13);
            this.lblAgentUsername.TabIndex = 2;
            this.lblAgentUsername.Text = "lblAgentUsername";
            // 
            // picAgent
            // 
            this.picAgent.Image = ((System.Drawing.Image)(resources.GetObject("picAgent.Image")));
            this.picAgent.Location = new System.Drawing.Point(3, 3);
            this.picAgent.Name = "picAgent";
            this.picAgent.Size = new System.Drawing.Size(100, 80);
            this.picAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgent.TabIndex = 1;
            this.picAgent.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(224, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(566, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNavigation.Controls.Add(this.picExit);
            this.pnlNavigation.Controls.Add(this.lblManageRental);
            this.pnlNavigation.Controls.Add(this.picMnageRental);
            this.pnlNavigation.Controls.Add(this.lblManageTicket);
            this.pnlNavigation.Controls.Add(this.picManageTicket);
            this.pnlNavigation.Controls.Add(this.btnReservationReport);
            this.pnlNavigation.Controls.Add(this.btnCancelReservation);
            this.pnlNavigation.Controls.Add(this.btnReserve);
            this.pnlNavigation.Controls.Add(this.btnNewBus);
            this.pnlNavigation.Controls.Add(this.bntNewCustomer);
            this.pnlNavigation.Location = new System.Drawing.Point(4, 96);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(218, 352);
            this.pnlNavigation.TabIndex = 1;
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(3, 326);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(100, 19);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 1;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblManageRental
            // 
            this.lblManageRental.AutoSize = true;
            this.lblManageRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRental.Location = new System.Drawing.Point(51, 98);
            this.lblManageRental.Name = "lblManageRental";
            this.lblManageRental.Size = new System.Drawing.Size(93, 13);
            this.lblManageRental.TabIndex = 9;
            this.lblManageRental.Text = "Manage Rental";
            // 
            // picMnageRental
            // 
            this.picMnageRental.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMnageRental.Image = ((System.Drawing.Image)(resources.GetObject("picMnageRental.Image")));
            this.picMnageRental.Location = new System.Drawing.Point(54, 114);
            this.picMnageRental.Name = "picMnageRental";
            this.picMnageRental.Size = new System.Drawing.Size(90, 68);
            this.picMnageRental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMnageRental.TabIndex = 8;
            this.picMnageRental.TabStop = false;
            // 
            // lblManageTicket
            // 
            this.lblManageTicket.AutoSize = true;
            this.lblManageTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageTicket.Location = new System.Drawing.Point(51, 11);
            this.lblManageTicket.Name = "lblManageTicket";
            this.lblManageTicket.Size = new System.Drawing.Size(92, 13);
            this.lblManageTicket.TabIndex = 7;
            this.lblManageTicket.Text = "Manage Ticket";
            // 
            // picManageTicket
            // 
            this.picManageTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picManageTicket.Image = ((System.Drawing.Image)(resources.GetObject("picManageTicket.Image")));
            this.picManageTicket.Location = new System.Drawing.Point(54, 27);
            this.picManageTicket.Name = "picManageTicket";
            this.picManageTicket.Size = new System.Drawing.Size(90, 59);
            this.picManageTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManageTicket.TabIndex = 6;
            this.picManageTicket.TabStop = false;
            this.picManageTicket.Click += new System.EventHandler(this.picManageTicket_Click);
            // 
            // btnReservationReport
            // 
            this.btnReservationReport.Location = new System.Drawing.Point(8, 297);
            this.btnReservationReport.Name = "btnReservationReport";
            this.btnReservationReport.Size = new System.Drawing.Size(205, 23);
            this.btnReservationReport.TabIndex = 4;
            this.btnReservationReport.Text = "Bus Reservation Report";
            this.btnReservationReport.UseVisualStyleBackColor = true;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Location = new System.Drawing.Point(8, 267);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(207, 23);
            this.btnCancelReservation.TabIndex = 3;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(8, 237);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(207, 23);
            this.btnReserve.TabIndex = 2;
            this.btnReserve.Text = "Reserve Bus";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnNewBus
            // 
            this.btnNewBus.Location = new System.Drawing.Point(8, 208);
            this.btnNewBus.Name = "btnNewBus";
            this.btnNewBus.Size = new System.Drawing.Size(207, 23);
            this.btnNewBus.TabIndex = 1;
            this.btnNewBus.Text = "New Bus";
            this.btnNewBus.UseVisualStyleBackColor = true;
            // 
            // bntNewCustomer
            // 
            this.bntNewCustomer.Location = new System.Drawing.Point(8, 188);
            this.bntNewCustomer.Name = "bntNewCustomer";
            this.bntNewCustomer.Size = new System.Drawing.Size(207, 23);
            this.bntNewCustomer.TabIndex = 0;
            this.bntNewCustomer.Text = "New Customer";
            this.bntNewCustomer.UseVisualStyleBackColor = true;
            this.bntNewCustomer.Click += new System.EventHandler(this.bntNewCustomer_Click);
            // 
            // pnlNotification
            // 
            this.pnlNotification.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlNotification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNotification.Controls.Add(this.label2);
            this.pnlNotification.Location = new System.Drawing.Point(228, 96);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(569, 352);
            this.pnlNotification.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notifications:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeading);
            this.Name = "MainForm";
            this.Text = "Bus Reservation System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlHeading.ResumeLayout(false);
            this.pnlHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMnageRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageTicket)).EndInit();
            this.pnlNotification.ResumeLayout(false);
            this.pnlNotification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button bntNewCustomer;
        private System.Windows.Forms.Panel pnlNotification;
        private System.Windows.Forms.Button btnReservationReport;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnNewBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAgentUsername;
        private System.Windows.Forms.PictureBox picAgent;
        private System.Windows.Forms.Label lblAgentId;
        private System.Windows.Forms.PictureBox picEditAgent;
        private System.Windows.Forms.PictureBox picManageTicket;
        private System.Windows.Forms.Label lblManageTicket;
        private System.Windows.Forms.Label lblManageRental;
        private System.Windows.Forms.PictureBox picMnageRental;
        private System.Windows.Forms.PictureBox picExit;
    }
}

