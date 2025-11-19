using ConsoleApp5.Sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Service
{
    public class PaymentService
    {
        private readonly IMessageSender _sender;

        public PaymentService(IMessageSender sender)
        {
            _sender = sender;
        }

        public void Pay()
        {
            _sender.Send("결제가 완료되었습니다.");
        }
    }
}
