using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6._1
{
    public class HouseLinkedList
    {
        public HouseNode Head { get; set; }  // First house in the linked list

        // Adds a new house to the end of the linked list
        public void AddHouse(int number, string address, string type, int bedrooms, int bathrooms)
        {
            HouseNode newHouse = new HouseNode
            {
                HouseNumber = number,   // The house number
                Address = address,      // The address of the house
                HouseType = type,       // The type of the house: Ranch, Colonial, Victorian, Contemporary
                Bedrooms = bedrooms,    // The number of bedrooms in the house
                Bathrooms = bathrooms,  // The number of bathrooms in the house
                Next = null
            };

            // If the linked list is empty, set the new house as the head
            if (Head == null)
            {
                Head = newHouse;
                return;
            }

            // Otherwise, find the last house in the linked list and add the new house there
            HouseNode current = Head;
            while (current.Next != null)  // While there is a next house in the linked list
            {
                current = current.Next;
            }
            current.Next = newHouse;  // New house is added to the end of the linked list
        }

        // Searches for a house by its house number
        public HouseNode SearchByNumber(int number)
        {
            HouseNode current = Head;  // Start with head of linked list
            while (current != null)    // While there is a house in the LL
            {
                if (current.HouseNumber == number)  // If the current house number matches the search number
                {
                    return current;  // Found the house, return it
                }
                current = current.Next;  // Move to the next house in the linked list
            }
            return null;  // House not found
        }

        // Displays all houses in the linked list
        public void DisplayAll()
        {
            if (Head == null)  // If the list is empty
            {
                Console.WriteLine("No houses in the list.");  // Print message
                return;  // Exit method
            }

            var current = Head;  // Start with head of linked list
            while (current != null)  // While there is a house in the linked list
            {
                Console.WriteLine($"House Number: {current.HouseNumber}, Address: {current.Address}, " +
                                  $"Type: {current.HouseType}, Bedrooms: {current.Bedrooms}, " +
                                  $"Bathrooms: {current.Bathrooms}");  // Print house details
                current = current.Next;  // Move to the next house in the linked list
            }
        }
    }
}
