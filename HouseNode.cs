using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6._1
{
    public class HouseNode
    {
        public int HouseNumber { get; set; }   // The house number
        public string Address { get; set; }    // The address of the house
        public string HouseType { get; set; } // The type of the house
        public int Bedrooms { get; set; }      // The number of bedrooms in the house
        public int Bathrooms { get; set; }     // The number of bathrooms in the house
        public HouseNode Next { get; set; }    // Reference to the next house in the linked list
    }
}
