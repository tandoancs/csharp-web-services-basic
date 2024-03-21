using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HelloWorld
{
    /// <summary>
    /// Summary description for FirstWebService
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    [WebService(Name = "Web Service", Namespace = "http://tempuri.org/", Description = "This is The First Web Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FirstWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello, World";
        }
    }
}
