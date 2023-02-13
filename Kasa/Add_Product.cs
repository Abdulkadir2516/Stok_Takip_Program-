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

namespace Kasa
{
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }

        private void Add_Product_Shown(object sender, EventArgs e)
        {
            Ana_Ekran ana_Ekran = new Ana_Ekran();

            this.BackColor = ana_Ekran.renk;

            baglan baglan = new baglan();
            MySqlDataReader icerik = baglan.contents("Select * from gruplar");
            product_type.Items.Add(icerik.GetString(0).ToString());

            while (icerik.Read())
            {
                product_type.Items.Add(icerik.GetString(0).ToString());

            }

            baglan baglan2 = new baglan();

            MySqlDataReader icerik2 = baglan2.contents("Select * from Toptancı");
            wholesaler.Items.Add(icerik2.GetString(0).ToString());

            while (icerik2.Read())
            {
                wholesaler.Items.Add(icerik2.GetString(0).ToString());

            }


            barcode.Focus();
            piece.SelectedIndex = 0;


        }

        private void barcode_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                product_name.Focus();

                baglan baglan = new baglan();
                
                string sorgu = "Select Ürün_Adı,Toptancısı, Ürün_Cinsi,  Alıs_Fiyatı, Satıs_Fiyatı, İsk_Satıs_Fiyatı, Alt_Limiti, Stok_Miktarı, Tarih, Birimi From mfw_gold_stoklar Where Barkod_no = '" + barcode.Text + "'";

                MySqlDataReader icerik = baglan.contents(sorgu);

                if(icerik != null)
                {

                    product_name.Text = icerik[0].ToString();
                    wholesaler.Text = icerik[1].ToString();
                    product_type.Text = icerik[2].ToString();
                    purchase_price.Text = icerik[3].ToString();
                    sales_price.Text = icerik[4].ToString();
                    discount_price.Text = icerik[5].ToString();
                    min_limit.Text = icerik[6].ToString();
                    number.Text = icerik[7].ToString();
                    date.Text = icerik[8].ToString();
                    piece.Text = icerik[9].ToString();

                    update.Enabled = true;
                    insert.Enabled = false;

                }
                else
                {
                    insert.Enabled = true;
                    update.Enabled = false;
                }
            }
        }

        private void product_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wholesaler.Focus();
            }

        }

        private void wholesaler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                product_type.Focus();
            }
        }

        private void product_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                purchase_price.Focus();
            }
        }

        private void purchase_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                char[] ond = purchase_price.Text.ToCharArray();
                bool kontrol = true;

                for (int i = 0; i < ond.Length; i++)
                {

                    if (',' == ond[i])
                    {
                        kontrol = false;

                    }

                }

                if (kontrol)
                {
                    purchase_price.Text = purchase_price.Text + ",00";
                }

                /*
                baglan baglan = new baglan();

                MySqlDataReader icerik = baglan.contents("Select yüzdelik from gruplar where Grup_Adı = '"+ product_type.Text +"' limit 1");

                try
                {
                    if (icerik != null)
                    {

                        sales_price.Text = (Convert.ToDouble(purchase_price.Text) + Convert.ToDouble(purchase_price.Text) * ((Convert.ToSingle(icerik[0].ToString())) / 100)).ToString();

                        sales_price.Text = Math.Floor(Convert.ToDouble(sales_price.Text)).ToString();
                    }
                }
                catch (Exception)
                {
                    sales_price.Text = (Convert.ToDouble(purchase_price.Text) * 0.3 + Convert.ToDouble(purchase_price.Text)).ToString();

                    sales_price.Text = Math.Floor(Convert.ToDouble(sales_price.Text)).ToString();
                }
                */

                sales_price.Text = (Convert.ToDouble(purchase_price.Text) * (Convert.ToDouble(numericUpDown1.Text) / 100) + Convert.ToDouble(purchase_price.Text)).ToString();

                sales_price.Text = Math.Floor(Convert.ToDouble(sales_price.Text)).ToString();

                sales_price.Focus();
            }
        }

        private void sales_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                char[] ond = sales_price.Text.ToCharArray();
                bool kontrol = true;

                for (int i = 0; i < ond.Length; i++)
                {

                    if (',' == ond[i])
                    {
                        kontrol = false;
                    }

                }

                if (kontrol)
                {
                    sales_price.Text = sales_price.Text + ",00";
                }

                
                discount_price.Focus();
                discount_price.Text = sales_price.Text;
            }
        }

        private void discount_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                min_limit.Focus();
            }
        }

        private void min_limit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                number.Focus();
            }
        }

        private void number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (insert.Enabled == true)
                {
                    insert.Focus();

                }
                else
                {
                    update.Focus();
                }
            }
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            barcode.Focus();

            baglan nesne = new baglan();

            MySqlConnection baglan = nesne.path;

            baglan.Open();

            MySqlCommand barkodsorgu = new MySqlCommand("Update mfw_gold_stoklar set Barkod_No= @Barkod_No, Ürün_Adı=@Ürün_Adı, Ürün_Cinsi=@Ürün_Cinsi, Toptancısı=@Toptancısı, Alıs_Fiyatı=@Alıs_Fiyatı, SatıS_Fiyatı=@SatıS_Fiyatı, İsk_SatıS_Fiyatı=@İsk_SatıS_Fiyatı, Stok_Miktarı=@Stok_Miktarı, Birimi=@Birimi, Alt_Limiti=@Alt_Limiti , Tarih=@Tarih where Barkod_No = @Barkod_no", baglan);

            barkodsorgu.Parameters.AddWithValue("@Barkod_no", barcode.Text);
            barkodsorgu.Parameters.AddWithValue("@Ürün_adı", product_name.Text);
            barkodsorgu.Parameters.AddWithValue("@Ürün_Cinsi", product_type.Text);
            barkodsorgu.Parameters.AddWithValue("@Toptancısı", wholesaler.Text);
            barkodsorgu.Parameters.AddWithValue("@Alıs_Fiyatı", purchase_price.Text);
            barkodsorgu.Parameters.AddWithValue("@SatıS_Fiyatı", sales_price.Text);
            barkodsorgu.Parameters.AddWithValue("@İsk_SatıS_Fiyatı", discount_price.Text);
            barkodsorgu.Parameters.AddWithValue("@Stok_Miktarı", Convert.ToInt32(number.Text));
            barkodsorgu.Parameters.AddWithValue("@Birimi", piece.Text);
            barkodsorgu.Parameters.AddWithValue("@Alt_Limiti", Convert.ToInt32(min_limit.Text));
            barkodsorgu.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("yyyy-MM,dd"));



            object sonuc = null;
            sonuc = barkodsorgu.ExecuteNonQuery();

            baglan.Close();

            temizle();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            barcode.Focus();
            temizle();


        }

        private void remove_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("İşlem yapılsın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                string sorgu = "Delete from mfw_gold_stoklar Where Barkod_No = '" + barcode.Text + "'";

                baglan nesne = new baglan();
                nesne.delete(sorgu);

                barcode.Focus();

                temizle();
            }
            else if (secenek == DialogResult.No)
            {
                //Hayır derse yapılacak işlemler
            }

            

        }

        private void insert_Click(object sender, EventArgs e)
        {
            barcode.Focus();

            try
            {


                baglan nesne = new baglan();

                MySqlConnection baglan = nesne.path;

                baglan.Open();

                MySqlCommand barkodsorgu = new MySqlCommand("insert into mfw_gold_stoklar Values(@Barkod_No,@Ürün_Adı," +
                    " @Ürün_Cinsi, @Toptancısı, @Alıs_Fiyatı, @Satıs_Fiyatı, @İsk_Satıs_Fiyatı, @Stok_Miktarı, @Birimi, @Alt_Limiti , @Tarih )", baglan);

                barkodsorgu.Parameters.AddWithValue("@Barkod_no", barcode.Text);
                barkodsorgu.Parameters.AddWithValue("@Ürün_adı", product_name.Text);
                barkodsorgu.Parameters.AddWithValue("@Ürün_Cinsi", product_type.Text);
                barkodsorgu.Parameters.AddWithValue("@Toptancısı", wholesaler.Text);
                barkodsorgu.Parameters.AddWithValue("@Alıs_Fiyatı", purchase_price.Text);
                barkodsorgu.Parameters.AddWithValue("@Satıs_Fiyatı", sales_price.Text);
                barkodsorgu.Parameters.AddWithValue("@İsk_SatıS_Fiyatı", discount_price.Text);
                barkodsorgu.Parameters.AddWithValue("@Stok_Miktarı", Convert.ToInt32(number.Text));
                barkodsorgu.Parameters.AddWithValue("@Birimi", piece.Text);
                barkodsorgu.Parameters.AddWithValue("@Alt_Limiti", Convert.ToInt32(min_limit.Text));
                barkodsorgu.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("yyyy-MM,dd"));


                object sonuc = null;
                sonuc = barkodsorgu.ExecuteNonQuery();

                baglan.Close();

                temizle();
            }
            catch (Exception)
            {


            }

        }

        public void temizle()
        {
            piece.SelectedIndex = 0;
            barcode.Clear();
            product_name.Clear();
            wholesaler.SelectedIndex = -1;
            product_type.SelectedIndex = -1;
            purchase_price.Clear();
            sales_price.Clear();
            min_limit.Text = "1";
            number.Clear();
            discount_price.Clear();
            date.Clear();

        }

        private void add_wholesaler_Click(object sender, EventArgs e)
        {
            Append goster = new Append();
            goster.Show();

        }

        private void multiple_add_Click(object sender, EventArgs e)
        {
            Multiple_Add_Product goster = new Multiple_Add_Product();
            goster.Show();
        }
    }
}
