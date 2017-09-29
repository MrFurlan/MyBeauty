using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace DAO.Controllers
{
    public class EstadosController : Controller
    {
        // GET: Estados
        public ActionResult Index()
        {
            AlunoDAO aluno = new AlunoDAO();

            string teste = "";

            if (aluno.Insert())
            {
                teste = "ok";
            }
            else
            {
                teste = "erro";
            }

            return View();
        }
    }
}