using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kasa
{
    public partial class Daily_Sales : Form
    {
        public Daily_Sales()
        {
            InitializeComponent();
        }

        private void Daily_Sales_Shown(object sender, EventArgs e)
        {
            Ana_Ekran ana_Ekran = new Ana_Ekran();

            this.BackColor = ana_Ekran.renk;

            baglan baglan = new baglan();
            dataGridView1.DataSource = baglan.fill_table("Select * from gunluk_satıs order by Tarih,Saat Desc ", "gunluk_satıs");
        }

        private void Daily_Sales_Load(object sender, EventArgs e)
        {

        }

        private void find_barcode_TextChanged(object sender, EventArgs e)
        {
            baglan baglan = new baglan();
            dataGridView1.DataSource = baglan.fill_table("Select * from gunluk_satıs where Barkod_No like '%" + find_barcode.Text + "%' order by Tarih,Saat Desc", "mfw_gold_stoklar");

        }

        private void find_product_TextChanged(object sender, EventArgs e)
        {

            baglan baglan = new baglan();
            dataGridView1.DataSource = baglan.fill_table("Select * from gunluk_satıs where Ürün_Adı like '%" + find_product.Text + "%' order by Tarih,Saat Desc", "mfw_gold_stoklar");

        }

        private void sum_Click(object sender, EventArgs e)
        {

            string sorgu = "SELECT sum(Adedi), sum(Adedi * Alıs_Fiyatı), sum(Adedi * Satıs_Fiyatı) FROM gunluk_satıs where Barkod_No Like '" + find_barcode.Text + "%' and Ürün_Adı Like '" + find_product.Text + "%' ";

            baglan nesne = new baglan();

            MySqlDataReader icerik = nesne.contents(sorgu);

            textBox1.Text = icerik[0].ToString();
            textBox2.Text = icerik[1].ToString();
            textBox3.Text = icerik[2].ToString();
            textBox4.Text = (Convert.ToInt32(icerik[2]) - Convert.ToInt32(icerik[1])).ToString();
            

            /*

            float sum_adet = 0;
            float sum_alıs = 0;
            float sum_satıs = 0;

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                float adet = Convert.ToSingle(dataGridView1.Rows[i].Cells[4].Value.ToString());
                float alıs = Convert.ToSingle(dataGridView1.Rows[i].Cells[6].Value.ToString());
                float satıs = Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value.ToString());

                sum_adet += adet;
                sum_alıs += adet * alıs;
                sum_satıs += adet * satıs;

            }

            textBox1.Text = sum_adet.ToString();
            textBox2.Text = sum_alıs.ToString();
            textBox3.Text = sum_satıs.ToString();
            textBox4.Text = (sum_satıs - sum_alıs).ToString();*/


        }

        private void end_of_day_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("İşlem yapılsın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                baglan baglan = new baglan();

                MySqlConnection connect = baglan.path;

                baglan.query_run("INSERT INTO butun_satıslar " +
                    "SELECT * FROM gunluk_satıs ");

                baglan.delete("delete from gunluk_satıs");

                dataGridView1.DataSource = baglan.fill_table("Select * from gunluk_satıs order by Tarih,Saat Desc", "gunluk_satıs");
            }
            else if (secenek == DialogResult.No)
            {
                //Hayır derse yapılacak işlemler
            }


        }

        private void clean_Click(object sender, EventArgs e)
        {
            find_barcode.Clear();
            find_product.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            baglan baglan = new baglan();
            dataGridView1.DataSource = baglan.fill_table("Select * from gunluk_satıs order by Tarih,Saat Desc", "gunluk_satıs");

        }

        private void iptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("İşlem yapılsın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                baglan nesne = new baglan();
                nesne.query_run("Update mfw_gold_stoklar set Stok_Miktarı = Stok_Miktarı+" + dataGridView1.SelectedRows[0].Cells[4].Value + " where Barkod_No = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "' ");
                nesne.query_run("DELETE FROM gunluk_satıs where Barkod_No = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "' and Adedi = " + dataGridView1.SelectedRows[0].Cells[4].Value + " and Saat = '" + dataGridView1.SelectedRows[0].Cells[1].Value+ "' limit 1");


                dataGridView1.DataSource = nesne.fill_table("Select * from gunluk_satıs order by Tarih,Saat Desc", "gunluk_satıs");


            }
            else if (secenek == DialogResult.No)
            {
                //Hayır derse yapılacak işlemler
            }

           
        }

        private void exceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excel tablo = new excel();
            tablo.Excel_Disa_Aktar(dataGridView1);
        }
    }
}


/**
 * 
 *             for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                connect.Open();

                MySqlCommand komut = new MySqlCommand("INSERT INTO butun_satıslar Values(@Tarih, @Saat, @Barkod_No, @Ürün_Adı, @Adedi, @Birimi,@Alıs_Fiyatı ,@Satıs_Fiyatı, @Tutarı)", connect);

                komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(dataGridView1.Rows[i].Cells[0].Value).ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@Saat", dataGridView1.Rows[i].Cells[1].Value);
                komut.Parameters.AddWithValue("@Barkod_No", dataGridView1.Rows[i].Cells[2].Value.ToString());
                komut.Parameters.AddWithValue("@Ürün_Adı", dataGridView1.Rows[i].Cells[3].Value.ToString());
                komut.Parameters.AddWithValue("@Adedi", dataGridView1.Rows[i].Cells[4].Value.ToString());
                komut.Parameters.AddWithValue("@Birimi", dataGridView1.Rows[i].Cells[5].Value.ToString());
                komut.Parameters.AddWithValue("@Alıs_Fiyatı", dataGridView1.Rows[i].Cells[6].Value.ToString());
                komut.Parameters.AddWithValue("@Satıs_Fiyatı", dataGridView1.Rows[i].Cells[7].Value.ToString());
                komut.Parameters.AddWithValue("@Tutarı", dataGridView1.Rows[i].Cells[8].Value.ToString());

                object kayıt = komut.ExecuteNonQuery();

                connect.Close();

                

            }

 
 
 */