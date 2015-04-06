using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ATM.Vendor.Vileosoft.Database;

namespace ATM.Models
{
    class Bank
    {
        public static int BankID=0;
        public static string BankCode = "";
        public static string BankName = "";
        public static string BankInitial = "";
        public static string TypeKey = "";
        public static int Status = 0;

        public DataTable dataSource(string bankCode = null, string bankName = null, string bankInitial = null, string typeKey = null)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Select_Bank]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@BankCode", bankCode));
            cmd.Parameters.Add(new SqlParameter("@BankName", bankName));
            cmd.Parameters.Add(new SqlParameter("@Initial", bankInitial));
            cmd.Parameters.Add(new SqlParameter("@TypeKey", typeKey));
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
            cmd.CommandText = "[dbo].[Sp_Single_Bank]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@BankID", BankID));
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            if (DR.Read())
            {
                BankID = int.Parse(DR.GetValue(0).ToString());
                BankCode = DR.GetValue(1).ToString();
                BankName = DR.GetValue(2).ToString();
                BankInitial = DR.GetValue(3).ToString();
                TypeKey = DR.GetValue(4).ToString();
                Status = int.Parse(DR.GetValue(5).ToString());
            }
            
            conn.CloseDB();
            return true;
        }
    }

        
}
