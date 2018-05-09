using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNCore2Empty.services
{
    public class ConfigurationMensagemService : IMensagemService
    {
        private IConfiguration _config;
        public ConfigurationMensagemService(IConfiguration config)
        {
            _config = config;
        }

        public string GetMensagem()
        {
            return _config["Mensagem"];
        }
    }
}
