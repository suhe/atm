using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ATM.Vendor.Vileosoft.Database;

namespace ATM.Models
{
    class Warkat
    {
        public static int WarkatID = 0;
        public static string TransactionCode = "";
        public static string WarkatNo = "";
        public static string DueDate = "";
        public static int BankID=0;
        public static int AccountID=0;
        public static Double Nominal=0;

        public DataTable dataSource()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Select_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add(new SqlParameter("@BankCode", bankCode));
            cmd.Connection = conn.OpenDB();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.CloseDB();
            return dt;
        }

        public bool FindByCode(string byCode)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Single_By_TransactionCode_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TransactionCode", byCode));
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            if (DR.Read())
            {
                conn.CloseDB();
                return true;
            }
            //FirstName = "Test";
            conn.CloseDB();
            return false;
        }

        public bool Insert()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Insert_Office]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TransactionCode", TransactionCode));
            cmd.Parameters.Add(new SqlParameter("@WarkatNo", WarkatNo));
            cmd.Parameters.Add(new SqlParameter("@DueDate", DueDate));
            cmd.Parameters.Add(new SqlParameter("@BankID", BankID));
            cmd.Parameters.Add(new SqlParameter("@AccountID", AccountID));
            cmd.Parameters.Add(new SqlParameter("@Nominal", Nominal));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;

        }

        public bool Update()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Update_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@WarkatID", WarkatID));
            cmd.Parameters.Add(new SqlParameter("@WarkatNo", WarkatNo));
            cmd.Parameters.Add(new SqlParameter("@DueDate", DueDate));
            cmd.Parameters.Add(new SqlParameter("@BankID", BankID));
            cmd.Parameters.Add(new SqlParameter("@AccountID", AccountID));
            cmd.Parameters.Add(new SqlParameter("@Nominal", Nominal));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;

        }

    }
}
