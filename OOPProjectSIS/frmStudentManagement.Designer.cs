namespace OOPProjectSIS
{
    partial class frmStudentManagement
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Subject ID", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Subject ID", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlStudentInformationViewer = new System.Windows.Forms.Panel();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtGrelationship = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGid = new System.Windows.Forms.TextBox();
            this.txtSnum = new System.Windows.Forms.TextBox();
            this.txtGAddress = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtGphoneNum = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGmname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtGfname = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtGlname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSmname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSfname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateStd = new System.Windows.Forms.Button();
            this.btnAddStd = new System.Windows.Forms.Button();
            this.txtSphoneNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDeleteSub = new System.Windows.Forms.Button();
            this.btnAddSub = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lvSubjectList = new System.Windows.Forms.ListView();
            this.clmnSubNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnSubName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.txtSsection = new System.Windows.Forms.TextBox();
            this.txtSyear = new System.Windows.Forms.TextBox();
            this.txtSage = new System.Windows.Forms.TextBox();
            this.txtSlname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tmrInputingID = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlStudentInformationViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 50);
            this.panel1.TabIndex = 8;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBack.Location = new System.Drawing.Point(1297, 5);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(57, 16);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "<<BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(6, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(624, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "MANAGING STUDENT INFORMATION";
            // 
            // pnlStudentInformationViewer
            // 
            this.pnlStudentInformationViewer.Controls.Add(this.cmbCourse);
            this.pnlStudentInformationViewer.Controls.Add(this.label23);
            this.pnlStudentInformationViewer.Controls.Add(this.listView1);
            this.pnlStudentInformationViewer.Controls.Add(this.btnClear);
            this.pnlStudentInformationViewer.Controls.Add(this.label22);
            this.pnlStudentInformationViewer.Controls.Add(this.txtGrelationship);
            this.pnlStudentInformationViewer.Controls.Add(this.label12);
            this.pnlStudentInformationViewer.Controls.Add(this.txtGid);
            this.pnlStudentInformationViewer.Controls.Add(this.txtSnum);
            this.pnlStudentInformationViewer.Controls.Add(this.txtGAddress);
            this.pnlStudentInformationViewer.Controls.Add(this.label21);
            this.pnlStudentInformationViewer.Controls.Add(this.txtGphoneNum);
            this.pnlStudentInformationViewer.Controls.Add(this.label20);
            this.pnlStudentInformationViewer.Controls.Add(this.label17);
            this.pnlStudentInformationViewer.Controls.Add(this.txtGmname);
            this.pnlStudentInformationViewer.Controls.Add(this.label18);
            this.pnlStudentInformationViewer.Controls.Add(this.txtGfname);
            this.pnlStudentInformationViewer.Controls.Add(this.label19);
            this.pnlStudentInformationViewer.Controls.Add(this.txtGlname);
            this.pnlStudentInformationViewer.Controls.Add(this.label16);
            this.pnlStudentInformationViewer.Controls.Add(this.rbFemale);
            this.pnlStudentInformationViewer.Controls.Add(this.rbMale);
            this.pnlStudentInformationViewer.Controls.Add(this.label15);
            this.pnlStudentInformationViewer.Controls.Add(this.label14);
            this.pnlStudentInformationViewer.Controls.Add(this.txtSmname);
            this.pnlStudentInformationViewer.Controls.Add(this.label11);
            this.pnlStudentInformationViewer.Controls.Add(this.txtSfname);
            this.pnlStudentInformationViewer.Controls.Add(this.label9);
            this.pnlStudentInformationViewer.Controls.Add(this.btnUpdateStd);
            this.pnlStudentInformationViewer.Controls.Add(this.btnAddStd);
            this.pnlStudentInformationViewer.Controls.Add(this.txtSphoneNum);
            this.pnlStudentInformationViewer.Controls.Add(this.label13);
            this.pnlStudentInformationViewer.Controls.Add(this.btnDeleteSub);
            this.pnlStudentInformationViewer.Controls.Add(this.btnAddSub);
            this.pnlStudentInformationViewer.Controls.Add(this.label10);
            this.pnlStudentInformationViewer.Controls.Add(this.lvSubjectList);
            this.pnlStudentInformationViewer.Controls.Add(this.label7);
            this.pnlStudentInformationViewer.Controls.Add(this.txtSsection);
            this.pnlStudentInformationViewer.Controls.Add(this.txtSyear);
            this.pnlStudentInformationViewer.Controls.Add(this.txtSage);
            this.pnlStudentInformationViewer.Controls.Add(this.txtSlname);
            this.pnlStudentInformationViewer.Controls.Add(this.label8);
            this.pnlStudentInformationViewer.Controls.Add(this.label5);
            this.pnlStudentInformationViewer.Controls.Add(this.label1);
            this.pnlStudentInformationViewer.Controls.Add(this.label4);
            this.pnlStudentInformationViewer.Controls.Add(this.label2);
            this.pnlStudentInformationViewer.Controls.Add(this.label3);
            this.pnlStudentInformationViewer.Controls.Add(this.shapeContainer1);
            this.pnlStudentInformationViewer.Location = new System.Drawing.Point(0, 50);
            this.pnlStudentInformationViewer.Name = "pnlStudentInformationViewer";
            this.pnlStudentInformationViewer.Size = new System.Drawing.Size(1384, 715);
            this.pnlStudentInformationViewer.TabIndex = 9;
            // 
            // cmbCourse
            // 
            this.cmbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(87, 130);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(657, 28);
            this.cmbCourse.TabIndex = 57;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.Location = new System.Drawing.Point(602, 249);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 20);
            this.label23.TabIndex = 55;
            this.label23.Text = "SUBJECT LIST";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup1.Header = "Subject ID";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Location = new System.Drawing.Point(605, 273);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 381);
            this.listView1.TabIndex = 54;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sub #";
            this.columnHeader1.Width = 181;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject Description";
            this.columnHeader2.Width = 400;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(1213, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 52);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.Location = new System.Drawing.Point(803, 200);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 20);
            this.label22.TabIndex = 52;
            this.label22.Text = "Relationship:";
            // 
            // txtGrelationship
            // 
            this.txtGrelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGrelationship.Location = new System.Drawing.Point(908, 197);
            this.txtGrelationship.Name = "txtGrelationship";
            this.txtGrelationship.Size = new System.Drawing.Size(264, 26);
            this.txtGrelationship.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(803, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 50;
            this.label12.Text = "Guardian ID:";
            // 
            // txtGid
            // 
            this.txtGid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGid.Location = new System.Drawing.Point(908, 38);
            this.txtGid.Name = "txtGid";
            this.txtGid.Size = new System.Drawing.Size(264, 26);
            this.txtGid.TabIndex = 49;
            // 
            // txtSnum
            // 
            this.txtSnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSnum.Location = new System.Drawing.Point(139, 38);
            this.txtSnum.Name = "txtSnum";
            this.txtSnum.Size = new System.Drawing.Size(197, 26);
            this.txtSnum.TabIndex = 48;
            this.txtSnum.TextChanged += new System.EventHandler(this.txtSnum_TextChanged);
            // 
            // txtGAddress
            // 
            this.txtGAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGAddress.Location = new System.Drawing.Point(1191, 68);
            this.txtGAddress.Multiline = true;
            this.txtGAddress.Name = "txtGAddress";
            this.txtGAddress.Size = new System.Drawing.Size(153, 155);
            this.txtGAddress.TabIndex = 47;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(1187, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 20);
            this.label21.TabIndex = 46;
            this.label21.Text = "Address:";
            // 
            // txtGphoneNum
            // 
            this.txtGphoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGphoneNum.Location = new System.Drawing.Point(924, 165);
            this.txtGphoneNum.Name = "txtGphoneNum";
            this.txtGphoneNum.Size = new System.Drawing.Size(248, 26);
            this.txtGphoneNum.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(802, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 20);
            this.label20.TabIndex = 44;
            this.label20.Text = "Phone Number:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(803, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 18);
            this.label17.TabIndex = 43;
            this.label17.Text = "Middle Name:";
            // 
            // txtGmname
            // 
            this.txtGmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGmname.Location = new System.Drawing.Point(908, 133);
            this.txtGmname.Name = "txtGmname";
            this.txtGmname.Size = new System.Drawing.Size(264, 26);
            this.txtGmname.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(803, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 18);
            this.label18.TabIndex = 41;
            this.label18.Text = "First Name:";
            // 
            // txtGfname
            // 
            this.txtGfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGfname.Location = new System.Drawing.Point(908, 101);
            this.txtGfname.Name = "txtGfname";
            this.txtGfname.Size = new System.Drawing.Size(264, 26);
            this.txtGfname.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(803, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 18);
            this.label19.TabIndex = 39;
            this.label19.Text = "Last Name:";
            // 
            // txtGlname
            // 
            this.txtGlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGlname.Location = new System.Drawing.Point(908, 69);
            this.txtGlname.Name = "txtGlname";
            this.txtGlname.Size = new System.Drawing.Size(264, 26);
            this.txtGlname.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(904, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(264, 24);
            this.label16.TabIndex = 36;
            this.label16.Text = "GUARDIAN INFORMATION\r\n";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(669, 197);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 22);
            this.rbFemale.TabIndex = 35;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(605, 197);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 22);
            this.rbMale.TabIndex = 34;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(255, 24);
            this.label15.TabIndex = 33;
            this.label15.Text = "STUDENT INFORMATION\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(589, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 18);
            this.label14.TabIndex = 32;
            this.label14.Text = "Middle Name:";
            // 
            // txtSmname
            // 
            this.txtSmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSmname.Location = new System.Drawing.Point(547, 69);
            this.txtSmname.Name = "txtSmname";
            this.txtSmname.Size = new System.Drawing.Size(197, 26);
            this.txtSmname.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(399, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "First Name:";
            // 
            // txtSfname
            // 
            this.txtSfname.AcceptsReturn = true;
            this.txtSfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSfname.Location = new System.Drawing.Point(342, 69);
            this.txtSfname.Name = "txtSfname";
            this.txtSfname.Size = new System.Drawing.Size(197, 26);
            this.txtSfname.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Last Name:";
            // 
            // btnUpdateStd
            // 
            this.btnUpdateStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateStd.Location = new System.Drawing.Point(1213, 447);
            this.btnUpdateStd.Name = "btnUpdateStd";
            this.btnUpdateStd.Size = new System.Drawing.Size(131, 145);
            this.btnUpdateStd.TabIndex = 27;
            this.btnUpdateStd.Text = "UPDATE \\ DELETE STUDENT INFORMATION";
            this.btnUpdateStd.UseVisualStyleBackColor = true;
            this.btnUpdateStd.Click += new System.EventHandler(this.btnUpdateStd_Click);
            // 
            // btnAddStd
            // 
            this.btnAddStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddStd.Location = new System.Drawing.Point(87, 660);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(412, 52);
            this.btnAddStd.TabIndex = 25;
            this.btnAddStd.Text = "ADD STUDENT INFORMATION";
            this.btnAddStd.UseVisualStyleBackColor = true;
            this.btnAddStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // txtSphoneNum
            // 
            this.txtSphoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSphoneNum.Location = new System.Drawing.Point(520, 164);
            this.txtSphoneNum.Name = "txtSphoneNum";
            this.txtSphoneNum.Size = new System.Drawing.Size(224, 26);
            this.txtSphoneNum.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(398, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Phone Number:";
            // 
            // btnDeleteSub
            // 
            this.btnDeleteSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteSub.Location = new System.Drawing.Point(1213, 331);
            this.btnDeleteSub.Name = "btnDeleteSub";
            this.btnDeleteSub.Size = new System.Drawing.Size(131, 52);
            this.btnDeleteSub.TabIndex = 18;
            this.btnDeleteSub.Text = "DELETE SUBJECT";
            this.btnDeleteSub.UseVisualStyleBackColor = true;
            this.btnDeleteSub.Click += new System.EventHandler(this.btnDeleteSub_Click);
            // 
            // btnAddSub
            // 
            this.btnAddSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddSub.Location = new System.Drawing.Point(1213, 273);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(131, 52);
            this.btnAddSub.TabIndex = 17;
            this.btnAddSub.Text = "ADD SUBJECT";
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(3, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "SUBJECTS";
            // 
            // lvSubjectList
            // 
            this.lvSubjectList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnSubNum,
            this.clmnSubName});
            this.lvSubjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvSubjectList.FullRowSelect = true;
            this.lvSubjectList.GridLines = true;
            listViewGroup2.Header = "Subject ID";
            listViewGroup2.Name = "listViewGroup1";
            this.lvSubjectList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.lvSubjectList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvSubjectList.Location = new System.Drawing.Point(5, 273);
            this.lvSubjectList.MultiSelect = false;
            this.lvSubjectList.Name = "lvSubjectList";
            this.lvSubjectList.Size = new System.Drawing.Size(585, 381);
            this.lvSubjectList.TabIndex = 15;
            this.lvSubjectList.UseCompatibleStateImageBehavior = false;
            this.lvSubjectList.View = System.Windows.Forms.View.Details;
            // 
            // clmnSubNum
            // 
            this.clmnSubNum.Text = "Sub #";
            this.clmnSubNum.Width = 181;
            // 
            // clmnSubName
            // 
            this.clmnSubName.Text = "Subject Description";
            this.clmnSubName.Width = 400;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(523, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender:";
            // 
            // txtSsection
            // 
            this.txtSsection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSsection.Location = new System.Drawing.Point(87, 194);
            this.txtSsection.Name = "txtSsection";
            this.txtSsection.Size = new System.Drawing.Size(305, 26);
            this.txtSsection.TabIndex = 12;
            // 
            // txtSyear
            // 
            this.txtSyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSyear.Location = new System.Drawing.Point(87, 164);
            this.txtSyear.Name = "txtSyear";
            this.txtSyear.Size = new System.Drawing.Size(305, 26);
            this.txtSyear.TabIndex = 11;
            // 
            // txtSage
            // 
            this.txtSage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSage.Location = new System.Drawing.Point(446, 196);
            this.txtSage.Name = "txtSage";
            this.txtSage.Size = new System.Drawing.Size(71, 26);
            this.txtSage.TabIndex = 9;
            // 
            // txtSlname
            // 
            this.txtSlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSlname.Location = new System.Drawing.Point(139, 69);
            this.txtSlname.Name = "txtSlname";
            this.txtSlname.Size = new System.Drawing.Size(197, 26);
            this.txtSlname.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(17, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(17, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Section:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student #:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(398, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1384, 715);
            this.shapeContainer1.TabIndex = 56;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 6;
            this.lineShape1.X2 = 1172;
            this.lineShape1.Y1 = 235;
            this.lineShape1.Y2 = 235;
            // 
            // tmrInputingID
            // 
            this.tmrInputingID.Enabled = true;
            this.tmrInputingID.Tick += new System.EventHandler(this.tmrInputingID_Tick);
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlStudentInformationViewer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStudentManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlStudentInformationViewer.ResumeLayout(false);
            this.pnlStudentInformationViewer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlStudentInformationViewer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSsection;
        private System.Windows.Forms.TextBox txtSyear;
        private System.Windows.Forms.TextBox txtSage;
        private System.Windows.Forms.TextBox txtSlname;
        private System.Windows.Forms.Button btnDeleteSub;
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.TextBox txtSphoneNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUpdateStd;
        private System.Windows.Forms.Button btnAddStd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSmname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSfname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGAddress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtGphoneNum;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGmname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtGfname;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtGlname;
        private System.Windows.Forms.TextBox txtSnum;
        public System.Windows.Forms.ListView lvSubjectList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGid;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtGrelationship;
        public System.Windows.Forms.ColumnHeader clmnSubNum;
        public System.Windows.Forms.ColumnHeader clmnSubName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer tmrInputingID;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ComboBox cmbCourse;
    }
}