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
    public partial class frmSubjectList : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/StudentInformationSystemDatabase.mdb");
        
        public string subName = "";
        public string subNum = "";
        public String[] arr = new String[5];

        public frmSubjectList()
        {
            InitializeComponent();
        }

        private void frmSubjectList_Load(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand getFromDb = new OleDbCommand("SELECT * FROM Subjects",con);
            OleDbDataReader readSub = getFromDb.ExecuteReader();

            String[] arr = new String[2];

            ListViewItem item = new ListViewItem();
            List<List<string>> list = new List<List<string>>();

            while (readSub.Read()){
                arr[0] = readSub.GetValue(0).ToString();
                arr[1] = readSub.GetValue(1).ToString();
                item = new ListViewItem(arr);
                lvSublist.Items.Add(item);
            }

            con.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subNum = lvSublist.SelectedItems[0].Text;
            string subname = lvSublist.SelectedItems[0].SubItems[1].Text;

            writeToOtherForm(subNum,subname);
            this.Hide();
        }

        public void writeToOtherForm(string subnum, string subname) {
            ListViewItem item = lvSublist.SelectedItems[0];

            frmStudentManagement objStdM = new frmStudentManagement();

            subNum = lvSublist.SelectedItems[0].SubItems[0].Text;
            subName = lvSublist.SelectedItems[0].SubItems[1].Text;

            frmStudentManagement stInfo = new frmStudentManagement();
            stInfo.lvSubjectList.Items.Add(subnum);

            MessageBox.Show(subnum +"  "+subname );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }

    
}
