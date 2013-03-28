using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Collections;
using System.Data.Common;
using System.Data.SqlServerCe;

namespace SpartanWarsTool
{
    public class DBOperator
    {
        //Connect operator
        protected SqlCeConnection conn;

        //connect string
        private static string connectionString = "";
        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        // Timeout default = 30秒
        private int timeout = 30;
        public int Timeout
        {
            get { return timeout; }
            set { timeout = value; }
        }

        //sql param
        private ArrayList parameters = new ArrayList();
        public ArrayList Parameters
        {
            get { return parameters; }
        }

        /// <summary>
        /// add param
        /// </summary>
        /// <param name="sName">name</param>
        /// <param name="value">value</param>
        public void AddParameter(string sName, object value)
        {
            DbParameter dbPara = null;
            SqlCeCommand cmd = new SqlCeCommand();

            dbPara = cmd.CreateParameter();
            dbPara.ParameterName = sName;
            dbPara.Value = value;
            parameters.Add(dbPara);
        }

        /// <summary>
        /// clear all parameters
        /// </summary>
        public void RemoveAllParameters()
        {
            parameters.Clear();
        }

        /// <summary>
        /// set param
        /// </summary>
        /// <param name="cmd"></param>
        private void setParameters(SqlCeCommand cmd)
        {
            foreach (object obj in parameters)
            {
                cmd.Parameters.Add(obj);
            }
        }


        /// <summary>
        /// constructor
        /// </summary>
        public DBOperator()
        {
            try
            {
                //new connnect
                conn = new SqlCeConnection(@"Data Source=spartanData.sdf;Encrypt Database=True;Password=123456;File Mode=shared read;Persist Security Info=False;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ~DBOperator()
        {
            Close();
        }

        /// <summary>
        /// open connect
        /// </summary>
        public void Open()
        {
            try
            {
                //conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// close connect
        /// </summary>
        public void Close()
        {
            if (conn.State != ConnectionState.Closed)
            {
                try
                {
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <param name="sSQL">sql</param>
        /// <returns>ds</returns>
        public DataSet Select(string sSQL)
        {
            DataSet ds = new DataSet();
            SqlCeCommand cmd = null;
            try
            {
                cmd = new SqlCeCommand(sSQL, conn);
                setParameters(cmd);

                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

                Open();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                RemoveAllParameters();
            }

            Close();

            return ds;
        }

        /// <summary>
        /// execute SQL
        /// </summary>
        /// <param name="sSQL">sql</param>
        /// <returns>modifiedLines</returns>
        public int ExecuteSQL(string sSQL)
        {
            int modifiedLines = 0;
            SqlCeCommand cmd = null;
            try
            {
                cmd = new SqlCeCommand(sSQL, conn);
                cmd.CommandTimeout = timeout;
                setParameters(cmd);
                Open();
                modifiedLines = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                RemoveAllParameters();
            }

            return modifiedLines;
        }
    }
}
