using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ATM.Vendor.Vileosoft.Database;

namespace ATM.Models
{
    class Office
    {
        public static int OfficeID=0;
        public static string OfficeCode = "";
        public static string BankCode = "";
        public static string BankName = "";
        public static string OfficeName = "";
        public static string Address = "";
        public static string CityKey = "";
        public static string ProvinceKey = "";
        public static string SetKerKey = "";
        public static string KliringKey = "";
        public static string ContactPhone = "";
        public static int BankID = 0;

        public DataTable dataSource(string officeCode = null, string bankCode = null, string officeName = null, string bankName = null, string address = null)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Select_Office]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OfficeCode", officeCode));
            cmd.Parameters.Add(new SqlParameter("@BankCode", bankCode));
            cmd.Parameters.Add(new SqlParameter("@OfficeName", officeName));
            cmd.Parameters.Add(new SqlParameter("@BankName", bankName));
            cmd.Parameters.Add(new SqlParameter("@Address", address));
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
            cmd.CommandText = "[dbo].[Sp_Single_Office]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OfficeID", OfficeID));
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            if (DR.Read())
            {
                OfficeID = int.Parse(DR.GetValue(0).ToString());
                OfficeCode = DR.GetValue(1).ToString();
                BankCode = DR.GetValue(2).ToString();
                BankName = DR.GetValue(3).ToString();
                OfficeName = DR.GetValue(4).ToString();
                Address = DR.GetValue(5).ToString();
                CityKey = DR.GetValue(6).ToString();
                ProvinceKey = DR.GetValue(7).ToString();
                SetKerKey = DR.GetValue(8).ToString();
                KliringKey = DR.GetValue(9).ToString();
                ContactPhone = DR.GetValue(10).ToString();
                BankID = int.Parse(DR.GetValue(11).ToString());
            }
            //FirstName = "Test";
            conn.CloseDB();
            return true;
        }

        public bool FindByCode(string byCode)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Single_By_Code_Office]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OfficeCode", byCode));
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
            cmd.Parameters.Add(new SqlParameter("@OfficeCode", OfficeCode));
            cmd.Parameters.Add(new SqlParameter("@BankID", BankID));
            cmd.Parameters.Add(new SqlParameter("@OfficeName", OfficeName));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@CityKey", CityKey));
            cmd.Parameters.Add(new SqlParameter("@ProvinceKey", ProvinceKey));
            cmd.Parameters.Add(new SqlParameter("@SatKerKey", SetKerKey));
            cmd.Parameters.Add(new SqlParameter("@KliringKey", KliringKey));
            cmd.Parameters.Add(new SqlParameter("@ContactPhone", ContactPhone));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;

        }

        public bool Update()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Update_Office]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OfficeID", OfficeID));
            cmd.Parameters.Add(new SqlParameter("@BankID", BankID));
            cmd.Parameters.Add(new SqlParameter("@OfficeName", OfficeName));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@CityKey", CityKey));
            cmd.Parameters.Add(new SqlParameter("@ProvinceKey", ProvinceKey));
            cmd.Parameters.Add(new SqlParameter("@SatKerKey", SetKerKey));
            cmd.Parameters.Add(new SqlParameter("@KliringKey", KliringKey));
            cmd.Parameters.Add(new SqlParameter("@ContactPhone", ContactPhone));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
        }

        public bool Delete(string ID)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Delete_Office]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
        }

    }
     
}
