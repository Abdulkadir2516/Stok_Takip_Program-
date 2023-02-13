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
    public partial class Learn_Price : Form
    {
        public Learn_Price()
        {
            InitializeComponent();
        }

        private void Learn_Price_Shown(object sender, EventArgs e)
        {

            Ana_Ekran ana_Ekran = new Ana_Ekran();

            this.BackColor = ana_Ekran.renk;

        }

        private void barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                baglan con = new baglan();
                MySqlDataReader icerik = con.contents("Select Ürün_Adı, Satıs_Fiyatı from mfw_gold_stoklar Where Barkod_No = '" + barcode.Text + "'");

                product_name.Text = icerik[0].ToString();

                price.Text = icerik[1].ToString();

                barcode.Clear();

            }
        }
    }
}
