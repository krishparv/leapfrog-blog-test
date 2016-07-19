using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridaBhatta
{
    class SqlHelper
    {
      private string connectionString = string.Empty;
      private SqlConnection conn = null;
      

        public SqlHelper()
        {
            connectionString=@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BridaBhata;Data Source=.\SQLEXPRESS2008";
            _Connect();
        }


        private void _Connect()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public int ExectueNonQuery(string query, params object [] args)
        {
           using(SqlCommand sqlcmd=CreateCommand(query,CommandType.Text))
            {
               for(int i=0; i< args.Length;i++)
               {
                   sqlcmd.Parameters.AddWithValue(args[i].ToString(), args[i++]);
               }
               return sqlcmd.ExecuteNonQuery();
            }
        }

        private SqlCommand CreateCommand(string query,CommandType ctype)
        {
            SqlCommand scmd = new SqlCommand(query, conn);
            scmd.CommandType = ctype;
            return scmd;
        }

        public void Disconnect()
        {
            conn.Close();
        }
    }
}
