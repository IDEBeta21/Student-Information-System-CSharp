using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOPProjectSIS
{
    public partial class frmStudentInformation : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/StudentInformationSystemDatabase.mdb");
        
        public frmStudentInformation()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form objMenu = new frmMenu();
            objMenu.Show();
            this.Visible = false;
            con.Close();
        }

        private void txtSnum_TextChanged(object sender, EventArgs e)
        {
            string gender = "";

            try
            {

                ////FINDING STUDENT INFO USING STUDENT NUMBER
                con.Close();
                con.Open();
                OleDbCommand slctStudentInfo = new OleDbCommand("SELECT * FROM Student_Information WHERE Id = '" + txtSnum.Text + "'", con);
                OleDbCommand slctGuardianAndStudent = new OleDbCommand("SELECT * FROM Student_And_Guardian WHERE StudentID = '" + txtSnum.Text + "'", con);

                OleDbDataReader readSinfo = slctStudentInfo.ExecuteReader();
                OleDbDataReader readSAGinfo = slctGuardianAndStudent.ExecuteReader();

                txtSlname.Text = "";
                txtSfname.Text = "";
                txtSmname.Text = "";
                txtSphoneNum.Text = "";
                txtSage.Text = "";
                txtScourse.Text = "";
                txtSyear.Text = "";
                txtSsection.Text = "";

                rbFemale.Checked = false;
                rbMale.Checked = false;

                while (readSinfo.Read())
                {
                    //txtSnum.Text = readSinfo.GetValue(0).ToString();
                    txtSlname.Text = readSinfo.GetValue(1).ToString();
                    txtSfname.Text = readSinfo.GetValue(2).ToString();
                    txtSmname.Text = readSinfo.GetValue(3).ToString();
                    txtSphoneNum.Text = readSinfo.GetValue(4).ToString();
                    txtSage.Text = readSinfo.GetValue(5).ToString();
                    gender = readSinfo.GetValue(6).ToString();
                    txtScourse.Text = readSinfo.GetValue(7).ToString();
                    txtSyear.Text = readSinfo.GetValue(8).ToString();
                    txtSsection.Text = readSinfo.GetValue(9).ToString();
                }

                while (readSAGinfo.Read())
                {
                    txtSnum.Text = readSAGinfo.GetValue(0).ToString();
                    txtGid.Text = readSAGinfo.GetValue(1).ToString();
                    txtGrelationship.Text = readSAGinfo.GetValue(2).ToString();
                }


                OleDbCommand slctGuardianInfo = new OleDbCommand("SELECT * FROM Guardian WHERE id = '" + txtGid.Text + "'", con);
                OleDbDataReader readGinfo = slctGuardianInfo.ExecuteReader();

                while (readGinfo.Read())
                {
                    txtGid.Text = readGinfo.GetValue(0).ToString();
                    txtGlname.Text = readGinfo.GetValue(1).ToString();
                    txtGfname.Text = readGinfo.GetValue(2).ToString();
                    txtGmname.Text = readGinfo.GetValue(3).ToString();
                    txtGphoneNum.Text = readGinfo.GetValue(4).ToString();
                    txtGAddress.Text = readGinfo.GetValue(5).ToString();
                }

                con.Close();

                if (gender.Equals("Female"))
                {
                    rbFemale.Checked = true;
                    rbMale.Checked = false;
                }
                else
                {
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnDeleteStd_Click(object sender, EventArgs e)
        {
            //DELETING STUDENT INFORMATION
            try
            {
                con.Close();
                con.Open();
                OleDbCommand deleteSInfo = new OleDbCommand("DELETE * FROM Student_Information WHERE Id = '" + txtSnum.Text + "'", con);
                OleDbCommand deleteGInfo = new OleDbCommand("DELETE * FROM Guardian WHERE id = '" + txtGid.Text + "'", con);
                OleDbCommand deleteSAGInfo = new OleDbCommand("DELETE * FROM Student_And_Guardian WHERE StudentID = '" + txtSnum.Text + "'", con);

                DialogResult dlgResult = MessageBox.Show("Do you want to continue?", "Question", MessageBoxButtons.YesNo);

                if (dlgResult == DialogResult.Yes)
                {
                    //Delete items
                    deleteSInfo.ExecuteNonQuery();
                    deleteGInfo.ExecuteNonQuery();
                    deleteSAGInfo.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");

                    //Clear all text box
                    Action<Control.ControlCollection> func = null;
                    func = (controls) =>
                    {
                        foreach (Control control in controls)
                            if (control is TextBox)
                                (control as TextBox).Clear();
                            else
                                func(control.Controls);
                    };
                    func(Controls);

                }

                con.Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());

            }
        }

        private void pnlStudentInformationViewer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateStd_Click(object sender, EventArgs e)
        {

        }
    }
}
