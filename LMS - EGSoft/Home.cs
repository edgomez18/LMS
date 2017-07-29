using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS___EGSoft
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void homeclosebtn_Click(object sender, EventArgs e)
        {
            startseccion frm = new startseccion();
            frm.Show();
            this.Close();
        }

        private void agregarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbookform frm = new addbookform();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
