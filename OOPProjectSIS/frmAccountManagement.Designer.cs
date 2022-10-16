namespace OOPProjectSIS
{
    partial class frmAccountManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBak = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtEmpaddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpphoneNum = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmpmname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmpfname = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmplname = new System.Windows.Forms.TextBox();
            this.lvAccountList = new System.Windows.Forms.ListView();
            this.btnDeleteLogIn = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblBak);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 54);
            this.panel1.TabIndex = 8;
            // 
            // lblBak
            // 
            this.lblBak.AutoSize = true;
            this.lblBak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBak.Location = new System.Drawing.Point(652, 3);
            this.lblBak.Name = "lblBak";
            this.lblBak.Size = new System.Drawing.Size(57, 16);
            this.lblBak.TabIndex = 4;
            this.lblBak.Text = "<<BACK";
            this.lblBak.Click += new System.EventHandler(this.lblBak_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(1307, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "<<BACK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(441, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "ACCOUNT MANAGEMENT";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.Location = new System.Drawing.Point(12, 292);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 20);
            this.label22.TabIndex = 64;
            this.label22.Text = "Address:";
            // 
            // txtEmpaddress
            // 
            this.txtEmpaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmpaddress.Location = new System.Drawing.Point(90, 289);
            this.txtEmpaddress.Name = "txtEmpaddress";
            this.txtEmpaddress.Size = new System.Drawing.Size(291, 26);
            this.txtEmpaddress.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 18);
            this.label12.TabIndex = 62;
            this.label12.Text = "Employee ID:";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmpId.Location = new System.Drawing.Point(117, 89);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(264, 26);
            this.txtEmpId.TabIndex = 61;
            this.txtEmpId.TextChanged += new System.EventHandler(this.txtEmpId_TextChanged);
            // 
            // txtEmpphoneNum
            // 
            this.txtEmpphoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmpphoneNum.Location = new System.Drawing.Point(133, 257);
            this.txtEmpphoneNum.Name = "txtEmpphoneNum";
            this.txtEmpphoneNum.Size = new System.Drawing.Size(248, 26);
            this.txtEmpphoneNum.TabIndex = 60;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(11, 260);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 20);
            this.label20.TabIndex = 59;
            this.label20.Text = "Phone Number:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 188);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 18);
            this.label17.TabIndex = 58;
            this.label17.Text = "Middle Name:";
            // 
            // txtEmpmname
            // 
            this.txtEmpmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmpmname.Location = new System.Drawing.Point(117, 184);
            this.txtEmpmname.Name = "txtEmpmname";
            this.txtEmpmname.Size = new System.Drawing.Size(264, 26);
            this.txtEmpmname.TabIndex = 57;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 18);
            this.label18.TabIndex = 56;
            this.label18.Text = "First Name:";
            // 
            // txtEmpfname
            // 
            this.txtEmpfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmpfname.Location = new System.Drawing.Point(117, 152);
            this.txtEmpfname.Name = "txtEmpfname";
            this.txtEmpfname.Size = new System.Drawing.Size(264, 26);
            this.txtEmpfname.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 18);
            this.label19.TabIndex = 54;
            this.label19.Text = "Last Name:";
            // 
            // txtEmplname
            // 
            this.txtEmplname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmplname.Location = new System.Drawing.Point(117, 120);
            this.txtEmplname.Name = "txtEmplname";
            this.txtEmplname.Size = new System.Drawing.Size(264, 26);
            this.txtEmplname.TabIndex = 53;
            // 
            // lvAccountList
            // 
            this.lvAccountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAccountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lvAccountList.FullRowSelect = true;
            this.lvAccountList.GridLines = true;
            this.lvAccountList.Location = new System.Drawing.Point(387, 89);
            this.lvAccountList.MultiSelect = false;
            this.lvAccountList.Name = "lvAccountList";
            this.lvAccountList.Size = new System.Drawing.Size(311, 355);
            this.lvAccountList.TabIndex = 65;
            this.lvAccountList.UseCompatibleStateImageBehavior = false;
            this.lvAccountList.View = System.Windows.Forms.View.Details;
            // 
            // btnDeleteLogIn
            // 
            this.btnDeleteLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteLogIn.Location = new System.Drawing.Point(553, 454);
            this.btnDeleteLogIn.Name = "btnDeleteLogIn";
            this.btnDeleteLogIn.Size = new System.Drawing.Size(145, 52);
            this.btnDeleteLogIn.TabIndex = 66;
            this.btnDeleteLogIn.Text = "DELETE LOG IN ACCOUNT";
            this.btnDeleteLogIn.UseVisualStyleBackColor = true;
            this.btnDeleteLogIn.Click += new System.EventHandler(this.btnDeleteLogIn_Click);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddAcc.Location = new System.Drawing.Point(15, 326);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(366, 56);
            this.btnAddAcc.TabIndex = 67;
            this.btnAddAcc.Text = "ADD ACCOUNT";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteAcc.Location = new System.Drawing.Point(16, 388);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(365, 56);
            this.btnDeleteAcc.TabIndex = 68;
            this.btnDeleteAcc.Text = "DELETE ACCOUNT";
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateAcc.Location = new System.Drawing.Point(16, 450);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(365, 56);
            this.btnUpdateAcc.TabIndex = 69;
            this.btnUpdateAcc.Text = "UPDATE ACCOUNT";
            this.btnUpdateAcc.UseVisualStyleBackColor = true;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(11, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(271, 24);
            this.label26.TabIndex = 83;
            this.label26.Text = "EMPLOYEE INFORMATION\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "EMPLOYEE LOG IN ACCOUNTS";
            // 
            // txtEmpage
            // 
            this.txtEmpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmpage.Location = new System.Drawing.Point(59, 216);
            this.txtEmpage.Name = "txtEmpage";
            this.txtEmpage.Size = new System.Drawing.Size(95, 26);
            this.txtEmpage.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Age:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(306, 217);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 22);
            this.rbFemale.TabIndex = 89;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(242, 217);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 22);
            this.rbMale.TabIndex = 88;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(160, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 87;
            this.label7.Text = "Gender:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(387, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 52);
            this.btnClear.TabIndex = 90;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "USER ACCOUNT";
            this.columnHeader1.Width = 306;
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 522);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmpage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnUpdateAcc);
            this.Controls.Add(this.btnDeleteAcc);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.btnDeleteLogIn);
            this.Controls.Add(this.lvAccountList);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtEmpaddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtEmpphoneNum);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtEmpmname);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtEmpfname);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtEmplname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccountManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtEmpaddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpphoneNum;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmpmname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEmpfname;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmplname;
        private System.Windows.Forms.ListView lvAccountList;
        private System.Windows.Forms.Button btnDeleteLogIn;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Label lblBak;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}