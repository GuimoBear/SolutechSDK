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
                IdMessage = "000000001",
                Mensagem = "Lorem ipsun",
                Midia = Enums.TipoMidia.Texto,
                UsaEmoji = Enums.UsaEmoji.Nao,
                Whatsapp = "84996251792"
            };
            var response = message.Send();
        }
    }
}
