using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace GetDataWS
{
    /// <summary>
    /// Summary description for DataWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataWS : System.Web.Services.WebService
    {

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        [WebMethod]
        public string DataTableForUsers(string Id)
        {
            var query = "SELECT * FROM Users WHERE Id = '" + Id + "'";
            if (Id.Length == 0 )
            {
                query = "SELECT * FROM Users ORDER BY Id ASC;";
            }
            
            objDBAccess.readDatathroughAdapter(query, dtUsers);

            string result = JsonConvert.SerializeObject(dtUsers);

            return result;
        }

    }
}
