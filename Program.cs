using System;
namespace crud
{
    public class Crud
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name.");
                return;
            }
            else
            {
                Console.WriteLine($"Be welcome, {name}!");
                names.Add(name);
            }

            string option;
            do
            {
                Console.WriteLine("\n\nWhat is your will for this application?");
                Console.WriteLine("1. Add a name to the list.");
                Console.WriteLine("2. Remove a name from the list.");
                Console.WriteLine("3. Show the list of names.");
                Console.WriteLine("4. Exit the application.\n\n");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter the name you wanna add:");
                        string nameToAdd = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nameToAdd))
                        {
                            Console.WriteLine("Please enter a valid name.");
                        }
                        else if (names.Contains(nameToAdd))
                        {
                            Console.WriteLine($"Name {nameToAdd} already exists in the list.");
                        }
                        else if (nameToAdd == "0" || nameToAdd == "1" || nameToAdd == "2" || nameToAdd == "3" || nameToAdd == "4" || nameToAdd == "5" || nameToAdd == "6" || nameToAdd == "7" || nameToAdd == "8" || nameToAdd == "9")
                        {
                            Console.WriteLine("You can't add numbers as names.");
                        }
                        else if (nameToAdd.Any(char.IsDigit))
                        {
                            Console.WriteLine("You can't add numbers as names.");
                        }
                        else if (nameToAdd == name)
                        {
                            Console.WriteLine("You can't add your numbers as names.");
                        }
                        else
                        {
                            names.Add(nameToAdd);
                            Console.WriteLine($"\n\nName {nameToAdd} added to the list.");
                        }
                        break;
                    case "2":
                    Console.Clear();
                    Console.WriteLine("List of names:");
                        foreach (string n in names)
                        {
                            Console.WriteLine(n);
                        }
                        Console.WriteLine("Enter the name you wanna remove:");
                        string nameToRemove = Console.ReadLine();
                        Console.Clear();
                        if (string.IsNullOrWhiteSpace(nameToRemove))
                        {
                            Console.WriteLine("Please enter a valid name.");
                        }
                        else if (nameToRemove == name)
                        {
                            Console.WriteLine("You can't remove your own name from the list.");
                        }
                        else if (!names.Contains(nameToRemove))
                        {
                            Console.WriteLine($"\n\nName {nameToRemove} not found in the list.");
                        }
                        else
                        {
                            names.Remove(nameToRemove);
                            Console.WriteLine($"\n\nName {nameToRemove} removed from the list.");
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("List of names:");
                        foreach (string n in names)
                        {
                            Console.WriteLine(n);
                        }
                        break;
                    case "4":
                        Console.WriteLine("Exiting the application.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (option != "4");
        }
    }
}