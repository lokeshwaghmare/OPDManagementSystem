using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPDManagementSystem
{
    public partial class Home : Form
    {
        private Form activeForm = null;
        public Home()
        {
            InitializeComponent();
        }

        private void linkLblOption_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new OptionsForm());
        }

        private void openForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();            
        }

        private void lnkLblConsultation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new ConsultationForm());
        }

        private void lnkLblReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new ReportsForm());
        }
    }
}
