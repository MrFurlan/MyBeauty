using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBeauty.Models
{
    public class GrupoXUsuario
    {
        public int Codigo { get; set; }
        public GrupoDeUsuario GrupoDeUsuario { get; set; }
        public Usuario Usuario { get; set; }

    }
}