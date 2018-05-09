using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreViewInjection.Services
{
    public class TimesServices
    {
        public List<string> getTimes()
        {
            return new List<string>() { "Cruzeiro", "São Paulo", "Flamento", "Juventude" };
        }
    }
}
