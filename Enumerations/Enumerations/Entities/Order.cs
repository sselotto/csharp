using System;
using Enumerations.Entities.Enums;

namespace Enumerations.Entities
{
    class Order
    {
        public static OrderStatus PendingPayment { get; internal set; }
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + "," + Moment + "," + Status;
        }
    }
}
