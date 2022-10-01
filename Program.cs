using System;


    class Program
    {
        //Main
        static void Main(string[] args)
        {
            //create a shopping cart object.
            Cart ShoppingCart = new Cart();
            //Set starter value for do while loop
            int i = 999;
            do
            {
            //Create an object of Menu so we can display and get input.
            Menu DisplayMenu = new Menu();
            //Display Menu
            DisplayMenu.DrawMenu();
            //Get input
            DisplayMenu.Input();
            //Get input from variable option5 and save it to Choice.
            int Choice = DisplayMenu.Option5;
            //if statement that will break our while loop.
            if (Choice <= 0 || Choice >= 5)
            {
                i = 0;
            }
            //Add Product to list
            else if (Choice == 1)
            {
            //Initialize name and price.
            string aName;
            double aPrice;
            //Prompt for input
            Console.WriteLine("What is the name of the product? ");
            aName = Console.ReadLine();

            Console.WriteLine("What is the price of the product? ");
            aPrice = double.Parse(Console.ReadLine());
            // Create a addProduct object from products
            Products addProduct = new Products(aName, aPrice);
            //Add "addProduct" object to list in shopping cart object.
            ShoppingCart.ProductList.Add(addProduct);
            }
            //Remove item from cart
            else if (Choice == 2)
            {
                int remove;
                Console.WriteLine("Which item would you like to remove? (enter the number): ");
                remove = int.Parse(Console.ReadLine());
                //Minus 1 to match index
                remove -= 1;
                //Remove based on index from shoppingcart object's list
                ShoppingCart.ProductList.RemoveAt(remove);
            }
            //Get total price of cart
            else if (Choice == 4)
            {
            //Call public method from shoppingCart object.
            double total = ShoppingCart.Total();
            //display
            Console.WriteLine("===============================");
            Console.WriteLine("The Total price is: $"+total);
            Console.WriteLine("===============================");
            }
            //View the Cart
            else if (Choice == 3)
            {
                Console.WriteLine("===============================");
                //Count represents visible "id" when viewing cart. (so they know how to remove items)
                int count = 0;
            foreach(Products io in ShoppingCart.ProductList)
            {
                count += 1;
                Console.WriteLine($"#{count} Item:{io.ProductName} Price:${((decimal)io.Price)}");
                Console.WriteLine("===============================");   
            }
            }
            }
            //While user input does not equal 0 loop.
            while (i != 0);
        }
    }
