using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAO.Models
{
    public class GruposXUsuarios
    {
        public int Codigo { get; set; }
        public GruposDeUsuarios GrupoDeUsuario { get; set; }
        public Usuarios Usuario { get; set; }

    }
}