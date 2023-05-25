using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Frm_Show : Form
    {
        public Frm_Show()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            //opens connection
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Database2.accdb";
            conn.Open();
            //MessageBox.Show("ok");

            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "Select * from Tabell1";
            comm.Connection = conn;

            //hämtar data från databas
            OleDbDataAdapter data_adapter = new OleDbDataAdapter();
            data_adapter.SelectCommand = comm;

            //sparar datan
            DataTable data_table = new DataTable();

            //fyller data_table med datan
            data_adapter.Fill(data_table);

            //dtg_info är namnet på datagrid på Frm_Show.cs[Design]
            //Detta gör att informationen från data_table förs in i dtg_info
            dtg_info.DataSource = data_table;



            //closes connection
            conn.Close();
        }
    }
}
