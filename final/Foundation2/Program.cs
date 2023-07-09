
        // Products
        Product product1 = new Product("Money", "M123", 10, 1);
        Product product2 = new Product("Power", "P123", 20, 2);
        Product product3 = new Product("Fame", "F123", 30, 3);
        Product product4 = new Product("Drug from God", "GD123", 1000000, 1 ); // Drug from God is a song, don't @me ok it's were the money power fame things comes from. I was listoining to it when I made this. (OuO)

        // adressses 
        Address address1 = new Address("1st 2ed West", "Rexburg", "ID", "USA");
        Address address2 = new Address("843 woodcock Road", "Dunlap", "TN", "Not USA becease I need a none USA adress LOL");

        Customer customer1 = new Customer("Your mom", address1);
        Customer customer2 = new Customer("Myself", address2);

        // Order1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        // order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Call everything 
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        

        Console.WriteLine("Order 1 Total Cost:");
        Console.WriteLine(order1.CalculateTotalCost());
        

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
       

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        

        Console.WriteLine("Order 2 Total Cost:");
        Console.WriteLine(order2.CalculateTotalCost());
    

