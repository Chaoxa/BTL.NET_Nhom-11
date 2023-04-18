using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_NET_Nhom11.Resources
{
    internal class database
    {
        private static database instance;

        public static database Instance 
        {   
            get { if (instance == null) instance = new database(); return database.instance; } 
            private set { instance = value; }
        }

        private database() { }

        string Strconn = @"Data Source=DESKTOP-60CHILE;Initial Catalog=SQLQuanlykhachsan_gr11;Integrated Security=True";
        string sql;
        SqlConnection conn;
        SqlCommand cmd;


        public SqlDataReader db_select(string strSql)
        {
            conn = new SqlConnection(Strconn);
            conn.Open();
            cmd = new SqlCommand(strSql, conn);
            return cmd.ExecuteReader();
        }

        public void db_insert(string table, Dictionary<string, string> data)
        {
            string columns = "";
            string values = "";

            foreach (KeyValuePair<string, string> item in data)
            {
                columns += "[" + item.Key + "],";
                values += "@" + item.Key + ",";
            }

            columns = columns.TrimEnd(',');
            values = values.TrimEnd(',');

            string query = "INSERT INTO " + table + " (" + columns + ") VALUES (" + values + ")";

            using (SqlConnection connection = new SqlConnection(Strconn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (KeyValuePair<string, string> item in data)
                    {
                        command.Parameters.AddWithValue("@" + item.Key, item.Value);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void db_update(string table, Dictionary<string, string> data, string where)
        {
            string set_values = "";

            foreach (KeyValuePair<string, string> item in data)
            {
                set_values += "[" + item.Key + "] = '" + item.Value + "',";
            }

            set_values = set_values.TrimEnd(',');

            string query = "UPDATE " + table + " SET " + set_values + " WHERE " + where;
            //MessageBox.Show(query);

            using (SqlConnection conn = new SqlConnection(Strconn))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void db_delete(string table, string where)
        {
            using (SqlConnection connection = new SqlConnection(Strconn))
            {
                string query = "DELETE FROM " + table + " WHERE " + where;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
