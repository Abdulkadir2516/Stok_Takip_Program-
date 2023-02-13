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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Kasa
{
    public partial class Sales_Status : Form
    {
        public Sales_Status()
        {
            InitializeComponent();
        }

        private void Sales_Status_Shown(object sender, EventArgs e)
        {

            Ana_Ekran ana_Ekran = new Ana_Ekran();

            this.BackColor = ana_Ekran.renk;

            baglan baglan = new baglan();
            dataGridView1.DataSource = baglan.fill_table("Select * from butun_satıslar order by Tarih desc, Saat desc", "butun_satıslar");
        }


        private void find_barcode_TextChanged(object sender, EventArgs e)
        {
            baglan baglan = new baglan();
            dataGridView1.DataSource = baglan.fill_table("Select * from butun_satıslar where Barkod_No like '%" + find_barcode.Text + "%'", "mfw_gold_stoklar");

        }

        private void find_product_TextChanged(object sender, EventArgs e)
        {

            baglan baglan = new baglan();
            dataGridView1.DataSource = baglan.fill_table("Select * from butun_satıslar where Ürün_Adı like '%" + find_product.Text + "%'", "mfw_gold_stoklar");

        }

        private void sum_Click(object sender, EventArgs e)
        {
            float sum_adet = 0;
            float sum_alıs = 0;
            float sum_satıs = 0;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
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
            textBox4.Text = (sum_satıs - sum_alıs).ToString();


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
            dataGridView1.DataSource = baglan.fill_table("Select * from butun_satıslar order by Tarih desc, Saat desc ", "butun_satıslar");

        }

        private void filter_Click(object sender, EventArgs e)
        {

            baglan connect = new baglan();

            dataGridView1.DataSource = connect.fill_table("SELECT * FROM butun_satıslar where Tarih >= '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and Tarih <= '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", "butun_satıslar");

        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("İşlem yapılsın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                baglan nesne = new baglan();
                nesne.query_run("Update mfw_gold_stoklar set Stok_Miktarı = Stok_Miktarı+" + dataGridView1.SelectedRows[0].Cells[4].Value + " where Barkod_No = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "' ");
                nesne.query_run("DELETE FROM butun_satıslar where Barkod_No = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "' and Adedi = " + dataGridView1.SelectedRows[0].Cells[4].Value + " and Saat = '" + dataGridView1.SelectedRows[0].Cells[1].Value + "' limit 1");

                dataGridView1.DataSource = nesne.fill_table("Select * from butun_satıslar order by Tarih desc, Saat desc ", "butun_satıslar");

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
/*
 

        private void iptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("İşlem yapılsın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                baglan nesne = new baglan();
                nesne.query_run("Update mfw_gold_stoklar set Stok_Miktarı = Stok_Miktarı+" + dataGridView1.SelectedRows[0].Cells[4].Value + " where Barkod_No = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "' ");
                nesne.query_run("DELETE FROM gunluk_satıs where Barkod_No = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "' and Adedi = " + dataGridView1.SelectedRows[0].Cells[4].Value + " and Saat = '" + dataGridView1.SelectedRows[0].Cells[1].Value+ "'");

                dataGridView1.DataSource = nesne.fill_table("Select * from gunluk_satıs order by Tarih,Saat Desc", "gunluk_satıs");


            }
            else if (secenek == DialogResult.No)
            {
                //Hayır derse yapılacak işlemler
            }

           
        }

        private void exceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
 
 */
