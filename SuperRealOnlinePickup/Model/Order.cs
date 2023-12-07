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

        public int OrderNumber { get; } //declaring order number variable
        public Customer Customer { get; set; } //calling customer variable 
        public DateTime PickupTime { get; set; } //declaring the date and pickup time for customer order
        public int Quanity {  get; set; } //declaring quantity in customer order

        public List<OrderItem> Items { get; } = new List<OrderItem> (); //list of customer ordered items 

        public Order(Customer customer) //constructor of customer to call the order number 
        {
            OrderNumber = nextOrderNumber++; //add 1 every new order number 
            Customer = customer;
        }
        
        public void AddItem(string itemName, decimal price) //adding item with  name and price as a decimal 
        {
            Items.Add(new OrderItem { ItemName = itemName, Price = price });
        }


    }
}
