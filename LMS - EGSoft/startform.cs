using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LMS___EGSoft
{
    public partial class startseccion : Form
    {
        public startseccion()
        {
            InitializeComponent();
        }

        private void startseccion_Load(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Programacion\\LMS\\LMSDataBase.db;Version=3;");
            try
            {
                cnx.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from userpass", cnx);
            DataTable tabla = new DataTable("Roster");
            adac.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void nouserll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Si no tiene un usuario no puede aceder a el sistema, en cambio, puede comunicarse con el administrador del sistema para consederele uno de ser necesario.", "No tengo Usuario");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            string resul = oper.Conectar();
            MessageBox.Show(resul);
        }

        private void startseccionbtn_Click(object sender, EventArgs e)
        {
            /*SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Programacion\\LMS\\LMSDataBase.db;Version=3;");
            cnx.Open();
            string query = "Select user, pass from userpass where user='" + usercb.Text + "' and pass = '" + passwordtxt + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, cnx);
            cmd.ExecuteNonQuery();
            SQLiteDataReader dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Bien");
                cnx.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalida, intente de nuevo. Si cree que es un problema, contacte al Administrador", "Error");
                usercb.Text = "";
                passwordtxt.Clear();

            
            }*/
            Home H = new Home();
            //H.MdiParent = this;
            this.Hide();
            H.Show();
        }
    }
}
