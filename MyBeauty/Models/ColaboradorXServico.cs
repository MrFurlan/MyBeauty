using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBeauty.Models
{
    public class ColaboradorXServico
    {
        public Colaboradores Colaborador { get; set; }
        public Servicos Servico { get; set; }
        public double Valor { get; set; }
        public double ValorPromocional { get; set; }
        public double PercentualDesconto { get; set; }
    }
}