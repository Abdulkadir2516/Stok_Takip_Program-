using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System;
using Org.BouncyCastle.Utilities.Collections;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Net.NetworkInformation;




namespace Kasa
{
    public partial class Ana_Ekran : Form
    {
        public Color renk = Color.MediumTurquoise;

        public int secim = 0;
        public Ana_Ekran()
        {
            InitializeComponent();

        }

        private void stock_Click(object sender, EventArgs e)
        {
            barcode.Focus();

            Stock_Durumu goster = new Stock_Durumu();

            goster.Show();

        }

        private DataGridView islem(TabControl a)
        {

            if (tabControl.SelectedIndex == 0)
            {
                return dataGridView1;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                return dataGridView2;
            }
            else if (tabControl.SelectedIndex == 2)
            {
                return dataGridView3;
            }
            else if (tabControl.SelectedIndex == 3)
            {
                return dataGridView4;
            }
            else if (tabControl.SelectedIndex == 4)
            {
                return dataGridView5;

            }

            return null;
        }
        private void barcode_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.F7)
            {
                onayla();
            }


            if (e.KeyCode == Keys.Enter)
            {

                baglan nesne = new baglan();

                MySqlConnection baglan = nesne.path;

                DataGridView satislar = islem(tabControl);

                baglan.Open();

                if (barcode.Text == "99")
                {
                    float sayi = (float)Convert.ToDouble(Interaction.InputBox("Tan�ms�z Barkod Giri�i", "Fiyat Giriniz:"));

                    try
                    {
                        MySqlCommand komut = new MySqlCommand("INSERT INTO anl�k_sat�s Values(@id, @Tarih, @Saat, @Barkod_No, @�r�n_Ad�, @Adedi, @Birimi,@Al�s_Fiyat� ,@Sat�s_Fiyat�, @Tutar�)", baglan);
                        komut.Parameters.AddWithValue("@id", satislar.Name.ToString());
                        komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd"));
                        komut.Parameters.AddWithValue("@Saat", Convert.ToDateTime(DateTime.Now.ToLongTimeString()).ToString("HH:mm:ss"));
                        komut.Parameters.AddWithValue("@Barkod_No", "99");
                        komut.Parameters.AddWithValue("@�r�n_Ad�", "Tan�ms�z Barkod");
                        komut.Parameters.AddWithValue("@Adedi", 1);
                        komut.Parameters.AddWithValue("@Birimi", "AD");
                        komut.Parameters.AddWithValue("@Al�s_Fiyat�", 0);
                        komut.Parameters.AddWithValue("@Sat�s_Fiyat�", sayi);
                        komut.Parameters.AddWithValue("@Tutar�", sayi);

                        object kay�t = komut.ExecuteNonQuery();

                        baglan.Close();

                        barcode.Clear();

                    }
                    catch (Exception)
                    {


                    }


                }
                else
                {

                    char[] brk = barcode.Text.ToCharArray();
                    String ad = "";
                    String barkod = "";
                    int adet = 1;
                    for (int i = 0; i < brk.Length; i++)
                    {

                        if ('*' == brk[i])
                        {
                            ad = barcode.Text.Substring(0, i + 1);

                            ad = barcode.Text.Substring(0, i);
                            barkod = barcode.Text.Substring(i + 1);

                            adet = Convert.ToInt16(ad);
                            break;

                        }
                        else
                        {
                            barkod = barcode.Text;

                        }
                    }

                    String sorgu = "Select Barkod_No, �r�n_Ad�, Birimi, Sat�s_Fiyat�, Alt_Limiti, Stok_Miktar�, Al�s_Fiyat� from mfw_gold_stoklar Where Barkod_No = \"" + barkod + "\"";

                    MySqlDataReader icerik = nesne.contents(sorgu);

                    if (icerik != null)
                    {

                        if (Convert.ToInt16(icerik[5]) - adet <= Convert.ToInt16(icerik[4]))
                        {
                            //MessageBox.Show("Bu �r�n�n alt limitine ula��ld�");
                            Console.Beep();
                            Console.Beep();

                            //barcode.BackColor = Color.Red;

                        }

                        float tutar = adet * Convert.ToSingle(icerik[3]);

                        product_name.Text = icerik[1].ToString();
                        unit_cost.Text = icerik[3].ToString();
                        piece.Text = adet.ToString();
                        amount.Text = tutar.ToString();
                        


                        // adet, icerik[2].ToString(), icerik[3].ToString(), tutar);

                        MySqlCommand komut = new MySqlCommand("INSERT INTO anl�k_sat�s Values(@id, @Tarih, @Saat, @Barkod_No, @�r�n_Ad�, @Adedi, @Birimi, @Al�s_Fiyat� ,@Sat�s_Fiyat�, @Tutar�)", baglan);
                        komut.Parameters.AddWithValue("@id", satislar.Name.ToString());
                        komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd"));
                        komut.Parameters.AddWithValue("@Saat", Convert.ToDateTime(DateTime.Now.ToLongTimeString()).ToString("HH:mm:ss"));
                        komut.Parameters.AddWithValue("@Barkod_No", barkod);
                        komut.Parameters.AddWithValue("@�r�n_Ad�", icerik[1].ToString());
                        komut.Parameters.AddWithValue("@Adedi", adet);
                        komut.Parameters.AddWithValue("@Birimi", icerik[2].ToString());
                        komut.Parameters.AddWithValue("@Al�s_Fiyat�", Convert.ToSingle(icerik[6].ToString()));
                        komut.Parameters.AddWithValue("@Sat�s_Fiyat�", Convert.ToSingle(icerik[3].ToString()));
                        komut.Parameters.AddWithValue("@Tutar�", tutar);

                        object kay�t = komut.ExecuteNonQuery();

                        baglan.Close();

                        barcode.Clear();

                    }

                }

                MySqlDataReader content = nesne.contents("Select sum(Tutar) FROM anl�k_sat�s WHERE �d = '" + satislar.Name.ToString() + "'");

                total.Text = content[0].ToString();


                barcode.Focus();

                satislar.DataSource = nesne.fill_table("Select Tarih, Saat, Barkod, �r�n_ad� as �r�n_Ad� , Adet, Birim, Satis_Fiyati as Birim_Fiyat�, Tutar FROM anl�k_sat�s WHERE �d = '" + satislar.Name.ToString() + "'  order by saat Desc", "anl�k_sat�s");



            }

        }

        public void ekle(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F7)
            {
                onayla();
            }

            if (e.KeyCode == Keys.Enter)
            {
                baglan nesne = new baglan();

                MySqlConnection baglan = nesne.path;

                DataGridView satislar = islem(tabControl);

                baglan.Open();

                float sayi = (float)Convert.ToDouble(Interaction.InputBox("Tan�ms�z Barkod Giri�i", "Fiyat Giriniz:"));

                if (barcode.Text == "99")
                {
                    try
                    {
                        MySqlCommand komut = new MySqlCommand("INSERT INTO anl�k_sat�s Values(@id, @Tarih, @Saat, @Barkod_No, @�r�n_Ad�, @Adedi, @Birimi,@Al�s_Fiyat� ,@Sat�s_Fiyat�, @Tutar�)", baglan);
                        komut.Parameters.AddWithValue("@id", satislar.Name.ToString());
                        komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd"));
                        komut.Parameters.AddWithValue("@Saat", Convert.ToDateTime(DateTime.Now.ToLongTimeString()).ToString("HH:mm"));
                        komut.Parameters.AddWithValue("@Barkod_No", "99");
                        komut.Parameters.AddWithValue("@�r�n_Ad�", "Tan�ms�z Barkod");
                        komut.Parameters.AddWithValue("@Adedi", 1);
                        komut.Parameters.AddWithValue("@Birimi", "AD");
                        komut.Parameters.AddWithValue("@Al�s_Fiyat�", 0);
                        komut.Parameters.AddWithValue("@Sat�s_Fiyat�", sayi);
                        komut.Parameters.AddWithValue("@Tutar�", sayi);

                        object kay�t = komut.ExecuteNonQuery();

                        baglan.Close();


                    }
                    catch (Exception)
                    {


                    }


                }
                else
                {

                    char[] brk = barcode.Text.ToCharArray();
                    String ad = "";
                    String barkod = "";
                    int adet = 1;
                    for (int i = 0; i < brk.Length; i++)
                    {

                        if ('*' == brk[i])
                        {
                            ad = barcode.Text.Substring(0, i + 1);

                            ad = barcode.Text.Substring(0, i);
                            barkod = barcode.Text.Substring(i + 1);

                            adet = Convert.ToInt16(ad);
                            break;

                        }
                        else
                        {
                            barkod = barcode.Text;

                        }
                    }

                    String sorgu = "Select Barkod_No, �r�n_Ad�, Birimi, Sat�s_Fiyat�, Alt_Limiti, Stok_Miktar�, Al�s_Fiyat� from mfw_gold_stoklar Where Barkod_No = \"" + barkod + "\"";

                    baglan connect = new baglan();

                    MySqlDataReader icerik = connect.contents(sorgu);

                    if (icerik != null)
                    {

                        if (Convert.ToInt16(icerik[5]) - adet <= Convert.ToInt16(icerik[4]))
                        {
                            MessageBox.Show("Bu �r�n�n alt limitine ula��ld�");

                            //barcode.BackColor = Color.Red;

                        }

                        float tutar = adet * Convert.ToSingle(icerik[3]);

                        product_name.Text = icerik[1].ToString();
                        unit_cost.Text = icerik[3].ToString();
                        piece.Text = adet.ToString();
                        amount.Text = tutar.ToString();


                        // adet, icerik[2].ToString(), icerik[3].ToString(), tutar);

                        MySqlCommand komut = new MySqlCommand("INSERT INTO anl�k_sat�s Values(@id, @Tarih, @Saat, @Barkod_No, @�r�n_Ad�, @Adedi, @Birimi,@Al�s_Fiyat� ,@Sat�s_Fiyat�, @Tutar�)", baglan);
                        komut.Parameters.AddWithValue("@id", satislar.Name.ToString());
                        komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd"));
                        komut.Parameters.AddWithValue("@Saat", Convert.ToDateTime(DateTime.Now.ToLongTimeString()).ToString("HH:mm"));
                        komut.Parameters.AddWithValue("@Barkod_No", barkod);
                        komut.Parameters.AddWithValue("@�r�n_Ad�", icerik[1].ToString());
                        komut.Parameters.AddWithValue("@Adedi", adet);
                        komut.Parameters.AddWithValue("@Birimi", icerik[2].ToString());
                        komut.Parameters.AddWithValue("@Al�s_Fiyat�", icerik[6].ToString());
                        komut.Parameters.AddWithValue("@Sat�s_Fiyat�", icerik[3].ToString());
                        komut.Parameters.AddWithValue("@Tutar�", tutar);

                        object kay�t = komut.ExecuteNonQuery();

                        baglan.Close();

                    }

                }


                total.Text = total_amount(satislar, 7).ToString();

                barcode.Clear();

                barcode.Focus();



            }

        }

        public float total_amount(DataGridView x, int h�cre)
        {
            float toplam = 0;
            for (int i = 0; i < x.Rows.Count; ++i)
            {
                toplam += Convert.ToSingle(x.Rows[i].Cells[h�cre].Value);
            }

            return toplam;

        }


        private void tablo_doldur()
        {
            baglan baglan = new baglan();

            DataGridView satislar = islem(tabControl);

            satislar.DataSource = baglan.fill_table("Select Tarih, Saat, Barkod, �r�n_ad� as �r�n_Ad� , Adet, Birim, Satis_Fiyati as Birim_Fiyat�, Tutar FROM anl�k_sat�s WHERE �d = '" + satislar.Name.ToString() + "'  order by saat Desc ", "anl�k_sat�s");


        }

        private void Ana_Ekran_Shown(object sender, EventArgs e)
        {
            DataGridView satislar = islem(tabControl);

            total.Text = total_amount(satislar, 7).ToString();

            this.BackColor = renk;

            tablo_doldur();

            //product_find.Visible = false;



            barcode.Focus();

        }

        private void add_product_Click(object sender, EventArgs e)
        {
            barcode.Focus();

            Add_Product goster = new Add_Product();
            goster.Show();

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView satislar = islem(tabControl);

            baglan nesne = new baglan();

            MySqlDataReader content = nesne.contents("Select sum(Tutar) FROM anl�k_sat�s WHERE �d = '" + satislar.Name.ToString() + "'");

            total.Text = content[0].ToString();
            tablo_doldur();
            barcode.Focus();

        }

        private void onayla()
        {
            DataGridView satislar = islem(tabControl);
            baglan baglan = new baglan();

            baglan.query_run("INSERT INTO gunluk_sat�s " +
                "SELECT Tarih, Saat, Barkod, �r�n_ad�, Adet, Birim, Alis_Fiyat, Satis_Fiyati, Tutar " +
                "FROM anl�k_sat�s " +
                "WHERE �d= '" + satislar.Name.ToString() + "' and Barkod <> '99'");


            for (int i = 0; i < satislar.Rows.Count; i++)
            {
                baglan.query_run("Update mfw_gold_stoklar set Stok_Miktar� = Stok_Miktar�-" + satislar.Rows[i].Cells[4].Value + " where Barkod_No = '" + satislar.Rows[i].Cells[2].Value + "' ");
            }

            baglan.query_run("delete from anl�k_sat�s WHERE �d= '" + satislar.Name.ToString() + "'");

            barcode.Focus();
            product_name.Text = "";
            unit_cost.Text = "";
            piece.Text = "";
            amount.Text = "";
            total.Text = "";


            satislar.DataSource = baglan.fill_table("Select Tarih, Saat, Barkod, �r�n_ad� as �r�n_Ad� , Adet, Birim, Satis_Fiyati as Birim_Fiyat�, Tutar FROM anl�k_sat�s WHERE �d = '" + satislar.Name.ToString() + "'", "anl�k_sat�s");
        }

        private void approve_Click(object sender, EventArgs e)
        {
            onayla();
        }

        private void daily_sales_Click(object sender, EventArgs e)
        {
            barcode.Focus();

            Daily_Sales goster = new Daily_Sales();
            goster.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            barcode.Focus();

            Sales_Status goster = new Sales_Status();
            goster.Show();

        }

        private void sales_cancellation_Click(object sender, EventArgs e)
        {
            barcode.Focus();

            Sales_Cancellation goster = new Sales_Cancellation();
            goster.Show();
        }

        private void backup_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            string yol = folderBrowserDialog1.SelectedPath;

            baglan yedek = new baglan();
            yedek.backup(yol);
        }

        private void learn_price_Click(object sender, EventArgs e)
        {
            barcode.Focus();


            Learn_Price goster = new Learn_Price();
            goster.Show();

        }

        private void Ana_Ekran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                onayla();

            }
        }




        private void sil_Click(object sender, EventArgs e)
        {
            baglan baglan = new baglan();

            DataGridView satislar = islem(tabControl);

            baglan.delete("Delete from anl�k_sat�s Where �d = '" + satislar.Name.ToString() + "' and barkod ='" + satislar.SelectedRows[0].Cells[2].Value + "' and adet = '" + satislar.SelectedRows[0].Cells[4].Value + "' and saat = '" + satislar.SelectedRows[0].Cells[1].Value + "'");


            satislar.DataSource = baglan.fill_table("Select Tarih, Saat, Barkod, �r�n_ad� as �r�n_Ad� , Adet, Birim, Satis_Fiyati as Birim_Fiyat�, Tutar FROM anl�k_sat�s WHERE �d = '" + satislar.Name.ToString() + "' order by saat desc", "anl�k_sat�s");

            total.Text = total_amount(satislar, 7).ToString();
            barcode.Focus();

        }

        private void change_price_Click(object sender, EventArgs e)
        {
            baglan baglan = new baglan();

            DataGridView satislar = islem(tabControl);

            String sayi = (Interaction.InputBox("Fiyat De�i�ikli�i", "Fiyat Giriniz:"));


            sayi = sayi.Replace(",", ".");


            baglan.query_run("update anl�k_sat�s set Satis_Fiyati = '" + sayi + "', Tutar = Adet * Satis_Fiyati " +
                "Where �d = '" + satislar.Name.ToString() + "' and barkod ='" + satislar.SelectedRows[0].Cells[2].Value + "' and adet = '" + satislar.SelectedRows[0].Cells[4].Value + "' ");


            satislar.DataSource = baglan.fill_table("Select Tarih, Saat, Barkod, �r�n_ad� as �r�n_Ad� , Adet, Birim, Satis_Fiyati as Birim_Fiyat�, Tutar FROM anl�k_sat�s WHERE �d = '" + satislar.Name.ToString() + "' order by saat desc", "anl�k_sat�s");

            total.Text = total_amount(satislar, 7).ToString();


        }

        private void exceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan baglan = new baglan();

            DataGridView satislar = islem(tabControl);

            excel tablo = new excel();

            tablo.Excel_Disa_Aktar(satislar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void productName_TextChanged(object sender, EventArgs e)
        {
            baglan baglan = new baglan();
            dataGridView6.DataSource = baglan.fill_table("Select barkod_no, �r�n_Ad�, Sat�s_Fiyat�, Stok_Miktar� from mfw_gold_stoklar where �r�n_ad� like '%" + productName.Text + "%'", "mfw_gold_stoklar");

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                barcode.Text = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
            }
            barcode.Focus();

        }

        private void dataGridView6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            barcode.Text = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
            
            barcode.Focus();
        }
    }
}








/*
               if (tabControl.SelectedIndex == 0)
               {
                   dataGridView1.Rows.Add(DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), barkod, icerik[1].ToString(), adet, icerik[2].ToString(), icerik[3].ToString(), tutar);
                   total.Text = total_amount(dataGridView1).ToString();
               }
               else if(tabControl.SelectedIndex == 1)
               {
                   dataGridView2.Rows.Add(DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), barkod, icerik[1].ToString(), adet, icerik[2].ToString(), icerik[3].ToString(), tutar);
                   total.Text = total_amount(dataGridView2).ToString();

               }
               else if (tabControl.SelectedIndex == 2)
               {
                   dataGridView3.Rows.Add(DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), barkod, icerik[1].ToString(), adet, icerik[2].ToString(), icerik[3].ToString(), tutar);
                   total.Text = total_amount(dataGridView3).ToString();

               }
               else if (tabControl.SelectedIndex == 3)
               {
                   dataGridView4.Rows.Add(DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), barkod, icerik[1].ToString(), adet, icerik[2].ToString(), icerik[3].ToString(), tutar);
                   total.Text = total_amount(dataGridView4).ToString();

               }
               else if (tabControl.SelectedIndex == 4)
               {
                   dataGridView5.Rows.Add(DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), barkod, icerik[1].ToString(), adet, icerik[2].ToString(), icerik[3].ToString(), tutar);
                   total.Text = total_amount(dataGridView5).ToString();

               }
               */




/*
            MySqlConnection connect = baglan.path;

            for (int i = 0; i < satislar.Rows.Count - 1; i++)
            {

                if (satislar.Rows[i].Cells[2].Value.ToString() != "99")
                {
                    connect.Open();
                    MySqlDataReader icerik = baglan.contents("Select Al�s_Fiyat� from mfw_gold_stoklar where Barkod_No= '" + satislar.Rows[i].Cells[2].Value.ToString() + "'");

                    MySqlCommand komut = new MySqlCommand("INSERT INTO gunluk_sat�s Values(@Tarih, @Saat, @Barkod_No, @�r�n_Ad�, @Adedi, @Birimi,@Al�s_Fiyat� ,@Sat�s_Fiyat�, @Tutar�)", connect);

                    komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(satislar.Rows[i].Cells[0].Value).ToString("yyyy-MM-dd"));
                    komut.Parameters.AddWithValue("@Saat", Convert.ToDateTime(satislar.Rows[i].Cells[1].Value).ToString("HH:mm"));
                    komut.Parameters.AddWithValue("@Barkod_No", satislar.Rows[i].Cells[2].Value.ToString());
                    komut.Parameters.AddWithValue("@�r�n_Ad�", satislar.Rows[i].Cells[3].Value.ToString());
                    komut.Parameters.AddWithValue("@Adedi", satislar.Rows[i].Cells[4].Value.ToString());
                    komut.Parameters.AddWithValue("@Birimi", satislar.Rows[i].Cells[5].Value.ToString());
                    komut.Parameters.AddWithValue("@Al�s_Fiyat�", icerik[0].ToString());
                    komut.Parameters.AddWithValue("@Sat�s_Fiyat�", satislar.Rows[i].Cells[6].Value.ToString());
                    komut.Parameters.AddWithValue("@Tutar�", satislar.Rows[i].Cells[7].Value.ToString());

                    object kay�t = komut.ExecuteNonQuery();

                    connect.Close();

                }

            }*/





                /**
                if (barcode.Text == "99")
                {

                    float sayi = (float)Convert.ToDouble(Interaction.InputBox("Tan�ms�z Barkod Giri�i","Fiyat Giriniz:"));
                    /*
                    string IsimGirisi = Interaction.InputBox("Tan�ms�z Barkod Giri�i", "�r�n Fiyat�n� Giriniz.", "50", 0, 0);
                    MessageBox.Show("Girilen isim: " + IsimGirisi);
                           

                    DataGridView satislar = islem(tabControl);

                    satislar.Rows.Add(DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), "99", "Tan�ms�z Barkod", 1, "ad", sayi, sayi);
                    total.Text = total_amount(satislar,7).ToString();

                    barcode.Clear();

                }
                else
                {

                    char[] brk = barcode.Text.ToCharArray();
                    String ad = "";
                    String barkod = "";
                    int adet = 1;
                    for (int i = 0; i < brk.Length; i++)
                    {

                        if ('*' == brk[i])
                        {
                            ad = barcode.Text.Substring(0, i + 1);

                            ad = barcode.Text.Substring(0, i);
                            barkod = barcode.Text.Substring(i + 1);

                            adet = Convert.ToInt16(ad);
                            break;

                        }
                        else
                        {
                            barkod = barcode.Text;

                        }
                    }

                    String sorgu = "Select Barkod_No, �r�n_Ad�, Birimi, Sat�s_Fiyat�, Alt_Limiti, Stok_Miktar� from mfw_gold_stoklar Where Barkod_No = \"" + barkod + "\"";

                    baglan baglan = new baglan();

                    MySqlDataReader icerik = baglan.contents(sorgu);

                    if(icerik != null)
                    {

                        if (Convert.ToInt16(icerik[5]) - adet <= Convert.ToInt16(icerik[4]))
                        {
                            MessageBox.Show("Bu �r�n�n alt limitine ula��ld�");

                            //barcode.BackColor = Color.Red;

                        }

                        float tutar = adet * Convert.ToSingle(icerik[3]);

                        product_name.Text = icerik[1].ToString();
                        unit_cost.Text = icerik[3].ToString();
                        piece.Text = adet.ToString();
                        amount.Text = tutar.ToString();


                        DataGridView satislar = islem(tabControl);

                        satislar.Rows.Add(DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), barkod, icerik[1].ToString(), adet, icerik[2].ToString(), icerik[3].ToString(), tutar);
                        total.Text = total_amount(satislar, 7).ToString();
                        
                        barcode.Clear();

                    }

                }
               
                barcode.Focus();
                //barcode.BackColor = Color.White;
                */