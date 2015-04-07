using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using ATM.Vendor.Vileosoft.Database;

namespace ATM.Models
{
    class Account
    {
        public static int AccountID = 0;
        public static string AccountNo = "";
        public static string AccountName = "";
        
        public DataTable dataSource(string accountNo = null, string accountName = null)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Select_Account]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AccountNo", accountNo));
            cmd.Parameters.Add(new SqlParameter("@AccountName", accountName));
            cmd.Connection = conn.OpenDB();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.CloseDB();
            return dt;
        }

        public bool DataReader()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Single_Account]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AccountID", AccountID));
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            if (DR.Read())
            {
                AccountID = int.Parse(DR.GetValue(0).ToString());
                AccountNo = DR.GetValue(1).ToString();
                AccountName = DR.GetValue(2).ToString();
            }

            conn.CloseDB();
            return true;
        }

        public bool FindByCode(string byNo)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Single_By_Code_Account]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AccountNo", byNo));
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            if (DR.Read())
            {
                conn.CloseDB();
                return true;
            }

            conn.CloseDB();
            return false;
        }

        public bool Insert()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Insert_Account]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AccountNo", AccountNo));
            cmd.Parameters.Add(new SqlParameter("@AccountName", AccountName));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
        }

        public bool Update()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Update_Account]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AccountName", AccountName));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
        }

        public bool Delete(string ID)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Delete_Account]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
        }
    }


}
