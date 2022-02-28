using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vizsgaform0228
{
    public partial class Vizsgaform : Form
    {
        public Vizsgaform()
        {
            InitializeComponent();
        }

        private void Vizsgaform_Load(object sender, EventArgs e)
        {

        }
            
            
        

        private void Adatbe()
        {
            using (var c = new SqlConnection(Program.ConnectionString))
            {
                c.Open();

                var reader = new SqlCommand(
                    "SELECT vizsgak.sorsz, jelentkezesek.nev, jelentkezesek.mobil, jelentkezesek.szulev " +
                    "FROM nyelvek, jelentkezesek " +
                    "WHERE nyelvek.id=vizsgak.nyelvid " +
                    "" +
                    ";", c).ExecuteReader();

                reader.Read();



            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(Program.ConnectionString))
            {
                c.Open();

                var del = new SqlDataAdapter()
                {
                    DeleteCommand = new SqlCommand("DELETE FROM nyelvek" +
                    $"WHERE nyelvek.id = {tbID.Text}" +
                    ";", c)
                };
                del.DeleteCommand.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Adat törölve!");
            }
            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(Program.ConnectionString))
            {
                c.Open();

                var a = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand("INSERT INTO nyelvek,jelentkezesek (nyelvek.id, jelentkezesek.nev, jelentkezesek.mobil, jelentkezesek.szulev) " +
                    $"VALUES ('{tbID.Text}', '{tbNEV.Text}', '{tbTEL.Text}', '{tbSZUL.Text}')",c)
                };
                a.InsertCommand.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Új adat hozzáadva!");
                
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(Program.ConnectionString))
            {
                c.Open();

                var m = new SqlDataAdapter()
                {
                    UpdateCommand = new SqlCommand("UPDATE vizsga " +
                    $"SET nyelvek.id = '{tbID.Text}', nyelvek.nev ='{tbNEV.Text}', jelentkezesek.mobil='{tbTEL.Text}', jelentkezesek.szul='{tbSZUL.Text}'", c)
                };
                m.UpdateCommand.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Adat módosítva!");
                
            }

            /*
              UPDATE table_name
              SET column1 = value1, column2 = value2, ...
              WHERE condition;
             * 
             */
        }
    }
}
