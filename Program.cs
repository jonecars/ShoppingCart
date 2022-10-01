using System;


    class Program
    {
        //Main
        static void Main(string[] args)
        {
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
            else if (Choice == 1)
            {
            string aName;
            double aPrice;
            Console.WriteLine("What is the name of the product? ");
            aName = Console.ReadLine();

            Console.WriteLine("What is the price of the product? ");
            aPrice = double.Parse(Console.ReadLine());

            Products addProduct = new Products(aName, aPrice);
            ShoppingCart.ProductList.Add(addProduct);
            }
            else if (Choice == 2)
            {
                int remove;
                Console.WriteLine("Which item would you like to remove? (enter the number): ");
                remove = int.Parse(Console.ReadLine());
                remove -= 1;
                ShoppingCart.ProductList.RemoveAt(remove);
            }
            else if (Choice == 4)
            {
            double total = ShoppingCart.Total();
            Console.WriteLine("===============================");
            Console.WriteLine("The Total price is: $"+total);
            Console.WriteLine("===============================");
            }
            else if (Choice == 3)
            {
                Console.WriteLine("===============================");
                int count = 0;
            foreach(Products io in ShoppingCart.ProductList)
            {
                count += 1;
                Console.WriteLine($"#{count} Item:{io.ProductName} Price:${((decimal)io.Price)}");
                Console.WriteLine("===============================");   
            }
            }
            }
            while (i != 0);
        }
    }
