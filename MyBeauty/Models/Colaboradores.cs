using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBeauty.Models
{
    public class Colaboradores
    {
        public int Codigo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public Estabelecimentos Estabelecimento { get; set; }
    }
}