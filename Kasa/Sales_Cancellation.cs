using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa
{
    public partial class Sales_Cancellation : Form
    {
        public Sales_Cancellation()
        {
            InitializeComponent();
        }

        private void Sales_Cancellation_Shown(object sender, EventArgs e)
        {
            Ana_Ekran renk = new Ana_Ekran();

            this.BackColor = renk.renk;

            yenile();
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            baglan connect = new baglan();

            dataGridView1.DataSource = connect.fill_table("SELECT Tarih, Saat, Barkod_No, Ürün_Adı, Adedi, Satıs_Fiyatı FROM butun_satıslar where Barkod_No like '"+ barcode.Text +"%'", "butun_satıslar");
        }

        private void find_Click(object sender, EventArgs e)
        {
            baglan connect = new baglan();

            dataGridView1.DataSource = connect.fill_table("SELECT Tarih, Saat, Barkod_No, Ürün_Adı, Adedi, Satıs_Fiyatı FROM butun_satıslar where Barkod_No= '" + barcode.Text + "'", "butun_satıslar");

        }

        private void yenile()
        {
            baglan connect = new baglan();

            dataGridView1.DataSource = connect.fill_table("SELECT Tarih, Saat, Barkod_No, Ürün_Adı, Adedi, Satıs_Fiyatı FROM butun_satıslar order by Tarih desc, Saat desc ", "butun_satıslar");

        }


        private void barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                baglan connect = new baglan();

                dataGridView1.DataSource = connect.fill_table("SELECT Tarih, Saat, Barkod_No, Ürün_Adı, Adedi, Satıs_Fiyatı FROM butun_satıslar where Barkod_No= '" + barcode.Text + "'", "butun_satıslar");

            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                baglan nesne = new baglan();
                nesne.query_run("Update mfw_gold_stoklar set Stok_Miktarı = Stok_Miktarı+" + dataGridView1.SelectedRows[0].Cells[4].Value + " where Barkod_No = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "' ");
                nesne.query_run("DELETE FROM gunluk_satıs where Barkod_No = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "' and Adedi = " + dataGridView1.SelectedRows[0].Cells[4].Value + " and Saat = " + dataGridView1.SelectedRows[0].Cells[1].Value  );


                yenile();

            }
            else
            {
                MessageBox.Show("Tablo İçerisinden Silmek İstediğiniz Satırı Seçin");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            yenile();
        }
    }
}
