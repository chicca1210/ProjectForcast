using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForwardFrancesca
{
    class Model
    {
        public delegate void viewEventHandler(object sender, string textToWrite);
        public event viewEventHandler FlushText;
        public void doSomathing()
        {
            for (int i = 0; i < 10; i++)
                FlushText(this, $"i={i}");
        }
        public void readView(string connString, bool isSQLite, string idCli)
        {
            IDbConnection conn = null;
            try
            {
                if (isSQLite)
                    conn = new SQLiteConnection(connString);
                else
                    conn = new SqlConnection(connString);

                conn.Open();
                IDbCommand com = conn.CreateCommand();


                string queryText = "SELECT val FROM histordini WHERE idserie=@id";
                com.CommandText = queryText;

                IDbDataParameter param = com.CreateParameter();
                param.DbType = DbType.Int32;
                param.ParameterName = "@id";
                param.Value = Convert.ToInt32(idCli);
                com.Parameters.Add(param);

                IDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    FlushText(this, reader["val"]+ "");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                FlushText(this, ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
