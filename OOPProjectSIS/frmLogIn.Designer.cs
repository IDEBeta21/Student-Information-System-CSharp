namespace OOPProjectSIS
{
    partial class frmLogIn
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
            this.components = new System.ComponentModel.Container();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblCreateAcc = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreateUserID = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreateEmployeeId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCreateUserPassAgain = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtCreateUserName = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtCreatePhoneNum = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtCreateAddress = new System.Windows.Forms.TextBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtCreateUserPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin.SuspendLayout();
            this.pnlCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.lblClose);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblCreateAcc);
            this.pnlLogin.Controls.Add(this.Label3);
            this.pnlLogin.Controls.Add(this.Label2);
            this.pnlLogin.Controls.Add(this.Label1);
            this.pnlLogin.Controls.Add(this.txtUserPass);
            this.pnlLogin.Controls.Add(this.txtUserName);
            this.pnlLogin.Location = new System.Drawing.Point(1, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(343, 552);
            this.pnlLogin.TabIndex = 5;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(318, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 24);
            this.lblClose.TabIndex = 32;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(5, 476);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(331, 47);
            this.btnLogin.TabIndex = 31;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.AutoSize = true;
            this.lblCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAcc.Location = new System.Drawing.Point(6, 526);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(113, 15);
            this.lblCreateAcc.TabIndex = 30;
            this.lblCreateAcc.Text = "Create an Account?";
            this.lblCreateAcc.Click += new System.EventHandler(this.lblCreateAcc_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 7);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(143, 42);
            this.Label3.TabIndex = 29;
            this.Label3.Text = "LOG IN";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(5, 150);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 20);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "User Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(4, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 20);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "User Name";
            // 
            // txtUserPass
            // 
            this.txtUserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.Location = new System.Drawing.Point(4, 173);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(331, 26);
            this.txtUserPass.TabIndex = 26;
            this.txtUserPass.UseSystemPasswordChar = true;
            this.txtUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(4, 107);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(331, 26);
            this.txtUserName.TabIndex = 25;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // pnlCreate
            // 
            this.pnlCreate.BackColor = System.Drawing.Color.Transparent;
            this.pnlCreate.Controls.Add(this.label4);
            this.pnlCreate.Controls.Add(this.txtCreateUserID);
            this.pnlCreate.Controls.Add(this.Label7);
            this.pnlCreate.Controls.Add(this.label5);
            this.pnlCreate.Controls.Add(this.txtCreateEmployeeId);
            this.pnlCreate.Controls.Add(this.label8);
            this.pnlCreate.Controls.Add(this.txtCreateUserPassAgain);
            this.pnlCreate.Controls.Add(this.Label14);
            this.pnlCreate.Controls.Add(this.txtCreateUserName);
            this.pnlCreate.Controls.Add(this.Label13);
            this.pnlCreate.Controls.Add(this.txtCreatePhoneNum);
            this.pnlCreate.Controls.Add(this.Label12);
            this.pnlCreate.Controls.Add(this.txtCreateAddress);
            this.pnlCreate.Controls.Add(this.btnCreateAcc);
            this.pnlCreate.Controls.Add(this.lblLogin);
            this.pnlCreate.Controls.Add(this.Label10);
            this.pnlCreate.Controls.Add(this.txtCreateUserPass);
            this.pnlCreate.Controls.Add(this.label6);
            this.pnlCreate.Location = new System.Drawing.Point(1, 2);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(343, 552);
            this.pnlCreate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCreateUserID
            // 
            this.txtCreateUserID.BackColor = System.Drawing.Color.White;
            this.txtCreateUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreateUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUserID.Location = new System.Drawing.Point(60, 99);
            this.txtCreateUserID.Name = "txtCreateUserID";
            this.txtCreateUserID.Size = new System.Drawing.Size(272, 19);
            this.txtCreateUserID.TabIndex = 54;
            this.txtCreateUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreateUserID_KeyDown);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(9, 100);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(54, 18);
            this.Label7.TabIndex = 53;
            this.Label7.Text = "EMP - ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Employee ID";
            // 
            // txtCreateEmployeeId
            // 
            this.txtCreateEmployeeId.BackColor = System.Drawing.Color.White;
            this.txtCreateEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreateEmployeeId.Enabled = false;
            this.txtCreateEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateEmployeeId.Location = new System.Drawing.Point(5, 96);
            this.txtCreateEmployeeId.Name = "txtCreateEmployeeId";
            this.txtCreateEmployeeId.Size = new System.Drawing.Size(331, 26);
            this.txtCreateEmployeeId.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 18);
            this.label8.TabIndex = 50;
            this.label8.Text = "Enter User Password Again";
            // 
            // txtCreateUserPassAgain
            // 
            this.txtCreateUserPassAgain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreateUserPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUserPassAgain.Location = new System.Drawing.Point(5, 434);
            this.txtCreateUserPassAgain.Name = "txtCreateUserPassAgain";
            this.txtCreateUserPassAgain.PasswordChar = '*';
            this.txtCreateUserPassAgain.Size = new System.Drawing.Size(331, 26);
            this.txtCreateUserPassAgain.TabIndex = 42;
            this.txtCreateUserPassAgain.UseSystemPasswordChar = true;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(6, 313);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(84, 18);
            this.Label14.TabIndex = 49;
            this.Label14.Text = "User Name";
            // 
            // txtCreateUserName
            // 
            this.txtCreateUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreateUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUserName.Location = new System.Drawing.Point(5, 334);
            this.txtCreateUserName.Name = "txtCreateUserName";
            this.txtCreateUserName.Size = new System.Drawing.Size(331, 26);
            this.txtCreateUserName.TabIndex = 40;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(5, 183);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(108, 18);
            this.Label13.TabIndex = 48;
            this.Label13.Text = "Phone Number";
            // 
            // txtCreatePhoneNum
            // 
            this.txtCreatePhoneNum.BackColor = System.Drawing.Color.White;
            this.txtCreatePhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreatePhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePhoneNum.Location = new System.Drawing.Point(5, 206);
            this.txtCreatePhoneNum.Name = "txtCreatePhoneNum";
            this.txtCreatePhoneNum.Size = new System.Drawing.Size(331, 26);
            this.txtCreatePhoneNum.TabIndex = 39;
            this.txtCreatePhoneNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreateUserID_KeyDown);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(5, 127);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(62, 18);
            this.Label12.TabIndex = 47;
            this.Label12.Text = "Address";
            // 
            // txtCreateAddress
            // 
            this.txtCreateAddress.BackColor = System.Drawing.Color.White;
            this.txtCreateAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreateAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateAddress.Location = new System.Drawing.Point(5, 150);
            this.txtCreateAddress.Name = "txtCreateAddress";
            this.txtCreateAddress.Size = new System.Drawing.Size(331, 26);
            this.txtCreateAddress.TabIndex = 38;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.DarkRed;
            this.btnCreateAcc.FlatAppearance.BorderSize = 0;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(5, 476);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(331, 47);
            this.btnCreateAcc.TabIndex = 43;
            this.btnCreateAcc.Text = "CREATE";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(6, 526);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(48, 15);
            this.lblLogin.TabIndex = 46;
            this.lblLogin.Text = "Log In?";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(6, 363);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(111, 18);
            this.Label10.TabIndex = 45;
            this.Label10.Text = "User Password";
            // 
            // txtCreateUserPass
            // 
            this.txtCreateUserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreateUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUserPass.Location = new System.Drawing.Point(5, 384);
            this.txtCreateUserPass.Name = "txtCreateUserPass";
            this.txtCreateUserPass.PasswordChar = '*';
            this.txtCreateUserPass.Size = new System.Drawing.Size(331, 26);
            this.txtCreateUserPass.TabIndex = 41;
            this.txtCreateUserPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.75F);
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "CREATE ACCOUNT";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 555);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.Label lblCreateAcc;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtUserPass;
        internal System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel pnlCreate;
        internal System.Windows.Forms.TextBox txtCreateUserID;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtCreateEmployeeId;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtCreateUserPassAgain;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox txtCreateUserName;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtCreatePhoneNum;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtCreateAddress;
        internal System.Windows.Forms.Button btnCreateAcc;
        internal System.Windows.Forms.Label lblLogin;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtCreateUserPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label lblClose;
        internal System.Windows.Forms.Label label4;
    }
}

