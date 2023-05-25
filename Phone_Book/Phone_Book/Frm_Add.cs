using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Frm_Add : Form
    {
        public Frm_Add()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Database2.accdb";
            conn.Open();


            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "insert into Tabell1(Fname, Lname, Gmail, Mobile) values('" +txt_Fname.Text+"', '"+txt_Lname.Text+"', '"+txt_Mail.Text+"', '"+txt_Mobile.Text+"')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data successfully saved");
        }
    }
}
