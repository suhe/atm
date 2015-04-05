using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using ATM.Vendor.Vileosoft.Text;

namespace ATM.Vendor.Vileosoft.Database
{
    class Connection
    {
        private SqlConnection connection; 
        private string server;
        private string instance;
        private string database;
        private string uid;
        private string password;

        public SqlConnection OpenDB()
        {
            IniFile ini = new IniFile("config.ini");
            server = ini.Read("ip");
            instance = ini.Read("instance");
            database = ini.Read("database");
            uid = ini.Read("user");
            password = ini.Read("password");
            string connString = "Data Source=" + server + "\\" + instance + ";Initial Catalog=" + database + ";Integrated Security=True;";
            connection = new SqlConnection(connString);
            connection.Open();
            return connection;
        }

        public bool CloseDB()
        {
            connection.Close();
            return true;
        }

        
    }
}
