using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBeauty.Models
{
    public class Cidades
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CodigoIbge { get; set; }
        public Estados Estado { get; set; }
    }
}