
using System;



class Menu
/*
Displays the menu and gets input from the user
*/
    {
        //Option5 will hold our int which represents our options.
        public int Option5
        { get; set; }

        //Menu
        public void DrawMenu()
        {
            Console.WriteLine("1) Add item to cart.");
            Console.WriteLine("2) Remove item from cart.");
            Console.WriteLine("3) View cart.");
            Console.WriteLine("4) Display Total Price.");
            Console.WriteLine("0) Press to quit.");
        }

        //Get input from user and save it to Option5
        public void Input()
        {
            string UserInput;
            Console.WriteLine("Enter Option: ");
            UserInput = Console.ReadLine();
            if (UserInput == "1")
            {
                Option5 = 1;
            }
            else if (UserInput == "2")
            {
                Option5 = 2;
            }
            else if (UserInput == "3")
            {
                Option5 = 3;
            }
            else if (UserInput == "4")
            {
                Option5 = 4;
            }
            else
            {
                Option5 = 0;
            }
        }
    }
