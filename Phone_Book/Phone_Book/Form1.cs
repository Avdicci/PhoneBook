using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Frm_Add form_add = new Frm_Add();
            form_add.ShowDialog();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Frm_Del form_add = new Frm_Del();
            form_add.ShowDialog();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Frm_Show form_add = new Frm_Show();
            form_add.ShowDialog();
        }
    }
}
