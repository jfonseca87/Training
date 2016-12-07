using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenPop.Pop3;
using OpenPop.Mime;
using CorreosPruebas.Models;

namespace CorreosPruebas.Helpers
{
    public class Mails
    {
        public List<Correos> DescargarCorreos(string hostname, int port, bool UseSsl, string username, string password)
        {
            using (Pop3Client client = new Pop3Client())
            {
                client.Connect(hostname, port, UseSsl);
                client.Authenticate(username, password);

                int messageCount = client.GetMessageCount();

                List<Correos> allMessages = new List<Correos>();

                for (int i = messageCount; i > 0; i--)
                {
                    Message oMessage = client.GetMessage(i);

                    allMessages.Add(
                        new Correos 
                        {
                            Asunto = oMessage.Headers.Subject,
                            Cuerpo = oMessage.MessagePart.GetBodyAsText()
                        }
                    );
                }

                return allMessages;
            }
        }
    }
}