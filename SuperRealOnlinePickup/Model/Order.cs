using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRealOnlinePickup.Model
{
    public class Order
    {
        private static int nextOrderNumber = 1;

        public int OrderNumber { get; }
        public Customer Customer { get; set; }
        public string PickupTime { get; set; }
        public int Quanity {  get; set; }

        public List<Inventory> Item { get; } = new List<Inventory> ();

        public Order(Customer customer, List<Inventory> x)
        {
            OrderNumber = nextOrderNumber++;
            Customer = customer;
        }

    }
}
