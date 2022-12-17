namespace OPDManagementSystem
{
    partial class Home
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
            this.panelHeading = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.linkLblOption = new System.Windows.Forms.LinkLabel();
            this.lnkLblConsultation = new System.Windows.Forms.LinkLabel();
            this.lnkLblReports = new System.Windows.Forms.LinkLabel();
            this.panelHeading.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelHeading.Controls.Add(this.lblHeading);
            this.panelHeading.Location = new System.Drawing.Point(12, 12);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(702, 43);
            this.panelHeading.TabIndex = 0;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSideMenu.Controls.Add(this.lnkLblReports);
            this.panelSideMenu.Controls.Add(this.lnkLblConsultation);
            this.panelSideMenu.Controls.Add(this.linkLblOption);
            this.panelSideMenu.Location = new System.Drawing.Point(13, 62);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(128, 376);
            this.panelSideMenu.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(147, 62);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(567, 376);
            this.panelContainer.TabIndex = 2;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(178, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(265, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "OPD Management System";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLblOption
            // 
            this.linkLblOption.AutoSize = true;
            this.linkLblOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblOption.LinkColor = System.Drawing.Color.Black;
            this.linkLblOption.Location = new System.Drawing.Point(13, 30);
            this.linkLblOption.Name = "linkLblOption";
            this.linkLblOption.Size = new System.Drawing.Size(75, 24);
            this.linkLblOption.TabIndex = 0;
            this.linkLblOption.TabStop = true;
            this.linkLblOption.Text = "Options";
            this.linkLblOption.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblOption_LinkClicked);
            // 
            // lnkLblConsultation
            // 
            this.lnkLblConsultation.AutoSize = true;
            this.lnkLblConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblConsultation.LinkColor = System.Drawing.Color.Black;
            this.lnkLblConsultation.Location = new System.Drawing.Point(13, 71);
            this.lnkLblConsultation.Name = "lnkLblConsultation";
            this.lnkLblConsultation.Size = new System.Drawing.Size(113, 24);
            this.lnkLblConsultation.TabIndex = 1;
            this.lnkLblConsultation.TabStop = true;
            this.lnkLblConsultation.Text = "Consultation";
            this.lnkLblConsultation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblConsultation_LinkClicked);
            // 
            // lnkLblReports
            // 
            this.lnkLblReports.AutoSize = true;
            this.lnkLblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblReports.LinkColor = System.Drawing.Color.Black;
            this.lnkLblReports.Location = new System.Drawing.Point(15, 114);
            this.lnkLblReports.Name = "lnkLblReports";
            this.lnkLblReports.Size = new System.Drawing.Size(75, 24);
            this.lnkLblReports.TabIndex = 2;
            this.lnkLblReports.TabStop = true;
            this.lnkLblReports.Text = "Reports";
            this.lnkLblReports.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblReports_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelHeading);
            this.Name = "Home";
            this.Text = "OPD Management System";
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.LinkLabel lnkLblReports;
        private System.Windows.Forms.LinkLabel lnkLblConsultation;
        private System.Windows.Forms.LinkLabel linkLblOption;
    }
}

