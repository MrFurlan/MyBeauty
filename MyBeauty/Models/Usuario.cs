﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBeauty.Models
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
        public Cidade Cidade { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}