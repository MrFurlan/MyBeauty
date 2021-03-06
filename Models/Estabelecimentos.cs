﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAO.Models
{
    public class Estabelecimentos
    {
        public int Codigo { get; set; }
        public string CpfCnpj { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public Cidades Cidade { get; set; }
        public string DddTelefone { get; set; }
        public string Telefone { get; set; }
        public string DddCelular { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}