using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MasterData : DBAccess
    {

        private static string _table = "master_data";
        //private static string _fields = "Item, Machine, ProcessCode, Width, Height, Scrap, UpdatedBy, UpdatedDate";
        private static string _fields = "item, machine, process_code, width, height, scrap, updated_by, updated_date";


        public int CountAll()
        {
            var count = 0;
            if (_OpenConn())
            {
                DataTable dt = new DataTable();
                try
                {
                    var sql = "SELECT count(*) FROM " + _table + ";";
                    SqlCommand Sqlcmd = new SqlCommand(sql, _conn);
                    count = Convert.ToInt32(Sqlcmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    // xử lý lỗi tại đây
                    Console.WriteLine("Count All Data Error: ");
                    Console.WriteLine(ex.ToString());
                    return count;
                }
            }

            _CloseConn();

            return count;
        }

        // read all data
        public DataTable ReadAll(string col = null )
        {
            string query = "SELECT " + _fields + " FROM " + _table + ";";
            if (col != null )
                query = "SELECT " + _fields + " FROM " + _table + " ORDER BY " + col + " ASC;";

            return ExecuteDataTable(query);
        }

        // read all data
        public DataTable ReadItem(string item)
        {
            string query = "SELECT " + _fields + " FROM " + _table + " WHERE item = '" + item + "';";
            return ExecuteDataTable(query);
        }

        // add item
        public bool Create(DataTable MasterData)
        {
            // Query string 
            // private static string _fields = "item, machine, process_code, width, height, scrap, updated_by, updated_date";

            string query = "INSERT INTO " + _table + "(" + _fields + ") VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
            string Query = string.Format(query, 
                (MasterData.Rows[0]["item"]).ToString().Replace("\'", "\\\'"),
                (MasterData.Rows[0]["machine"]).ToString().Replace("\'", "\\\'"),
                (MasterData.Rows[0]["process_code"]).ToString().Replace("\'", "\\\'"),
                Convert.ToDouble(MasterData.Rows[0]["width"]),
                Convert.ToDouble(MasterData.Rows[0]["height"]),
                Convert.ToDouble(MasterData.Rows[0]["scrap"]),
                (MasterData.Rows[0]["updated_by"]).ToString().Replace("\'", "\\\'"),
                (MasterData.Rows[0]["updated_date"]).ToString().Replace("\'", "\\\'")
            );

            return (ExecuteNonQuery(Query) > 0) ? true : false;

        }

        public bool Update(DataTable MasterData)
        {

            // Query string 
            string query = "UPDATE " + _table + " SET machine={1}, process_code={2}, width={3}, height={4}, scrap={5}, updated_by={6}, updated_date={7} WHERE item={0} ";
            string Query = string.Format(query,
                (MasterData.Rows[0]["item"]).ToString().Replace("\'", "\\\'"),
                (MasterData.Rows[0]["machine"]).ToString().Replace("\'", "\\\'"),
                (MasterData.Rows[0]["process_code"]).ToString().Replace("\'", "\\\'"),
                Convert.ToDouble(MasterData.Rows[0]["width"]),
                Convert.ToDouble(MasterData.Rows[0]["height"]),
                Convert.ToDouble(MasterData.Rows[0]["scrap"]),
                (MasterData.Rows[0]["updated_by"]).ToString().Replace("\'", "\\\'"),
                (MasterData.Rows[0]["updated_date"]).ToString().Replace("\'", "\\\'")
            );

            return (ExecuteNonQuery(Query) > 0) ? true : false;
        }

        public bool Delete(DataTable MasterData)
        {

            // Query string 
            string query = "DELETE FROM " + _table + " WHERE item={0} ";
            string Query = string.Format(query, MasterData.Rows[0]["item"]).ToString().Replace("\'", "\\\'" );

            return (ExecuteNonQuery(Query) > 0) ? true : false;
            //return ExecuteNonQuery(Query) > 0; // tra ve kieu nay cung duoc

        }


    }
}
