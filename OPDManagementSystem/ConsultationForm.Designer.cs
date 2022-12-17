namespace OPDManagementSystem
{
    partial class ConsultationForm
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
            this.lblHeadingConsultation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeadingConsultation
            // 
            this.lblHeadingConsultation.AutoSize = true;
            this.lblHeadingConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingConsultation.Location = new System.Drawing.Point(12, 26);
            this.lblHeadingConsultation.Name = "lblHeadingConsultation";
            this.lblHeadingConsultation.Size = new System.Drawing.Size(98, 20);
            this.lblHeadingConsultation.TabIndex = 0;
            this.lblHeadingConsultation.Text = "Consultation";
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 244);
            this.Controls.Add(this.lblHeadingConsultation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ConsultationForm";
            this.Text = "ConsultationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingConsultation;
    }
}