using ASPNetCoreViewInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreViewInjection.Services
{
    public class EstadosServices
    {
        public List<Estado> getEstados()
        {
            return new List<Estado>()
            {
                new Estado("São Paulo","SP"),
                new Estado("Minas Gerais","MG"),
                new Estado("Rio de Janeiro","MG")
            };
        }
    }
}
