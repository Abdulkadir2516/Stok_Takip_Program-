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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kasa
{
    
    public partial class Stock_Durumu : Form
    {


        public Stock_Durumu()
        {
            InitializeComponent();
        }

        private void Stock_Durumu_Shown(object sender, EventArgs e)
        {
            Ana_Ekran ana_Ekran = new Ana_Ekran();

            this.BackColor = ana_Ekran.renk;

            baglan baglan = new baglan();
            dataGridView2.DataSource = baglan.fill_table("Select * from mfw_gold_stoklar", "mfw_gold_stoklar");

            MySqlDataReader icerik = baglan.contents("Select * from gruplar");
            product_type.Items.Add(icerik.GetString(0).ToString());

            while (icerik.Read())
            {
                product_type.Items.Add(icerik.GetString(0).ToString());

            }

            baglan baglan2 = new baglan();

            MySqlDataReader icerik2 = baglan2.contents("Select * from toptancı");
            supplier.Items.Add(icerik2.GetString(0).ToString());

            while (icerik2.Read())
            {
                supplier.Items.Add(icerik2.GetString(0).ToString());

            }

            /*
            product_type.DataSource = baglan.fill_table("Select * from gruplar","gruplar");
            product_type.DisplayMember = "Grup_Adı";

            supplier.DataSource = baglan.fill_table("Select * from toptancı", "toptancı");
            supplier.DisplayMember = "Toptancı_Adı";
            */
            product_type.SelectedIndex = -1;

            supplier.SelectedIndex = -1;
        }


        private void find_barcode_TextChanged(object sender, EventArgs e)
        {
            baglan baglan = new baglan();
            dataGridView2.DataSource = baglan.fill_table("Select * from mfw_gold_stoklar where Barkod_No like '%" + find_barcode.Text + "%'", "mfw_gold_stoklar");

        }

        private void find_product_TextChanged(object sender, EventArgs e)
        {
           
            baglan baglan = new baglan();
            dataGridView2.DataSource = baglan.fill_table("Select * from mfw_gold_stoklar where Ürün_Adı like '%" + find_product.Text + "%'", "mfw_gold_stoklar");

        }

        private void clear_Click(object sender, EventArgs e)
        {
            find_product.Clear();
            find_barcode.Clear();
            supplier.SelectedIndex = -1;
            product_type.SelectedIndex = -1;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void filter_Click(object sender, EventArgs e)
        {
            if (product_type.SelectedIndex != -1 && supplier.SelectedIndex != -1)
            {
                string sorgu = "SELECT * FROM mfw_gold_stoklar where Barkod_No Like '" + find_barcode.Text + "%' and  Ürün_Adı Like '" + find_product.Text + "%' and  Ürün_Cinsi Like '" + product_type.SelectedItem.ToString() + "%' and Toptancısı Like'" + supplier.SelectedItem.ToString() + "%'";

                baglan nesne = new baglan();

                dataGridView2.DataSource = nesne.fill_table(sorgu, "mfw_gold_stoklar");
            }
            else if(supplier.SelectedIndex != -1)
            {
                string sorgu = "SELECT * FROM mfw_gold_stoklar where Barkod_No Like '" + find_barcode.Text + "%' and  Ürün_Adı Like '" + find_product.Text + "%' and Toptancısı Like'" + supplier.SelectedItem.ToString() + "%'";

                baglan nesne = new baglan();

                dataGridView2.DataSource = nesne.fill_table(sorgu, "mfw_gold_stoklar");
            }
            else if (product_type.SelectedIndex != -1)
            {
                string sorgu = "SELECT * FROM mfw_gold_stoklar where Barkod_No Like '" + find_barcode.Text + "%' and  Ürün_Adı Like '" + find_product.Text + "%' and  Ürün_Cinsi Like '" + product_type.SelectedItem.ToString() + "%'";

                baglan nesne = new baglan();

                dataGridView2.DataSource = nesne.fill_table(sorgu, "mfw_gold_stoklar");
            }
            else
            {
                string sorgu = "SELECT * FROM mfw_gold_stoklar where Barkod_No Like '" + find_barcode.Text + "%' and  Ürün_Adı Like '" + find_product.Text + "%'";

                baglan nesne = new baglan();

                dataGridView2.DataSource = nesne.fill_table(sorgu, "mfw_gold_stoklar");
            }


        }

        private void product_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(product_type.SelectedIndex !=-1)
            {
                string sorgu = "SELECT * FROM mfw_gold_stoklar where Ürün_Cinsi Like '" + product_type.SelectedItem.ToString() + "%' ";

                baglan nesne = new baglan();

                dataGridView2.DataSource = nesne.fill_table(sorgu, "mfw_gold_stoklar");
            }
           
        }


        private void sum_Click(object sender, EventArgs e)
        {

            if (product_type.SelectedIndex != -1 && supplier.SelectedIndex != -1)
            {
                string sorgu = "SELECT sum(Stok_Miktarı),sum(Stok_Miktarı * Alıs_Fiyatı), sum(Stok_Miktarı * Satıs_Fiyatı) FROM dukkan.mfw_gold_stoklar where Stok_Miktarı > 0 and Alıs_Fiyatı > 0 and Barkod_No Like '" + find_barcode.Text + "%' and Ürün_Adı Like '" + find_product.Text + "%' and Ürün_Cinsi Like '" + product_type.SelectedItem.ToString() + "%' and Toptancısı Like'" + supplier.SelectedItem.ToString() + "%'";

                baglan nesne = new baglan();


                MySqlDataReader icerik = nesne.contents(sorgu);

                textBox1.Text = icerik[0].ToString();
                textBox2.Text = icerik[1].ToString();
                textBox3.Text = icerik[2].ToString();
                textBox4.Text = (Convert.ToInt32(icerik[2]) - Convert.ToInt32(icerik[1])).ToString();

            }
            else if (supplier.SelectedIndex != -1)
            {
                string sorgu = "SELECT sum(Stok_Miktarı),sum(Stok_Miktarı * Alıs_Fiyatı), sum(Stok_Miktarı * Satıs_Fiyatı) FROM dukkan.mfw_gold_stoklar where Stok_Miktarı > 0 and Alıs_Fiyatı > 0 and Barkod_No Like '" + find_barcode.Text + "%' and Ürün_Adı Like '" + find_product.Text + "%' and Toptancısı Like'" + supplier.SelectedItem.ToString() + "%'";

                baglan nesne = new baglan();


                MySqlDataReader icerik = nesne.contents(sorgu);

                textBox1.Text = icerik[0].ToString();
                textBox2.Text = icerik[1].ToString();
                textBox3.Text = icerik[2].ToString();
                textBox4.Text = (Convert.ToInt32(icerik[2]) - Convert.ToInt32(icerik[1])).ToString();
            }
            else if (product_type.SelectedIndex != -1)
            {
                string sorgu = "SELECT sum(Stok_Miktarı),sum(Stok_Miktarı * Alıs_Fiyatı), sum(Stok_Miktarı * Satıs_Fiyatı) FROM dukkan.mfw_gold_stoklar where Stok_Miktarı > 0 and Alıs_Fiyatı > 0 and Barkod_No Like '" + find_barcode.Text + "%' and Ürün_Adı Like '" + find_product.Text + "%' and Ürün_Cinsi Like '" + product_type.SelectedItem.ToString() + "%'";

                baglan nesne = new baglan();


                MySqlDataReader icerik = nesne.contents(sorgu);

                textBox1.Text = icerik[0].ToString();
                textBox2.Text = icerik[1].ToString();
                textBox3.Text = icerik[2].ToString();
                textBox4.Text = (Convert.ToInt32(icerik[2]) - Convert.ToInt32(icerik[1])).ToString();
            }
            else
            {
                string sorgu = "SELECT sum(Stok_Miktarı),sum(Stok_Miktarı * Alıs_Fiyatı), sum(Stok_Miktarı * Satıs_Fiyatı) FROM dukkan.mfw_gold_stoklar where Stok_Miktarı > 0 and Alıs_Fiyatı > 0 and Barkod_No Like '" + find_barcode.Text + "%' and Ürün_Adı Like '" + find_product.Text + "%' ";

                baglan nesne = new baglan();


                MySqlDataReader icerik = nesne.contents(sorgu);

                textBox1.Text = icerik[0].ToString();
                textBox2.Text = icerik[1].ToString();
                textBox3.Text = icerik[2].ToString();
                textBox4.Text = (Convert.ToInt32(icerik[2]) - Convert.ToInt32(icerik[1])).ToString();
            }






            }

        private void supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(supplier.SelectedIndex != -1)
            {
                string sorgu = "SELECT * FROM mfw_gold_stoklar where Toptancısı Like '" + supplier.SelectedItem.ToString() + "%' ";

                baglan nesne = new baglan();

                dataGridView2.DataSource = nesne.fill_table(sorgu, "mfw_gold_stoklar");
            }
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            baglan baglan = new baglan();
            dataGridView2.DataSource = baglan.fill_table("Select * from mfw_gold_stoklar", "mfw_gold_stoklar");

        }

        private void Stock_Durumu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                find_barcode.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void find_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                baglan baglan = new baglan();
                dataGridView2.DataSource = baglan.fill_table("Select * from mfw_gold_stoklar where Barkod_No = '" + find_barcode.Text + "'", "mfw_gold_stoklar");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            excel tablo  = new excel();

            tablo.Excel_Disa_Aktar(dataGridView2);

        }
    }
}
