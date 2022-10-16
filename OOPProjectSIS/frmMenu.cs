using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProjectSIS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            Form objStdInfo = new frmStudentInformation();
            objStdInfo.Show();
            this.Visible = false;
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            Form objStdMan = new frmStudentManagement();
            objStdMan.Show();
            this.Visible = false;
        }

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            Form objAccountManagement = new frmAccountManagement();
            objAccountManagement.Show();
            this.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form objLogin = new frmLogIn();
            objLogin.Show();
            this.Visible = false;
        }
    }
}
