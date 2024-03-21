using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess
    {
        protected SqlConnection _conn;

        //static string host = "";
        //static string database = "";
        //static string userDB = "";
        //static string password = "";
        //public static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password + ";Connect Timeout=10000;charset=utf8;convertzerodatetime=true;";

        public static string strProvider = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HolidaysDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public bool _OpenConn()
        {
            try
            {
                _conn = new SqlConnection(strProvider);
                _conn.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public void _CloseConn()
        {
            _conn.Close();
            _conn.Dispose();
        }

        public DataTable ExecuteDataTable(string query)
        {
            DataTable dt = new DataTable();

            if (_OpenConn())
            {
                try
                {
                    SqlCommand Sqlcmd = new SqlCommand(query, _conn);
                    dt.Load(Sqlcmd.ExecuteReader());
                }
                catch (Exception ex)
                {
                    // khong lam gi ca
                }
            }


            _CloseConn();

            return dt;
        }

        public DataSet ExecuteDataSet(string query)
        {
            DataSet ds = new DataSet();
            if (_OpenConn())
            {
                try
                {


                    SqlDataAdapter da = new SqlDataAdapter(query, _conn);
                    da.Fill(ds, "result");

                }
                catch (Exception ex)
                {
                    // khong lam gi ca
                }
            }


            _CloseConn();


            return ds;

        }

        public SqlDataReader ExecuteReader(string query)
        {

            if (_OpenConn())
            {
                try
                {
                    SqlDataReader reader;
                    SqlCommand cmd = new SqlCommand(query, _conn);
                    reader = cmd.ExecuteReader();
                    _CloseConn();
                    return reader;
                }
                catch (Exception ex)
                {
                    // khong lam gi ca
                }
            }

            _CloseConn();

            return null;
        }

        ////public int ExecuteNonQuery(string query)
        ////{
        ////    if (_OpenConn())
        ////    {
        ////        SqlTransaction trans = _conn.BeginTransaction();

        ////        try
        ////        {
        ////            int affected;

        ////            SqlCommand cmd = _conn.CreateCommand();
        ////            cmd.CommandText = query;
        ////            affected = cmd.ExecuteNonQuery();
        ////            trans.Commit();
        ////            return affected;
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            trans.Rollback();

        ////            return -1;
        ////        }
        ////    }

        ////    _CloseConn();

        ////    return -1;
        ////}

        public int ExecuteNonQuery(string query)
        {
            var affected = 0;
            if (_OpenConn())
            {
                SqlTransaction trans = _conn.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _conn);
                    affected = cmd.ExecuteNonQuery();

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    affected = -1;
                }
            }

            _CloseConn();

            return affected;
        }


    }
}
