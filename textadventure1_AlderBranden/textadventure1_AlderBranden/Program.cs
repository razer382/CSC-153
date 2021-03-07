/*
 * 2/5/2021
 * CSC 153
 * Branden Alder
 * First iteration of text adventure project. No classes or objects
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textadventure1_AlderBranden
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations of everything
            string choice = "";
            int tempLocation = 0; // used to keep room location
            String[] rooms = { "Entrance", "Secret Passage", "Crypts", "Crypt Exit Room", "???????" };
            String[] weapons = {"Dagger", "Stick", "Sword", "Glowing Blue Sword" };
            String[] potions = { "Minor healing potion", "Major healing potion" };
            String[] treasure = {"Silver ring", "Golden nugget", "Diamond" };
            List<string> items = new List<string>() { "Lantern", "Lantern Fuel", "Lighter", "Butane"};
            List<string> mobs = new List<string>() {"Skeleton", "Skeleton Mage", "Gnome", "Wolf" };

            // Call methods to display title and menu then current room
            titleMethod();
            menuStuff();
            Console.WriteLine("Current room is: " + rooms[tempLocation]);

            //While loop to keep program open 
            while(choice.ToLower() != "exit")
            {
                Console.Write("Choice >> "); // I liked the way you had yours set up so I stole it
                choice = Console.ReadLine();
                switch (choice) //switch for choices 
                {
                    case "room":
                        displayRooms(rooms, "n");
                        Console.WriteLine();
                        break;
                    case "weapons":
                        Array.Sort(weapons);
                        Console.Write("Weapons: ");
                        foreach (string item in weapons)
                        {
                            Console.Write("[" + item + "] ");
                        }
                        break;
                    case "potions":
                        // TODO - ?
                        break;
                    case "treasures":
                        // TODO - ?
                        break;
                    case "items":
                        // TODO - ?
                        break;
                    case "n":
                        tempLocation++;
                        Console.WriteLine("Current room is: " + rooms[tempLocation]);
                        displayRooms(rooms, choice);
                        break;
                    case "s":
                        tempLocation--;
                        displayRooms(rooms, choice);
                        Console.WriteLine("Current room is: " + rooms[tempLocation]);
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default: //If invalid choice is made
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                
            }

        }

        public static void menuStuff()
        {
            //Method for menu to make it cleaner
            Console.WriteLine("1. Display Rooms (room)");
            Console.WriteLine("2. Display Weapon (weapons)");
            Console.WriteLine("3. Display Potion");
            Console.WriteLine("4. Display Treasure");
            Console.WriteLine("5. Display Items");
            Console.WriteLine("6. Display Mobs");
            Console.WriteLine("7. Exit");   
        } 
        public static void titleMethod()
        {     // Title Method
            Console.WriteLine("\tIIIII   RRR    DD     K  K");
            Console.WriteLine("\t  I     R  R   D D    K K");
            Console.WriteLine("\t  I     RRR    D  D   KK");
            Console.WriteLine("\t  I     R R    D D    K K");
            Console.WriteLine("\tIIIII   R  R   DD     K  K");
            Console.WriteLine("---------------------------------------");
        } 

        public static void displayRooms(String[] rooms, string way)
        {       // Display rooms depending on whether you're going north or south
            if (way == "n")
            {
                Console.Write("Rooms: ");
                foreach (string item in rooms)
                {
                    Console.Write("[" + item + "] ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.Write("Rooms: ");
                Array.Reverse(rooms, 0, rooms.Length); // Reverse room array
                foreach (string item in rooms)
                {
                    Console.Write("[" + item + "] ");
                }
                Array.Reverse(rooms, 0, rooms.Length); //re-reverse array
                Console.WriteLine();
            }
        } 
    }
}
