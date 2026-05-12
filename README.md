# Rovy-Assignment-6.1

## MSSA CAD Program - Module 6: Assignment 6.1
### House Linked List - C# Data Structures

**Student:** brovy23-GD  
**Language:** C#  
**Concept:** Singly Linked List Implementation

---

## Overview

This assignment demonstrates a custom singly linked list built in C# to manage a collection of house objects. Each node in the list stores house data and a reference to the next node.

## Files

| File | Description |
|------|-------------|
| `HouseNode.cs` | Defines the `HouseNode` class - each node stores house data and a `Next` pointer |
| `HouseLinkedList.cs` | Defines the `HouseLinkedList` class with `AddHouse()`, `SearchByNumber()`, and `DisplayAll()` methods |
| `Program.cs` | Entry point - creates the linked list, adds houses, and demonstrates search functionality |

## Key Concepts Demonstrated

- **Linked List Structure:** Nodes connected via `Next` references
- **Traversal:** Iterating from `Head` through the list
- **Search:** Linear search by house number (O(n))
- **AddHouse:** Appending to the end of the list
- **DisplayAll:** Printing all nodes in order

## HouseNode Properties

- `HouseNumber` (int)
- `Address` (string)
- `HouseType` (string) - Ranch, Colonial, Victorian, Contemporary
- `Bedrooms` (int)
- `Bathrooms` (int)
- `Next` (HouseNode) - pointer to next node

## How to Run

1. Open in Visual Studio
2. Build the solution
3. Run `Program.cs` - output shows all houses and search results
