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
    public partial class Keresform : Form
    {
        public Keresform()
        {
            InitializeComponent();
        }

        private void Keresform_Load(object sender, EventArgs e)
        
            => Szures();
            
        

        private void Szures()
        {
            DGVkeres.Rows.Clear();
            using (var c = new SqlConnection(Program.ConnectionString))
            {
                c.Open();

                var r = new SqlCommand("SELECT vizsgak.idopont, nyelvek.nyelv, vizsgak.szint " +
                    "FROM vizsgak, nyelvek " +
                    "WHERE nyelvek.id=vizsgak.nyelvid " +
                    $"AND nyelvek.nyelv LIKE '{TBkeres.Text}%'" +
                    ";", c).ExecuteReader();

                while (r.Read())
                {
                    DGVkeres.Rows.Add(r[0], r[1], r[2]);
                }


            }
        }

        private void TBkeres_TextChanged(object sender, EventArgs e)
        
            => Szures();
        
    }
}
