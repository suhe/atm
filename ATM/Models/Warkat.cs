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
        public static string BankCode = "";
        public static int AccountID=0;
        public static string AccountNo = "";
        public static Double Nominal=0;

        public String AutoTransactionCode()
        {
            string autocode="";
            //fill to Year + Month
            autocode += System.DateTime.Now.ToString("yyyyMM");
            //fill Auto to user id
            autocode += LoginForm.UserId!=0 ? LoginForm.UserId : 0;
            //fill Total Transaction
            autocode += TransactionCodeDigit(this.CountAll() + 1);
            return autocode;
        }

        public DataTable dataSource(string transactionCode = "", string WarkatNo = "", string dateFrom = "", string dateTo = "", string bankCode = "", string accountNo = "")
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Select_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TransactionCode", transactionCode));
            cmd.Parameters.Add(new SqlParameter("@WarkatNo", WarkatNo));
            cmd.Parameters.Add(new SqlParameter("@DateFrom", dateFrom));
            cmd.Parameters.Add(new SqlParameter("@DateTo", dateTo));
            cmd.Parameters.Add(new SqlParameter("@BankCode", bankCode));
            cmd.Parameters.Add(new SqlParameter("@AccountNo", accountNo));
            cmd.Connection = conn.OpenDB();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.CloseDB();
            return dt;
        }

        public DataTable dataSourceByExpired()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Select_By_Expired_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn.OpenDB();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.CloseDB();
            return dt;
        }

        public int CountDataSourceByExpired()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Count_By_Expired_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            int total = 0;
            if (DR.Read())
            {
                total += int.Parse(DR.GetValue(0).ToString());
            }
            
            conn.CloseDB();
            return total;
        }

        public bool DataReader()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Single_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@WarkatID", WarkatID));
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            if (DR.Read())
            {
                WarkatID = int.Parse(DR.GetValue(0).ToString());
                TransactionCode = DR.GetValue(1).ToString();
                WarkatNo = DR.GetValue(2).ToString();
                DueDate = DR.GetValue(3).ToString();
                BankID = int.Parse( DR.GetValue(4).ToString());
                BankCode = DR.GetValue(5).ToString();
                AccountID = int.Parse(DR.GetValue(7).ToString());
                AccountNo = DR.GetValue(8).ToString();
                Nominal = double.Parse( DR.GetValue(10).ToString());
            }
            //FirstName = "Test";
            conn.CloseDB();
            return true;
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
            cmd.CommandText = "[dbo].[Sp_Insert_Warkat]";
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

        public bool Delete(string ID)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Delete_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
        }

        public int CountAll()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Count_All_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            int Total = 0;
            if (DR.Read())
            {
                Total+= int.Parse(DR.GetValue(0).ToString());
            }
            //FirstName = "Test";
            conn.CloseDB();
            return Total;
        }

        public string TransactionCodeDigit(int numeric)
        {
            string Digit="";
            if (numeric < 10)
                Digit += "000" + numeric;
            else if (numeric < 100)
                Digit += "00" + numeric;
            else if (numeric < 1000)
                Digit += "0" + numeric;
            else
                Digit += numeric;

            return Digit;
        }

        public DataSet findByAccount(string dateFrom,string dateTo,int AccountFromID,int AccountToID)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Select_By_Account_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@DateFrom", dateFrom));
            cmd.Parameters.Add(new SqlParameter("@DateTo", dateTo));
            cmd.Parameters.Add(new SqlParameter("@AccountFromID", AccountFromID));
            cmd.Parameters.Add(new SqlParameter("@AccountToID", AccountToID));
            cmd.Connection = conn.OpenDB();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.CloseDB();
            return ds;
        }

        public DataSet findByExpired()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Select_By_Expired_Warkat]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn.OpenDB();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.CloseDB();
            return ds;
        }

    }
}
