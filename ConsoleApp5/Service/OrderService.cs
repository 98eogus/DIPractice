using ConsoleApp5.Sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Service
{
    public class OrderService
    {
        private readonly IMessageSender _sender;

        public OrderService(IMessageSender sender)   // DI(의존성 주입)
        {
            _sender = sender;
        }

        public void CompleteOrder()
        {
            _sender.Send("주문이 완료되었습니다.");
        }
    }
}
