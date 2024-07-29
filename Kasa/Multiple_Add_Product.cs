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
using Excel = Microsoft.Office.Interop.Excel;

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
            baglan baglan = new baglan();

            float toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                MySqlDataReader icerik = baglan.contents("Select Stok_Miktarı ,Satıs_Fiyatı, İsk_Satıs_Fiyatı, Tarih from mfw_gold_stoklar " +
                    "where Barkod_No = '" + dataGridView1.Rows[i].Cells[0].Value + "' ");

                if (icerik != null)
                {

                    dataGridView1.Rows[i].Cells[7].Value = icerik[0].ToString();
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

        private void import_excel_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string yol = openFileDialog1.FileName;
                MessageBox.Show("Seçilen Dosya: " + yol);
                LoadExcelToDataGridView(yol);
            }


            

        }

        private void LoadExcelToDataGridView(string path)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            DataTable dt = new DataTable();

            // Sütunları oluştur
            for (int i = 1; i <= xlRange.Columns.Count; i++)
            {
                dt.Columns.Add(xlRange.Cells[1, i].Value2.ToString());
            }

            // Satırları doldur
            for (int i = 2; i <= xlRange.Rows.Count; i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 1; j <= xlRange.Columns.Count; j++)
                {
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        row[j - 1] = xlRange.Cells[i, j].Value2.ToString();
                    }
                }
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;

            // Excel nesnelerini serbest bırak
            xlWorkbook.Close(false);
            xlApp.Quit();

            ReleaseObject(xlRange);
            ReleaseObject(xlWorksheet);
            ReleaseObject(xlWorkbook);
            ReleaseObject(xlApp);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Nesne serbest bırakılırken bir hata oluştu: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
