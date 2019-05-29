using SolutechSDK.Requests;
using System;

namespace SolutechSDK.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new APIConfig("guigui2004@gmail.com", "lkfjkldsfjklskljdsl", "00001");
            var message = new SendMessageRequest(config)
            {
                IdMessage = "fdklhsjdfhjk",
                Mensagem = "Lorem ipsun",
                Midia = Enums.TipoMidia.Texto,
                UsaEmoji = Enums.UsaEmoji.Nao,
                Whatsapp = "dfkçjsdkfjkjsdlhflds"
            };
            var response = message.Send();
        }
    }
}
