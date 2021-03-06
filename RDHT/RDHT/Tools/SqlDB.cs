﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RDHT.Tools
{
    public class SqlDB

    {

        protected SqlConnection conn;

        /*打开连接*/

        public bool OpenConnection()

        {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnection"].ConnectionString);

            try

            {

                bool result = true;

                if (conn.State.ToString() != "Open")

                {

                    conn.Open();

                }

                return result;

            }

            catch (SqlException ex)

            {

                return false;

            }

        }

        /*关闭连接*/

        public bool CloseConnection()

        {

            try

            {

                conn.Close();

                return true;

            }

            catch (Exception ex)

            {

                return false;

            }

        }

        /*数据库操作类*/


        public int InsertData(string sql)

        {

            int lastId = 0;

            //string query = sql + ";SELECT @@Identity;";

            try

            {

                if (conn.State.ToString() == "Open")

                {

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    //cmd.ExecuteNonQuery();

                    lastId = ToInt(cmd.ExecuteScalar());//返回第一行的第一列

                }

                return ToInt(lastId);

            }

            catch (Exception ex)

            {

                return 0;

            }

        }

        /*转换成整型*/

        private int ToInt(object o)

        {

            try

            {

                return int.Parse(o.ToString());

            }

            catch (Exception ex)

            {

                return 0;

            }

        }
        public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                //PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                //Close(conn);
                //Dispose(conn);
                throw;
            }
        }

    }

}