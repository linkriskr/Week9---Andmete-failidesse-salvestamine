using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\SAMPLES\shoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add an item to shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item:");
                    string userItem = Console.ReadLine();
                    myShoppingList.Add(userItem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            }

            Console.Clear();

            foreach (string item in myShoppingList)
            {
                Console.WriteLine($"Your item: {item}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
