using System.Collections.Generic;
using System.Linq;

namespace ObjectCalisthenics._09_NoGettersSettersProperties
{
    public class NoGettersSettersProperties
    {

        public class PedidoService
        {
            public void ProcessOrder()
            {
                var order = new Order();
                order.Total = 80.01M;

                //var order2 = new OrderRefactored();
                //order2.Total = 80.01M;
            }
        }

        public class Order
        {
            public int Id { get; set; }
            public decimal Total { get; set; }
            public List<OrderItem> Items { get; set; }
        }

        public class OrderItem
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
        }

        //Refactoring
        public class OrderRefactored
        {
            public int Id { get; private set; }
            public decimal Total { get; private set; }
            public List<OrderItemRefactored> Items { get; private set; }

            public void CalcularValorPedido()
            {
                Total = Items.Sum(p => p.CalculateValue());
            }
        }

        public class OrderItemRefactored
        {
            public string ProductName { get; private set; }
            public int Quantity { get; private set; }
            public decimal Price { get; private set; }

            public OrderItemRefactored(string productName, int quantity, decimal price)
            {
                ProductName = productName;
                Quantity = quantity;
                Price = price;
            }

            internal decimal CalculateValue()
            {
                return Quantity * Price;
            }
        }
    }
}
