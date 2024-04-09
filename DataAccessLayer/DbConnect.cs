﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbConnect
    {
        private string SQLConnectionStringLocal = @"Server = SCA\SQLEXPRESS;Database =Hospital; Trusted_Connection = True;";
        private string SQLConnectionStringSomee = "workstation id=gp_hospital.mssql.somee.com;packet size=4096;user id=sca33_SQLLogin_1;pwd=ejc7i6uu64;data source=gp_hospital.mssql.somee.com;persist security info=False;initial catalog=gp_hospital;TrustServerCertificate=True";
        protected SqlConnection con = new SqlConnection();
        protected SqlDataAdapter da = new SqlDataAdapter();
        protected SqlCommand com = new SqlCommand();
        protected SqlException exception = null;

        public DbConnect()
        {
            exception = null;
            con = new SqlConnection(SQLConnectionStringLocal);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
                }
            }
        }
    }
}
