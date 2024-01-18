using ConsoleApp1;

class Program
{
    static void Main()
    {
        OrderProcessingFacade orderFacade = new OrderProcessingFacade();

        orderFacade.ProcessOrder();

        Console.ReadLine();
    }
}
