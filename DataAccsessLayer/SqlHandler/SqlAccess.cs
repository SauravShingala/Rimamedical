using DataAccsessLayer;
using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer.SqlHandler
{
    public class SqlAccess
    {
        #region ExecuteReaderDataSet

        public DataSet ExecuteReaderDataSet(string query)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection = connection;
                    adp.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                ds.Dispose();
                adp.Dispose();
                cmd.Dispose();
                throw ex;
            }
            finally
            {
                adp.Dispose();
                cmd.Dispose();
            }

            return ds;
        }

        public DataSet ExecuteReaderDataSet(SqlCommand cmd)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection = connection;
                    cmd.CommandTimeout = 240;
                    adp.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                ds.Dispose();
                adp.Dispose();
                cmd.Dispose();
                throw ex;
            }
            finally
            {
                adp.Dispose();
                cmd.Dispose();
            }

            return ds;
        }

        #endregion

        #region ExecuteReaderDataTable

        public DataTable ExecuteReaderDataTable(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection = connection;
                    adp.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt.Dispose();
                adp.Dispose();
                cmd.Dispose();
                throw ex;
            }
            finally
            {
                adp.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public DataTable ExecuteReaderDataTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection = connection;
                    adp.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt.Dispose();
                adp.Dispose();
                cmd.Dispose();
                throw ex;
            }
            finally
            {
                adp.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        #endregion

        #region ExecuteScalar

        public object ExecuteScalar(string query)
        {
            object returnValue = 0;
            SqlCommand cmd = new SqlCommand(query);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection = connection;

                    // Open the connection.
                    connection.Open();

                    // Execute command.
                    returnValue = cmd.ExecuteScalar();

                    // Close connection.
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
            finally
            {
                cmd.Dispose();
            }
            return returnValue;
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            object returnValue = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection = connection;

                    // Open the connection.
                    connection.Open();

                    // Execute command.
                    returnValue = cmd.ExecuteScalar();

                    // Close connection.
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
            finally
            {
                cmd.Dispose();
            }
            return returnValue;
        }

        #endregion

        #region ExecuteNonQuery

        public object ExecuteNonQuery(string query)
        {
            int affectedRows = 0;
            SqlCommand cmd = new SqlCommand(query);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection = connection;

                    // Open the connection.
                    connection.Open();

                    // Execute command.
                    affectedRows = cmd.ExecuteNonQuery();

                    // Close connection.
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
            finally
            {
                cmd.Dispose();
            }
            return affectedRows;
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            int affectedRows = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection = connection;

                    // Open the connection.
                    connection.Open();

                    // Execute command.
                    affectedRows = cmd.ExecuteNonQuery();

                    // Close connection.
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
            finally
            {
                cmd.Dispose();
            }
            return affectedRows;
        }

        #endregion

        #region Transactional ExecuteScalar
        public SqlCommand BeginTransaction()
        {
            SqlConnection connection = new SqlConnection(ConnectionStringDAL.ConStr);
            // Open the connection.

            SqlCommand command = connection.CreateCommand();
            connection.Open();
            SqlTransaction transaction;

            // Start a local transaction.
            transaction = connection.BeginTransaction();

            // to Command object for a pending local transaction
            command.Connection = connection;
            command.Transaction = transaction;
            return command;
        }

        public void CommitTransaction(SqlCommand cmd)
        {
            try
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Commit();
                }
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }
            catch (Exception)
            {
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
                throw new Exception("Cannot commit transation");
            }

        }

        public void RollbackTransaction(SqlCommand cmd)
        {
            try
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();
                }
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }
            catch (Exception)
            {
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
                throw new Exception("Cannot rollback transation");
            }

        }

        public object ExecuteTransactionalScalar(SqlCommand cmd)
        {
            return cmd.ExecuteScalar();
        }


        #endregion

    }



}
