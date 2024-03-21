using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService2
{
    /// <summary>
    /// Summary description for CalculateWS
    /// </summary>
    /// 
    [WebService(Name = "Calculate", Namespace = "https://localhost:44325", Description = "This is The Calculate Web Service")]

    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculateWS : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        [WebMethod]
        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }
        [WebMethod]
        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        [WebMethod]
        public double Divide(double n1, double n2)
        {
            return n1 / n2;
        }


    }
}
