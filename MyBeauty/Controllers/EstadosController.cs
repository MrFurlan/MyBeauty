using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oracle.DataAccess.Client;
//using System.Data.OracleClient;


namespace MyBeauty.Controllers
{
    public class EstadosController : Controller
    {
        OracleConnection conn = new OracleConnection("Database=Aula;DataSource=Oracle10g;ServerVersion=XE;Integrated Security=yes");
        //OracleConnection conn = new OracleConnection("Provider=OraOLEDB.Oracle;DataSource=Oracle10g;UserId=system;Password=Mrf150195;OLEDB.NET=True;SPPrmsLOB=False;NDatatype=False;SPPrmsLOB=False;");
        //OracleConnection conn = new OracleConnection("Data Source=Oracle10g;Integrated Security=no");
        // GET: Estados
        public ActionResult Index()
        {
            try
            {
                conn.Open();
                string teste = "";
                teste = "conectado";
            }
            catch
            {
                string teste = "";
                teste = "erro";
            }

            return View();
        }
    }
}