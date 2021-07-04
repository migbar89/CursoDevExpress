using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class frmrestore : Form
    {
        public frmrestore()
        {
            InitializeComponent();
        }
        private void respaldo(string ruta)
        {
            
            string constring = "Server=localhost;Database=facturacion;user id=root;Password=root;persist security info=true;CharSet=utf8;Port=3307";
            string file = ruta;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Realizando respaldo de Base de datos ";
            save.Filter = "Respaldo SQL|*.sql";
            save.FileName = "Respaldo-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

            if (save.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            respaldo(save.FileName);
            MessageBox.Show("Respaldo realizado correctamente");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user=root;pwd=root;database=;";

            // Important Additional Connection Options
            constring += "charset=utf8;convertzerodatetime=true;";
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Restauracion de base de datos";
            // open.Filter = "Respaldo SQL|*.sql";
            if (open.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            //  MessageBox.Show(open.FileName);
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(open.FileName);
                        conn.Close();
                        MessageBox.Show("Restauracion  realizada correctamente");
                    }
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


      
    }
}
