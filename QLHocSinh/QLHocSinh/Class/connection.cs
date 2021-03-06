﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Hoc_Sinh.Class
{
    class connection
    {
        private SqlConnection conn = null;
        public int connect()
        {
            if (conn == null)
            {
                conn = new SqlConnection(globalParameter.str);
            }
            try
            {
                conn.Open();
                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public int isOpen()
        {
            if (conn == null) return -1;
            if (conn.State == ConnectionState.Closed) return -1;
            return 0;
        }
        public void close()
        {
            if (isOpen() == 0)
            {
                conn.Close();
                conn = null;
            }
        }
        public int doSql(string sql, params SqlParameter[] pr)
        {
            int ret = 0;
            if (isOpen() < 0) ret = connect();
            if (ret < 0) return -2;
            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = sql;
            foreach (SqlParameter p in pr)
            {
                cm.Parameters.Add(p);
            }
            try
            {
                ret = cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = -1;
            }
            return ret;
        }
        public int doStored(string storedName, params SqlParameter[] pr)
        {
            int ret = 0;
            if (isOpen() < 0) ret = connect();
            if (ret < 0) return -2;
            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = storedName;
            foreach (SqlParameter p in pr)
            {
                cm.Parameters.Add(p);
            }
            try
            {
                ret = cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = -1;
            }
            return ret;
        }
        public int getSql(ref DataSet ds, string tableName, string sql, params SqlParameter[] pr)
        {
            int ret = 0;
            if (isOpen() < 0) ret = connect();
            if (ret < 0) return -2;
            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            foreach (SqlParameter p in pr)
                cm.Parameters.Add(p);
            try
            {
                ret = da.Fill(ds, tableName);
            }
            catch (Exception e)
            {
                ret = -1;
            }
            return ret;
        }
    }
}

