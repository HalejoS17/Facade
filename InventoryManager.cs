using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InventoryManager
    {
        public void UpdateInventory(string product, int quantity)
        {
            Console.WriteLine($"Actualizando inventario - Producto: {product}, Cantidad: {quantity}");
        }
    }

    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentMethod, decimal amount)
        {
            Console.WriteLine($"Procesando pago - Método: {paymentMethod}, Monto: {amount}");
        }
    }

    public class OrderConfirmationSender
    {
        public void SendConfirmation(string email)
        {
            Console.WriteLine($"Enviando confirmación de pedido a {email}");
        }
    }

}
