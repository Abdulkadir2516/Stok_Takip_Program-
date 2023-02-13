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
    public partial class Append : Form
    {
        public Append()
        {
            InitializeComponent();
        }

        private void Append_Shown(object sender, EventArgs e)
        {

            Ana_Ekran ana_Ekran = new Ana_Ekran();

            this.BackColor = ana_Ekran.renk;

            yenile();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan baglan = new baglan();
            baglan.query_run("Delete from gruplar Where Grup_Adı = '" + product_type.Text + "'");

            yenile();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            baglan baglan = new baglan();
            baglan.query_run("Delete from toptancı Where Toptancı_Adı = '"+ wholesaler.Text +"'" );

            yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglan baglan = new baglan();
            baglan.insert("insert into gruplar values('" + product_type_name.Text + "')");
            
            yenile();

        }

        private void insert_Click(object sender, EventArgs e)
        {
            baglan baglan = new baglan();
            baglan.insert("insert into toptancı values('"+ wholesaler_name.Text +"')");
            
            yenile();
        
        }


        public void yenile()
        {
            baglan baglan = new baglan();

            product_type.SelectedIndex = -1;
            product_type.Items.Clear();

            wholesaler.SelectedIndex = -1;
            wholesaler.Items.Clear();

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

            wholesaler_name.Clear();
            product_type_name.Clear();


        }

    }
}
