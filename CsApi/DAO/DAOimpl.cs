using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;

namespace CsApi.DAO
{
    public class DAOimpl
    {
        string connString = "server=127.0.0.1;port=3306;user id=root;password=Password1234;database=bank;charset=utf8;";
        MySqlConnection conn = new MySqlConnection();
        public void GetConnect()
        {

            conn.ConnectionString = connString;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string sql = @"select * from account";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            Console.WriteLine(cmd.ExecuteReader());
            conn.Close();
        }
    }
}
