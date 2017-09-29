using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAO.Models
{
    public class Agendamentos
    {
        public ColaboradorXServico EstabelecimentoXColaboradorXServico { get; set; }
        public DateTime DataEHora { get; set; }
    }
}