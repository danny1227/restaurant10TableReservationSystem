using System;

/*
 1. Validar si es usuario existente y generar sistema de registro o login.
 2. El programa debe ser capaz de darle 
    la bienvenida a un usuario existente si en efecto existe.
  3. El programa debe buclearse o repetirse hasta que se registren los
    10 comensales.
 */

namespace restaurant10TableReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] {"Pedro","Robert", "Johan", "Jose", "Selena", "Mike", "Dani", "Platz", "Hugo", "" };
            int arrayCurrectIndex = 9;
            bool userType;
            
            Console.WriteLine("Welcome to the restaurant in the word");
            while (arrayCurrectIndex < 10)
            {
                Console.WriteLine("\n \n Are you a registered users? Write true, or write false to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("Hello, you are a registered user, please enter your user name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("User not found,  try again or register");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0}, it's a pleasure to give you found", userNames[index]);
                    }

                }
                else if (userType == false)
                {
                    Console.WriteLine("Please write and remember your user name");
                    userNames[arrayCurrectIndex] = Console.ReadLine();
                    Console.WriteLine("Your user has been saved successfully  \n" +
                        "Your user name is> {0}", userNames[arrayCurrectIndex]);
                    arrayCurrectIndex++;
                }
                

            }

            
            Console.WriteLine("The restaurant if full, try again the next year \n these are the guests to the dinner: ");
            int auxIndex = 0;
            foreach (string item in userNames)
            {
                Console.WriteLine("User number {0}, and user name> {1}", auxIndex+1, userNames[auxIndex]);
                auxIndex++;
            }
            Console.Read();

            Environment.Exit(0);
            
        }
    }
}
