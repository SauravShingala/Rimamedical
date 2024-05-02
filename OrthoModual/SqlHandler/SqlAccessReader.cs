using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OrthoModual.SqlHandler
{
    public class SqlAccessReader<T>
    {
        #region ExecuteReaderDataSet

        public IList<T> ExecuteReader(SqlCommand cmd)
        {
            var results = new List<T>();
            try
            {
                using (cmd.Connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection.Open();
                    cmd.CommandTimeout = 240;
                    SqlDataReader reader = cmd.ExecuteReader();

                    var properties = typeof(T).GetProperties();

                    while (reader.Read())
                    {
                        var item = Activator.CreateInstance<T>();
                        foreach (var property in typeof(T).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                            {
                                Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
                            }
                        }
                        results.Add(item);
                    }

                    cmd.Connection.Close();
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
            return results;
        }

        public DataTable Execute(SqlCommand cmd)
        {
            var result = new DataTable();
            try
            {
                using (cmd.Connection = new SqlConnection(ConnectionStringDAL.ConStr))
                {
                    cmd.Connection.Open();
                    cmd.CommandTimeout = 240;
                    SqlDataReader reader = cmd.ExecuteReader();
                    result.Load(reader);

                    cmd.Connection.Close();
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
            return result;
        }

        #endregion

    }
}
