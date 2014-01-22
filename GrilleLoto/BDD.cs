using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace GrilleLoto
{
    class BDD
    {
        private System.Data.OleDb.OleDbConnection Connection;
        public BDD(string FileName)
        {
            Connection = new System.Data.OleDb.OleDbConnection();
            Connection.ConnectionString = "Data Source=GrilleLotoBDD.sdf;Persist Security Info=False;Provider=SQLOLEDB;";
            Connection.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + FileName + ";";
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
            Connection.Dispose();
            Connection = null;
        }
    }
}
