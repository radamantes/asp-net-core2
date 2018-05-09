﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreViewInjection.Models
{
    public class Estado
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
    }
}
