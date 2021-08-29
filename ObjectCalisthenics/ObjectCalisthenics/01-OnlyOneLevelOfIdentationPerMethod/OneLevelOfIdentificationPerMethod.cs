using System.Collections.Generic;

namespace ObjectCalisthenics._01_OnlyOneLevelOfIdentationPerMethod
{
    public class OneLevelOfIdentificationPerMethod
    {
        public class OrderService
        {
            public void ProcessOrders(List<Order> orders)
            {
                foreach (var order in orders)
                {
                    //Implement Logic

                    foreach (var item in order.Items)
                    {
                        if (item.Value > 0)
                        {
                            //More logic
                        }
                    }
                }
            }

            //Refactoriing
            public void ProcessOrdersRefactored(List<Order> orders)
            {
                foreach (var order in orders)
                {
                    //Implement Logic

                    ProcessOrder(order);
                }
            }

            private static void ProcessOrder(Order order)
            {
                foreach (var item in order.Items)
                {
                    ProcessItem(item);
                }
            }

            private static void ProcessItem(Item item)
            {
                if (item.Value > 0)
                {
                    //More logic
                }
            }
        }
    }

    public class Order
    {
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
