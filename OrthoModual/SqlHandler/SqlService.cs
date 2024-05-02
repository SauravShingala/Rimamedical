using DataAccsessLayer;
using System.Data;
using System.Data.SqlClient;

namespace OrthoModual.SqlHandler
{
    public class SqlService
    {
        public SqlConnection connection = null;
        public SqlCommand cmd = null;

        public SqlService()
        {
            connection = new SqlConnection(ConnectionStringDAL.ConStr);
            cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection = connection;
        }
    }



}
