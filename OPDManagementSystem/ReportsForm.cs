using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPDManagementSystem.DAL;

namespace OPDManagementSystem
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            loadDoctors();
        }

        public void loadDoctors()
        {
            var dbCon = new DatabaseConn();
            var dataAdapter = dbCon.getDoctorsList();
        }
    }
}
