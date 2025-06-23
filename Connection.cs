using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTehnologica
{
    internal class Connection
    {
        SqlConnection con;

        public Connection()
        {
            con = new SqlConnection("Data Source=VLADUTA\\SQLEXPRESS;Initial Catalog=Lumea_Copiilor;Integrated Security=True");
        }

        public SqlConnection OpenConnection()
        {
            try
            {
                con.Open();
            }
            catch (Exception)
            {

            }
            return con;
        }

        public void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

            }

        }

    }
}
