using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_NET_Nhom11.Resources
{
    internal class database
    {
        private string strConn;
        private database(string strConn)
        {
            this.strConn = strConn;
        }

        private static database instance;

        public static database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new database("Data Source=CHAOXA\\MSSQLSERVER01;Initial Catalog=SQLQuanlykhachsan_gr11;Integrated Security=True");
                }
                return instance;
            }
            private set { instance = value; }
        }

    public int db_num_rows(string query)
    {
        int count = 0;
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

        SqlCommand command = new SqlCommand(query, conn);

        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            count = (int)reader[0];
        }

        reader.Close();
        conn.Close();

        return count;
    }

    public SqlDataReader db_select(string strSql)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSql, conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void db_insert(string table, Dictionary<string, string> data)
        {
            string columns = string.Join(",", data.Keys.Select(key => $"[{key}]"));
            string values = string.Join(",", data.Keys.Select(key => $"@{key}"));

            string query = $"INSERT INTO {table} ({columns}) VALUES ({values})";

            using (SqlConnection connection = new SqlConnection(strConn))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                foreach (KeyValuePair<string, string> item in data)
                {
                    command.Parameters.AddWithValue($"@{item.Key}", item.Value);
                }

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void db_update(string table, Dictionary<string, string> data, string where)
        {
            string set_values = string.Join(",", data.Select(item => $"[{item.Key}] = @{item.Key}"));
            string query = $"UPDATE {table} SET {set_values} WHERE {where}";

            using (SqlConnection conn = new SqlConnection(strConn))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                foreach (KeyValuePair<string, string> item in data)
                {
                    command.Parameters.AddWithValue($"@{item.Key}", item.Value);
                }

                conn.Open();
                command.ExecuteNonQuery();
            }
        }

        public void db_delete(string table, string where)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = $"DELETE FROM {table} WHERE {where}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
