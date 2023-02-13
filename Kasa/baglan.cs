using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Kasa
{
    internal class baglan
    {
        //"Server= localhost;Database=dukkan;Uid=root;Pwd='1234';Convert Zero Datetime=true; Allow Zero Datetime=true;
        private MySqlConnection con;
        private MySqlDataAdapter da;
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataReader dr;

        public MySqlConnection path = new MySqlConnection("server=localhost;port=3307;uid=root;pwd='A1265913226y';database=dukkan; Convert Zero Datetime=true; Allow Zero Datetime=true;");

        public baglan()
        {
            con = new MySqlConnection("server=localhost;port=3307;uid=root;pwd='A1265913226y';database=dukkan; Convert Zero Datetime=true; Allow Zero Datetime=true;");
        }

        public DataTable fill_table(String sorgu, String table_name)
        {
            con.Close();

            con.Open();

            da = new MySqlDataAdapter(sorgu, con);
            ds = new DataSet();
            da.Fill(ds, table_name);

            con.Close();

            return ds.Tables[table_name];

        }
        
        public MySqlDataReader contents(String sorgu)
        {
            con.Close();

            con.Open();

            cmd = new MySqlCommand(sorgu, con);

            dr = cmd.ExecuteReader();
            
            if(dr.Read())
            {
                return dr;
            }

            con.Close();

            return null;
        }

        public void insert(String sorgu)
        {
            con.Close();   
            con.Open();

            cmd = new MySqlCommand(sorgu, con);

            object kayıt = cmd.ExecuteNonQuery();

            con.Close();


        }

        public void delete(String sorgu)
        {
            con.Close();

            con.Open();

            cmd = new MySqlCommand(sorgu, con);

            object kayıt = cmd.ExecuteNonQuery();

            con.Close();
        }


        public void query_run(String sorgu)
        {
            con.Close();

            con.Open();

            cmd = new MySqlCommand(sorgu, con);

            object kayıt = cmd.ExecuteNonQuery();

            con.Close();
        }

        public void backup(string path)
        {
            using (con)
            {
                using (MySqlCommand command = new MySqlCommand())
                {
                    using (MySqlBackup backup = new MySqlBackup(command))
                    {
                        command.Connection = con;
                        con.Open();
                        backup.ExportToFile(path+"\\backup.sql");
                        con.Close();
                    }
                }
            }
        }

        

    }
}

