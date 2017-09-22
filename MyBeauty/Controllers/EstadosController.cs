using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oracle.DataAccess.Client;


namespace MyBeauty.Controllers
{
    public class EstadosController : Controller
    {
        //OracleConnection conn = new OracleConnection("DATA SOURCE=AULA;PASSWORD=Mrf150195;USER ID=system");
        OracleConnection conn = new OracleConnection("Data Source=Oracle10i;Integrated Security=yes");
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