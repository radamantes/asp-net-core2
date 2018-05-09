using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNCore2Empty.services
{
    public class TextoMensagemService : IMensagemService
    {
        public string GetMensagem()
        {
            return "Texto de GetMensagem - Diego.net";
        }
    }
}
