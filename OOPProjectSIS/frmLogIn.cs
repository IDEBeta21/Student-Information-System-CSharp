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
    public partial class frmLogIn : Form
    {
        //Database Connection
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/StudentInformationSystemDatabase.mdb");

        public frmLogIn()
        {
            InitializeComponent();
            pnlCreate.Visible = false;
            pnlCreate.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginMethod();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {  
                loginMethod();
            }
        }

        public void loginMethod()
        {
            con.Open();
            try
            {
                OleDbCommand getLogInInfo = new OleDbCommand("SELECT * FROM Account WHERE UserName = @user AND UserPassword = @pass", con);
                
                getLogInInfo.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUserName.Text;
                getLogInInfo.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtUserPass.Text;
                
                OleDbDataReader readLoginInfo = getLogInInfo.ExecuteReader();

                if (readLoginInfo.Read() == true)
                {
                    Form objMenu = new frmMenu();
                    objMenu.Show();

                    this.Visible = false;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Log in not Succeed");
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n" + ex.ToString());
                con.Close();
            }
            con.Close();
        }

        private void logIn_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Helllow");
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            pnlCreate.Visible = true;
            pnlCreate.Enabled = true;

            pnlLogin.Visible = false;
            pnlLogin.Enabled = false;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.Enabled = true;

            pnlCreate.Visible = false;
            pnlCreate.Enabled = false;
            
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            createAccount();
        }

        private void txtCreateUserID_KeyDown(object sender, KeyEventArgs e)
        {
            createAccount();//adding enter key press

        }

        void createAccount() {
            try
            {
                if ((txtCreateUserID.Text != "" && txtCreatePhoneNum.Text != "" && txtCreateAddress.Text != ""))
                {
                    try
                    {
                        con.Close();
                        con.Open();
                        OleDbCommand getEmployeeID = new OleDbCommand("SELECT EmployeeID FROM Employee_Info WHERE" +
                            " EmployeeId = " + txtCreateUserID.Text.ToString() +
                            " AND Address = '" + txtCreateAddress.Text +
                            "' AND PhoneNumber = '" + txtCreatePhoneNum.Text + "'", con);

                        OleDbDataReader readId = getEmployeeID.ExecuteReader();

                        if ((readId.Read() == true))
                        {
                            //Test if the Textbox for Username and Password is not empty
                            if (txtCreateUserName.Text != "" && txtCreateUserPass.Text != "" && txtCreateUserPassAgain.Text != "")
                            {
                                if (txtCreateUserPass.Text == txtCreateUserPassAgain.Text)
                                {
                                    //Insert the ID, Username and Password of the Employee to the database
                                    OleDbCommand accInfo = new OleDbCommand("INSERT INTO Account(EmployeeID,UserName,UserPassword) VALUES('" +
                                        readId.GetValue(0).ToString() + "','" +
                                        txtCreateUserName.Text + "','" +
                                        txtCreateUserPass.Text + "')", con);

                                    accInfo.ExecuteNonQuery();
                                    MessageBox.Show("Account Created Successfully");
                                }
                                else
                                {
                                    MessageBox.Show("Password Does not Match");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Makw Sure That You Fill Up Everything");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The Information Provided, Does not Match in any Employee Information");
                        }
                        con.Close();
                    }
                    catch (Exception excInfoValidation)
                    {
                        MessageBox.Show("" + excInfoValidation.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please Complete the User Information First");
                }
            }
            catch (Exception createAccEx)
            {
                MessageBox.Show("ERROR\n" + createAccEx.ToString());
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
