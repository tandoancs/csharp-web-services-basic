using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class Holidays : DBAccess
    {

        private static string _table = "holidays";
        //private static string _fields = "Item, Machine, ProcessCode, Width, Height, Scrap, UpdatedBy, UpdatedDate";
        private static string _fields = "ID, holiday_date, holiday_name_group, holiday_name_en, holiday_name_vi, remark, updated_by, updated_date";


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
        public DataTable ReadAll(string col = null)
        {
            string query = "SELECT " + _fields + " FROM " + _table + ";";
            if (col != null)
                query = "SELECT " + _fields + " FROM " + _table + " ORDER BY " + col + " ASC;";

            return ExecuteDataTable(query);
        }

        // read all data
        public DataTable ReadItem(HolidaysDTO Item)
        {
            string query = "SELECT " + _fields + " FROM " + _table + " WHERE ID = '" + Item.ID + "';";
            return ExecuteDataTable(query);
        }

        // add item
        public bool Create(HolidaysDTO Item)
        {
            // Query string 
            // "ID, holiday_date, holiday_name_group, holiday_name_en, holiday_name_vi, remark, updated_by, updated_date";
            string query = "INSERT INTO " + _table + "(" + _fields + ") VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
            string Query = string.Format(query,
                (Item.Holiday_date).ToString().Replace("\'", "\\\'"),
                (Item.Holiday_name_group).ToString().Replace("\'", "\\\'"),
                (Item.Holiday_name_en).ToString().Replace("\'", "\\\'"),
                (Item.Holiday_name_vi).ToString().Replace("\'", "\\\'"),
                (Item.Remark).ToString().Replace("\'", "\\\'"),
                (Item.Updated_by).ToString().Replace("\'", "\\\'"),
                (Item.Updated_date)
            );

            return (ExecuteNonQuery(Query) > 0) ? true : false;

        }

        public bool Update(HolidaysDTO Item)
        {

            // Query string 
            string query = "UPDATE " + _table + " SET holiday_date={1}, holiday_name_group={2}, holiday_name_en={3}, holiday_name_vi={4}, remark={5}, updated_by={6}, updated_date={7} WHERE ID={0} ";
            string Query = string.Format(query,
                (Item.ID),
                (Item.Holiday_date).ToString().Replace("\'", "\\\'"),
                (Item.Holiday_name_group).ToString().Replace("\'", "\\\'"),
                (Item.Holiday_name_en).ToString().Replace("\'", "\\\'"),
                (Item.Holiday_name_vi).ToString().Replace("\'", "\\\'"),
                (Item.Remark).ToString().Replace("\'", "\\\'"),
                (Item.Updated_by).ToString().Replace("\'", "\\\'"),
                (Item.Updated_date)
            );

            return (ExecuteNonQuery(Query) > 0) ? true : false;
        }

        public bool Delete(HolidaysDTO Item)
        {

            // Query string 
            string query = "DELETE FROM " + _table + " WHERE ID={0} ";
            string Query = string.Format(query, Item.ID);

            return (ExecuteNonQuery(Query) > 0) ? true : false;
            //return ExecuteNonQuery(Query) > 0; // tra ve kieu nay cung duoc

        }


    }
}
