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
    public partial class frmStudentManagement : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/StudentInformationSystemDatabase.mdb");
        
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Form objMenu = new frmMenu();
            objMenu.Show();
            this.Visible = false;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmSubjectList objSublst = new frmSubjectList();
            //objSublst.Show();
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();

                String gender = "Male";

                //ADDING STUDENT INFORMATION

                OleDbCommand insertStudentData = new OleDbCommand("INSERT INTO Student_Information(Id,lname,fname,mname,phoneNumber,currentAge,gender,course,currentYear,currentSection) VALUES('"
                    + txtSnum.Text + "','"
                    + txtSlname.Text + "','"
                    + txtSfname.Text + "','"
                    + txtSmname.Text + "','"
                    + txtSphoneNum.Text + "','"
                    + txtSage.Text + "','"
                    + gender + "','"
                    + cmbCourse.Text + "','"
                    + txtSyear.Text + "','"
                    + txtSsection.Text + "')", con);

                OleDbCommand insertGuardianInfo = new OleDbCommand("INSERT INTO Guardian(id,lname,fname,mname,PhoneNumber,Address) VALUES('"
                    + txtGid.Text + "','"
                    + txtGlname.Text + "','"
                    + txtGfname.Text + "','"
                    + txtGmname.Text + "','"
                    + txtGphoneNum.Text + "','"
                    + txtGAddress.Text + "')", con);

                OleDbCommand insertStudentAndGuardian = new OleDbCommand("INSERT INTO Student_And_Guardian(StudentID,GuardianID,Relationship) VALUES('"
                    + txtSnum.Text + "','"
                    + txtGid.Text + "','"
                    + txtGrelationship.Text + "')", con);

                insertStudentData.ExecuteNonQuery();
                insertGuardianInfo.ExecuteNonQuery();
                insertStudentAndGuardian.ExecuteNonQuery();

                MessageBox.Show("Information Successfully Added");

                con.Close();
            }
            catch (Exception exc) {

                MessageBox.Show("Student Data Might Already Existed \n" + exc.ToString());

            }
        }

        private void txtSnum_TextChanged(object sender, EventArgs e)
        {
            string gender = "";

            try
            {

                ////FINDING STUDENT INFO USING STUDENT NUMBER
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
                cmbCourse.Text = "";
                txtSyear.Text = "";
                txtSsection.Text = "";

                rbFemale.Checked = false;
                rbMale.Checked = false;

                lvSubjectList.Items.Clear();
                
                while (readSinfo.Read())
                {
                    txtSnum.Text = readSinfo.GetValue(0).ToString();
                    txtSlname.Text = readSinfo.GetValue(1).ToString();
                    txtSfname.Text = readSinfo.GetValue(2).ToString();
                    txtSmname.Text = readSinfo.GetValue(3).ToString();
                    txtSphoneNum.Text = readSinfo.GetValue(4).ToString();
                    txtSage.Text = readSinfo.GetValue(5).ToString();
                    gender = readSinfo.GetValue(6).ToString();
                    cmbCourse.Text = readSinfo.GetValue(7).ToString();
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
                //MessageBox.Show(exc.ToString());
            }
        }

        private void btnDeleteStd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateStd_Click(object sender, EventArgs e)
        {
            string gender = "";

            con.Close();
            con.Open();

            OleDbCommand updateSinfo = new OleDbCommand("UPDATE Student_Information SET lname = '" + txtSlname.Text + 
                "', fname = '" + txtSfname.Text + 
                "', mname = '" + txtSmname.Text +
                "', phoneNumber = '" + txtSphoneNum.Text +
                "', currentAge = '" + txtSage.Text + 
                "', gender = '" + gender + 
                "', course = '" + cmbCourse.Text + 
                "', currentYear = '" + txtSyear.Text + 
                "', currentSection = '" + txtSsection.Text + "' WHERE Id = '" + txtSnum.Text + "'",con);

            OleDbCommand updateGinfo = new OleDbCommand("UPDATE Guardian SET lname = '" + txtGlname.Text + 
                "', fname = '" + txtGfname.Text + 
                "', mname = '" + txtGmname.Text + 
                "', PhoneNumber = '" + txtGphoneNum.Text + 
                "', Address = '" + txtGAddress.Text + "' WHERE id = '" + txtGid.Text + "'", con);

            OleDbCommand updateSAGinfo = new OleDbCommand("UPDATE Student_And_Guardian SET GuardianID = '" + txtGid.Text + 
                "', Relationship = '" + txtGrelationship.Text + "' WHERE  StudentID = '" + txtSnum.Text + "'",con);

            try
            {
                updateSinfo.ExecuteNonQuery();
                updateGinfo.ExecuteNonQuery();
                updateSAGinfo.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception exc) {
                MessageBox.Show(exc.ToString());
            }

            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSlname.Text = "";
            txtSfname.Text = "";
            txtSmname.Text = "";
            txtSphoneNum.Text = "";
            txtSage.Text = "";
            cmbCourse.Text = "";
            txtSyear.Text = "";
            txtSsection.Text = "";

            rbFemale.Checked = false;
            rbMale.Checked = false;

            lvSubjectList.Items.Clear();
        }

        private void tmrInputingID_Tick(object sender, EventArgs e)
        {
            
            con.Close();
            con.Open();
            //automatically generate student number base on the last student number input
            OleDbCommand getLatestID = new OleDbCommand("SELECT TOP 1 Id FROM Student_Information ORDER BY Id DESC",con);
            OleDbDataReader readID = getLatestID.ExecuteReader();

            readID.Read();
            int intID = Convert.ToInt32(readID.GetValue(0).ToString());

            txtSnum.Text = (intID + 1).ToString();

            con.Close();
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand getSub = new OleDbCommand("SELECT * FROM Subjects",con);
            OleDbDataReader readSub = getSub.ExecuteReader();

            int count = 0;
            string outputStr = "";

            while (readSub.Read()) {
                cmbCourse.Items.Add(readSub.GetValue(0).ToString() + "    " + readSub.GetValue(1).ToString());
                count++;
            }
            count = 0;
        }


    }

}
