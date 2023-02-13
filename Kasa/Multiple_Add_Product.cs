using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kasa
{
    public partial class Multiple_Add_Product : Form
    {
        public Multiple_Add_Product()
        {
            InitializeComponent();
        }

        private void Multiple_Add_Product_Shown(object sender, EventArgs e)
        {
            Ana_Ekran ana_Ekran = new Ana_Ekran();

            this.BackColor = ana_Ekran.renk;
        }

        private void scanner_Click(object sender, EventArgs e)
        {
            baglan baglan= new baglan();

            float toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                MySqlDataReader icerik = baglan.contents("Select Stok_Miktarı ,Satıs_Fiyatı, İsk_Satıs_Fiyatı, Tarih from mfw_gold_stoklar " +
                    "where Barkod_No = '" + dataGridView1.Rows[i].Cells[0].Value + "' " );
                
                if ( icerik != null ){

                    dataGridView1.Rows[i].Cells[7].Value = icerik[0].ToString() ;
                    dataGridView1.Rows[i].Cells[8].Value = icerik[1].ToString();
                    dataGridView1.Rows[i].Cells[9].Value = icerik[2].ToString();
                    dataGridView1.Rows[i].Cells[10].Value = icerik[3].ToString();





                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Tan;
                }

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
