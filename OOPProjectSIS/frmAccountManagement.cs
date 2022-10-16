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
    public partial class frmAccountManagement : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/StudentInformationSystemDatabase.mdb");
        
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void lblBak_Click(object sender, EventArgs e)
        {
            Form objMenu = new frmMenu();
            objMenu.Show();
            this.Visible = false;
            con.Close();
        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string gender = "";

                con.Close();
                con.Open();

                //Display to Employee info
                OleDbCommand getEmpInfo = new OleDbCommand("SELECT * FROM Employee_Info WHERE ID = '" + txtEmpId.Text + "'",con);
                OleDbDataReader readEmpInfo = getEmpInfo.ExecuteReader();
                
                txtEmpfname.Text = "";
                txtEmplname.Text = "";
                txtEmpmname.Text = "";
                txtEmpage.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                txtEmpphoneNum.Text = "";
                txtEmpaddress.Text = "";

                lvAccountList.Items.Clear();
                
                while (readEmpInfo.Read())
                {
                    txtEmplname.Text = readEmpInfo.GetValue(1).ToString();
                    txtEmpfname.Text = readEmpInfo.GetValue(2).ToString();
                    txtEmpmname.Text = readEmpInfo.GetValue(3).ToString();
                    txtEmpage.Text = readEmpInfo.GetValue(4).ToString();
                    gender = readEmpInfo.GetValue(5).ToString();
                    txtEmpphoneNum.Text = readEmpInfo.GetValue(6).ToString();
                    txtEmpaddress.Text = readEmpInfo.GetValue(7).ToString();
                }

                //Display to Radio Button
                if (gender.Equals("Female"))
                {
                    rbFemale.Checked = true;
                    rbMale.Checked = false;
                }
                else if (gender.Equals("Male"))
                {
                     rbMale.Checked = true;
                     rbFemale.Checked = false;
                }
                else
                {
                     rbMale.Checked = false;
                     rbFemale.Checked = false;
                }

                //Display To ListBox
                OleDbCommand getFromDb = new OleDbCommand("SELECT UserName FROM Account WHERE EmployeeID = '" + txtEmpId.Text + "'", con);
                OleDbDataReader readAcc = getFromDb.ExecuteReader();

                String[] arr = new String[1];

                ListViewItem item = new ListViewItem();
                List<List<string>> list = new List<List<string>>();

                while (readAcc.Read())
                {
                    arr[0] = readAcc.GetValue(0).ToString();
                    item = new ListViewItem(arr);
                    lvAccountList.Items.Add(item);
                }
                
                //////////////////////////

                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";

                if (rbFemale.Checked == true){
                    gender = "Female";
                }
                else if (rbMale.Checked == true)
                {
                    gender = "Male";
                }
                else {
                    gender = "Male";
                }

                con.Close();
                con.Open();
                OleDbCommand insertEmpInfo = new OleDbCommand("INSERT INTO Employee_Info(ID,lname,Fname,mname,Age,Gender,PhoneNumber,Address) Values('"
                    + txtEmpId.Text + "','"
                    + txtEmplname.Text + "','"
                    + txtEmpfname.Text + "','"
                    + txtEmpmname.Text + "','"
                    + txtEmpage.Text + "','"
                    + gender.ToString()+ "','"
                    + txtEmpphoneNum.Text + "','"
                    + txtEmpaddress.Text + "')", con);

                insertEmpInfo.ExecuteNonQuery();

                MessageBox.Show("Employee Record Successfully Added");

                con.Close();
            }catch(Exception exc){
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            try {

                con.Close();
                con.Open();

                OleDbCommand deleteEmpInfo = new OleDbCommand("DELETE * FROM Employee_Info WHERE ID = '" + txtEmpId.Text + "'",con);
                OleDbCommand deleteEmpAcc = new OleDbCommand("DELETE * FROM Account WHERE EmployeeID = '" + txtEmpId.Text + "'",con);

                DialogResult dlgResult = MessageBox.Show("Do you want to continue?", "Question", MessageBoxButtons.YesNo);
                if(dlgResult == DialogResult.Yes){
                    //Delete datas
                    deleteEmpInfo.ExecuteNonQuery();
                    deleteEmpAcc.ExecuteNonQuery();
                    MessageBox.Show("Information Delete Successfully");

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

                    lvAccountList.Items.Clear();
                }

                con.Close();

            }catch(Exception exc){
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            try {
                string gender = "";

                if (rbFemale.Checked == true)
                {
                    gender = "Female";
                }
                else if (rbMale.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Male";
                }

                con.Close();
                con.Open();

                OleDbCommand updateEmployeeInfo = new OleDbCommand("UPDATE Employee_Info SET lname = '" + txtEmplname.Text + 
                    "',Fname = '" + txtEmpfname.Text + 
                    "',mname = '" + txtEmpmname.Text + 
                    "',Age = '" + txtEmpage.Text + 
                    "',Gender = '" + gender + 
                    "',PhoneNumber = '" + txtEmpphoneNum.Text + 
                    "',Address = '" + txtEmpaddress.Text + "' WHERE ID = '" + txtEmpId.Text + "'",con);

                updateEmployeeInfo.ExecuteNonQuery();

                MessageBox.Show("Information Updated Successfully");


                ////////////////////////




                //Display to Employee info
                OleDbCommand getEmpInfo = new OleDbCommand("SELECT * FROM Employee_Info WHERE ID = '" + txtEmpId.Text + "'", con);
                OleDbDataReader readEmpInfo = getEmpInfo.ExecuteReader();

                txtEmpfname.Text = "";
                txtEmplname.Text = "";
                txtEmpmname.Text = "";
                txtEmpage.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                txtEmpphoneNum.Text = "";
                txtEmpaddress.Text = "";

                lvAccountList.Clear();

                while (readEmpInfo.Read())
                {
                    txtEmplname.Text = readEmpInfo.GetValue(1).ToString();
                    txtEmpfname.Text = readEmpInfo.GetValue(2).ToString();
                    txtEmpmname.Text = readEmpInfo.GetValue(3).ToString();
                    txtEmpage.Text = readEmpInfo.GetValue(4).ToString();
                    gender = readEmpInfo.GetValue(5).ToString();
                    txtEmpphoneNum.Text = readEmpInfo.GetValue(6).ToString();
                    txtEmpaddress.Text = readEmpInfo.GetValue(7).ToString();
                }

                //Display to Radio Button
                if (gender.Equals("Female"))
                {
                    rbFemale.Checked = true;
                    rbMale.Checked = false;
                }
                else if (gender.Equals("Male"))
                {
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                }
                else
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                }

                //Display To ListBox
                OleDbCommand getFromDb = new OleDbCommand("SELECT UserName FROM Account WHERE EmployeeID = '" + txtEmpId.Text + "'", con);
                OleDbDataReader readAcc = getFromDb.ExecuteReader();

                String[] arr = new String[1];

                ListViewItem item = new ListViewItem();
                List<List<string>> list = new List<List<string>>();

                while (readAcc.Read())
                {
                    arr[0] = readAcc.GetValue(0).ToString();
                    item = new ListViewItem(arr);
                    lvAccountList.Items.Add(item);
                }
                    



                con.Close();
            }catch(Exception exc){
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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

            lvAccountList.Items.Clear();
        }

        private void btnDeleteLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                string slctStr = "";
                slctStr = lvAccountList.SelectedItems[0].Text;

                OleDbCommand deleteAcc = new OleDbCommand("DELETE * FROM Account WHERE EmployeeID = '" + txtEmpId.Text + "' AND UserName = '" + slctStr + "'", con);

                deleteAcc.ExecuteNonQuery();
                MessageBox.Show("Account Deleted Successfully");

                ////////////////////////////////////////////////
                lvAccountList.Items.Clear();

                OleDbCommand getFromDb = new OleDbCommand("SELECT UserName FROM Account WHERE EmployeeID = '" + txtEmpId.Text + "'", con);
                OleDbDataReader readAcc = getFromDb.ExecuteReader();

                String[] arr = new String[1];

                ListViewItem item = new ListViewItem();
                List<List<string>> list = new List<List<string>>();

                while (readAcc.Read())
                {
                    arr[0] = readAcc.GetValue(0).ToString();
                    item = new ListViewItem(arr);
                    lvAccountList.Items.Add(item);
                }

                con.Close();
            }catch(Exception exc){
                
            }
        }
    }
}
