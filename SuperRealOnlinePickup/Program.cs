using SuperRealOnlinePickup.Model;

namespace SuperRealOnlinePickup;

public class Program
{
    static void Main(string[] args)
    {
        // Creating a customer 

        Customer James = new Customer

        {

            fName = "James", lName = "Alonzo" //uses property to set first and last name

            PhoneNumber = 1234567890 //uses property to set customer phone number

        };



        // Creating an order for the customer 

        Order order = new Order(James);

        order.AddItem("Milk", 2.99m);

        order.AddItem("Bread", 1.99m);

        // Adding more items to the order if needed 



        // Creating a pickup process instance 

        PickupProcess pickupProcess = new PickupProcess();



        // Confirming the order pickup with a specific pickup time and spot 

        pickupProcess.ConfirmOrderPickup(order, DateTime.Now.AddDays(1), "Spot A");
    }
}