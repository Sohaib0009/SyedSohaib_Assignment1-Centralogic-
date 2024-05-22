using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagementSystem
{
    // The Inventory class manages a collection of items
    public class Inventory
    {
        // Array to store items
        private Item[] itemsArray;
        private int arraySize;
        private int currentIndex;

        // List to manage dynamic operations
        private List<Item> itemsList;

        // Constructor to initialize the inventory with a specified size
        public Inventory(int size)
        {
            arraySize = size;
            itemsArray = new Item[arraySize];
            itemsList = new List<Item>();
            currentIndex = 0;
        }

        // Method to add a new item to the inventory
        public void AddItem(Item item)
        {
            // Check if there is space in the array
            if (currentIndex < arraySize)
            {
                itemsArray[currentIndex] = item;
                itemsList.Add(item);
                currentIndex++;
            }
            else
            {
                Console.WriteLine("Inventory is full. Cannot add more items.");
            }
        }

        // Method to display all items in the inventory
        public void DisplayAllItems()
        {
            // Check if there are any items in the inventory
            if (currentIndex == 0)
            {
                Console.WriteLine("No items in inventory.");
                return;
            }

            // Display each item in the array
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(itemsArray[i]);
            }
        }

        // Method to find an item by its ID
        public Item FindItemByID(int id)
        {
            // Use LINQ to find the item in the list
            return itemsList.FirstOrDefault(item => item.ID == id);
        }

        // Method to update an item's information
        public bool UpdateItem(int id, string newName, decimal newPrice, int newQuantity)
        {
            // Find the item by ID
            Item item = FindItemByID(id);
            if (item == null)
            {
                return false;
            }

            // Update the item's attributes
            item.Name = newName;
            item.Price = newPrice;
            item.Quantity = newQuantity;

            // Update the item in the array as well
            for (int i = 0; i < currentIndex; i++)
            {
                if (itemsArray[i].ID == id)
                {
                    itemsArray[i] = item;
                    break;
                }
            }

            return true;
        }

        // Method to delete an item from the inventory
        public bool DeleteItem(int id)
        {
            // Find the item by ID
            Item item = FindItemByID(id);
            if (item == null)
            {
                return false;
            }

            // Remove the item from the list
            itemsList.Remove(item);

            // Remove the item from the array and shift elements
            int indexToRemove = Array.FindIndex(itemsArray, 0, currentIndex, i => i.ID == id);
            if (indexToRemove >= 0)
            {
                for (int i = indexToRemove; i < currentIndex - 1; i++)
                {
                    itemsArray[i] = itemsArray[i + 1];
                }

                itemsArray[currentIndex - 1] = null;
                currentIndex--;
            }

            return true;
        }
    }
}
