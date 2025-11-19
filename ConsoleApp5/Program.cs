using ConsoleApp5;
using ConsoleApp5.Sender;
using ConsoleApp5.Service;
using ConsoleApp5.Strategy;
using ConsoleApp5.Factory;   // ← 팩토리 추가!!

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== DI + Factory + Strategy ===");

        // ==============================
        // 1) 팩토리로 메시지 전송 객체 생성
        // ==============================
        IMessageSender sender = MessageSenderFactory.Create("Email");
        // IMessageSender sender = MessageSenderFactory.Create("SMS");

        // DI: 서비스들에게 주입
        var orderService = new OrderService(sender);
        var paymentService = new PaymentService(sender);
        var shippingService = new ShippingService(sender);

        orderService.CompleteOrder();
        paymentService.Pay();
        shippingService.Ship();

        Console.WriteLine();

        // ==============================
        // 2) 배송비 전략 (Strategy + DI)
        // ==============================
        IShippingCostStrategy strategy = new NormalShippingStrategy();
        // IShippingCostStrategy strategy = new ExpressShippingStrategy();
        // IShippingCostStrategy strategy = new FreeShippingStrategy();

        var shippingCostService = new ShippingCostService(strategy);
        shippingCostService.PrintCost(15);   // 무게 15kg 기준

        Console.ReadLine();
    }
}
