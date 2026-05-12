using System;

namespace Assignment6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Assignment 6.1 - House Linked List =====");
            Console.WriteLine();

            // Create the linked list
            HouseLinkedList houseList = new HouseLinkedList();

            // Add houses to the linked list
            houseList.AddHouse(101, "123 Maple St", "Ranch", 3, 2);
            houseList.AddHouse(202, "456 Oak Ave", "Colonial", 4, 3);
            houseList.AddHouse(303, "789 Pine Rd", "Victorian", 5, 4);
            houseList.AddHouse(404, "321 Elm Blvd", "Contemporary", 2, 1);
            houseList.AddHouse(505, "654 Cedar Ln", "Ranch", 3, 2);

            // Display all houses
            Console.WriteLine("--- All Houses in the List ---");
            houseList.DisplayAll();
            Console.WriteLine();

            // Search for a house by number
            Console.WriteLine("--- Search for House #303 ---");
            HouseNode found = houseList.SearchByNumber(303);
            if (found != null)
            {
                Console.WriteLine($"Found: House #{found.HouseNumber} at {found.Address} - " +
                                  $"Type: {found.HouseType}, Beds: {found.Bedrooms}, Baths: {found.Bathrooms}");
            }
            else
            {
                Console.WriteLine("House not found.");
            }

            Console.WriteLine();

            // Search for a house that doesn't exist
            Console.WriteLine("--- Search for House #999 ---");
            HouseNode notFound = houseList.SearchByNumber(999);
            if (notFound != null)
            {
                Console.WriteLine($"Found: House #{notFound.HouseNumber}");
            }
            else
            {
                Console.WriteLine("House not found.");
            }

            Console.WriteLine();
            Console.WriteLine("===== Program Complete =====");
            Console.ReadLine();
        }
    }
}
