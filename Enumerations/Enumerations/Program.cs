using Enumerations.Entities;
using System;
using Enumerations.Entities.Enums;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Order.PendingPayment
            };
            
            Console.WriteLine(order);

            //Conversão de String para Enumeração

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //O valor string que vai ser convertido para tipo enum

            Console.WriteLine(os);

        }
    }
}
