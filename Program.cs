
using Assignment6._1;
using System;
using System.Collections.Generic;

namespace Assignment_6._1
{


    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Problem 1: Singly Linked List of Houses");

            //1. Create the Linked 
            HouseLinkedList houses = new HouseLinkedList();

            //2. Add some houses to the linked list
            houses.AddHouse(1, "53 E Division St, Chicago, IL 60610", "Contemporary", 5, 9);
            houses.AddHouse(2, "42 S Battery St, Charleston SC 29401", "Colonial", 4, 5);
            houses.AddHouse(3, "727 Ashbury St, San Francisco, CA 94117", "Victorian", 5, 6);
            houses.AddHouse(4, "4 Tokeneke Trail, Houston, TX 77024", "Ranch", 5, 8);

            Console.WriteLine("\nAll Houses in the Linked List:");// Display all houses in the linked list
            Console.Write("Enter the house number to search for: ");// Prompt the user to enter a house number to search for
            string input = Console.ReadLine(); // Read the user input

            int searchNumber; // Variable to store the parsed house number
            if (int.TryParse(input, out searchNumber))
            {
                HouseNode found = houses.SearchByNumber(searchNumber); // Search for the house by number

                if (found != null)
                {
                    Console.WriteLine("\nHouse found:"); // If the house is found, display its details
                    Console.WriteLine($"House Number: {found.HouseNumber}");// house number in the linked list
                    Console.WriteLine($"Address: {found.Address}");// address of the house
                    Console.WriteLine($"House Type: {found.HouseType}"); // type of the house
                    Console.WriteLine($"Bedrooms: {found.Bedrooms}"); // number of bedrooms in the house
                    Console.WriteLine($"Bathrooms: {found.Bathrooms}"); // number of bathrooms in the house
                }
                else
                
                {
                    Console.WriteLine("\nHouse not found.");
                }

                Console.WriteLine("\nPress Enter to display all houses in the linked list...");//
                Console.ReadLine(); // Wait for the user to press Enter before displaying all houses
                
                houses.DisplayAll(); // Display all houses in the linked list

                Console.WriteLine("\nPress Enter to exit...");//
                Console.ReadLine(); // Wait for the user to press Enter before displaying all houses

            }

            // PROBLEM 2: lINKED LIST <T> 

            // Display the problem statement for Problem 2
            Console.WriteLine("\nProblem 2: Exploring LinkedList<T> in C#");

            // Create a LinkedList of strings to store names of cities
            LinkedList<string> cities = new LinkedList<string>();

            // Add some cities to the LinkedList
            cities.AddLast("Chicago");
            cities.AddLast("Huston");
            cities.AddLast("San Francisco");
            cities.AddFirst("Charleston"); // Adding a city at the beginning of the LinkedList

            // Display all cities in the LinkedList
            Console.WriteLine("\nCities in the LinkedList:");
            foreach(var city in cities)
            {
                Console.WriteLine(city); //
            }
            // Search for a city in the LinkedList
            var searchCity = "Houston";
            if (cities.Contains(searchCity)) // Check if the LinkedList contains the city
            {
                Console.WriteLine($"\nFound: {searchCity}"); // If the city is found, print a message
            }
            else
            {
                Console.WriteLine($"\n{searchCity} not found.");
            }

            // Remove a city from the LinkedList
            cities.Remove("San Francisco");

            // Display cities after removal
            Console.WriteLine("\nCities after removing 'San Francisco':");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            // PROBLEM 3: Move Zeros

            // Display the problem statement for Problem 3
            Console.WriteLine("\nProblem 3: Move all zeros to the end of the array");

            //
            var nums = new int[] { 0, 1, 0, 3, 12 };// Example input array with zeros and non-zero numbers

            // Display the original array
            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", nums));//

            MoveZeros(nums);//

            // Display the array after moving zeros
            Console.WriteLine("Array after moving zeros:");
            Console.WriteLine(string.Join(", ", nums));


            // Method to move zeros in-place
            static void MoveZeros(int[] nums)
            {
                var insertPos = 0;

                // Move all non-zero numbers to the front
                for (var i = 0; i < nums.Length; i++)
                {
                    // If the current number is not zero, move it to the insert position
                    if (nums[i] != 0) 
                    {
                        // Move the non-zero number to the insert position
                        nums[insertPos] = nums[i];
                        insertPos++;// Move the insert position to the next index
                    }
                }

                // Fill the rest with zeros
                while (insertPos < nums.Length)
                {
                    nums[insertPos] = 0; // Set the current insert position to zero
                    insertPos++;// Move the insert position to the next index
                }
            }








        }










    }








}
    















}
    












