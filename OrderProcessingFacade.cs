using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderProcessingFacade
    {
        private InventoryManager inventoryManager;
        private PaymentProcessor paymentProcessor;
        private OrderConfirmationSender confirmationSender;

        public OrderProcessingFacade()
        {
            inventoryManager = new InventoryManager();
            paymentProcessor = new PaymentProcessor();
            confirmationSender = new OrderConfirmationSender();
        }

        public void ProcessOrder()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string product = Console.ReadLine();

            Console.Write("Ingrese la cantidad: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el método de pago: ");
            string paymentMethod = Console.ReadLine();

            Console.Write("Ingrese el monto: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese su correo electrónico: ");
            string email = Console.ReadLine();

            // Actualizar inventario
            inventoryManager.UpdateInventory(product, quantity);

            // Procesar pago
            paymentProcessor.ProcessPayment(paymentMethod, amount);

            // Enviar confirmación de pedido
            confirmationSender.SendConfirmation(email);

            Console.WriteLine("Pedido procesado exitosamente.");
        }
    }

}
