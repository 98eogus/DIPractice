using ConsoleApp5.Sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Factory
{
    public static class MessageSenderFactory
    {
        public static IMessageSender Create(string type)
        {
            return type switch
            {
                "Email" => new EmailSender(),
                "SMS" => new SmsSender(),
                _ => throw new Exception("지원하지 않는 메시지 타입입니다.")
            };
        }
    }

}
