using System;

class Program
{
    static void Main(string[] args)
    {

        //Creating list of Orders
        List<Order> orders = new List<Order>();

        //Creating the products of ordered by the first customer.
        Product product1 = new Product("Shirt", "A100", 50, 3);
        Product product2 = new Product("Pants", "A101", 75, 4);
        Product product3 = new Product("Tables", "AA00", 120, 6);

        //Creating the address of the first order.
        Address address1 = new Address("221B Baker Street", "London", "Greater London", "United Kingdom");

        //Creating the first customer
        Customer customer1 = new Customer("Clement KINYANGE", address1);

        //Creating the first Order(Order1)
        Order order1 = new Order();
        order1.SetProduct(product1);
        order1.SetProduct(product2);
        order1.SetProduct(product3);

        order1.SetCustomer(customer1);
        //Adding the order1 to the list of orders
        orders.Add(order1);

        //Creating the products of ordered by the second customer
        Product product4 = new Product("Computer", "BB00", 500, 5);
        Product product5 = new Product("TVs", "B501", 250, 2);
        Product product6 = new Product("Cars", "AC00", 5000, 3);

        //Creating the address of the person ordered the second order.
        Address address2 = new Address("123 Main Street", "Springfield", "Illinois", "USA");

        //Creating the first customer
        Customer customer2 = new Customer("Lorld Kyrian", address2);

        //Creating the second Order(Order2)
        Order order2 = new Order();
        order2.SetProduct(product4);
        order2.SetProduct(product5);
        order2.SetProduct(product6);

        order2.SetCustomer(customer2);
        //Adding the order2 to the list of orders
        orders.Add(order2);


        //Displaying the result of each order
        foreach (Order order in orders)
        {
            
            string packingLabels = order.DisplayPackingLabel();
            string[] packs = packingLabels.Split("|");
            foreach(string pack in packs)
            {
                Console.WriteLine(pack.Trim());
            }

            string ship = order.DisplayShippingLabel();
            Console.WriteLine(ship);

            double total = order.ComputeTotal();
            Console.WriteLine($"Total Price: ${total}\n");
        }

    }
}