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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            using (var c = new SqlConnection(Program.ConnectionString))
            {
                c.Open();

                var reader = new SqlCommand(
                    "SELECT nyelvek.id, jelentkezesek.nev, nyelvek.nyelv, vizsgak.szint " +
                    "FROM nyelvek, jelentkezesek, vizsgak " +
                    "WHERE nyelvek.id=vizsgak.nyelvid " +
                    "AND vizsgak.sorsz=jelentkezesek.vizsga " +
                    ";", c).ExecuteReader();
                while (reader.Read())
                {
                    DGV.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                }

                reader.Close();
                c.Close();
            }



        }

        private void vizsgákToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kereso = new Keresform();
            kereso.Show();
        }

        private void újVizsgázóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vizsga = new Vizsgaform();
            vizsga.Show();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Vizsgaform vizsga = new Vizsgaform();

            vizsga.tbID.Text = this.DGV.CurrentRow.Cells[0].Value.ToString();
            vizsga.tbNEV.Text= this.DGV.CurrentRow.Cells[1].Value.ToString();
            vizsga.tbTEL.Text = this.DGV.CurrentRow.Cells[2].Value.ToString();
            vizsga.tbSZUL.Text = this.DGV.CurrentRow.Cells[3].Value.ToString();

            vizsga.ShowDialog();
        }
    }
}
