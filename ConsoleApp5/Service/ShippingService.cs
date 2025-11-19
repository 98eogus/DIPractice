using ConsoleApp5.Sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Service
{
    public class ShippingService
    {
        private readonly IMessageSender _sender;

        public ShippingService(IMessageSender sender)
        {
            _sender = sender;
        }

        public void Ship()
        {
            _sender.Send("배송이 시작되었습니다.");
        }
    }
}
