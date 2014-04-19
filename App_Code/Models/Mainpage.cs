using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Mainpage
/// </summary>
/// 
namespace Models
{
    public class Mainpage
    {
        private SqlConnection sqlConn;
        private string connStr;
        
        public Mainpage()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private void sqlInit()
        {
            connStr = ConfigurationManager.ConnectionStrings["TestInput"].ConnectionString;
            sqlConn = new SqlConnection(connStr);
        }

        public Mainpage(int id, string ld, DateTime? dm, string op1, string op2)
        {
            ID = id;
            LineDesc = ld;
            DateMade = dm;
            Options1 = op1;
            Options2 = op2;
        }

        public int ID { get; set; }
        public string LineDesc { get; set; }
        public DateTime? DateMade { get; set; }
        public string Options1 { get; set; }
        public string Options2 { get; set; }

        public void Save()
        {
            sqlInit();
            string insertStr = "usr_InsertValues";
            SqlCommand sqlCmd = new SqlCommand(insertStr, sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter sp;
            if (DateMade.HasValue)
                sp = new SqlParameter("@p2", DateMade.Value);
            else
                sp = new SqlParameter("@p2", DBNull.Value);

            SqlParameter[] sps = new SqlParameter[] {new SqlParameter("@p1", LineDesc), 
                                                     sp,
                                                     new SqlParameter("@p3", Options1),
                                                     new SqlParameter("@p4", Options2)};
            sqlCmd.Parameters.AddRange(sps);
            
            sqlConn.Open();
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}