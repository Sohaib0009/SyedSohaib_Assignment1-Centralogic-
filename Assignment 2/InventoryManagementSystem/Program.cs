using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize inventory with a size of 100
            Inventory inventory = new Inventory(100);

            // Main menu loop
            while (true)
            {
                // Display the menu options
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Display All Items");
                Console.WriteLine("3. Find Item by ID");
                Console.WriteLine("4. Update Item");
                Console.WriteLine("5. Delete Item");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                // Read user input
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                    continue;
                }

                // Handle the user's choice
                switch (choice)
                {
                    case 1:
                        AddNewItem(inventory);
                        break;
                    case 2:
                        inventory.DisplayAllItems();
                        break;
                    case 3:
                        FindItemByID(inventory);
                        break;
                    case 4:
                        UpdateExistingItem(inventory);
                        break;
                    case 5:
                        DeleteItem(inventory);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 6.");
                        break;
                }
            }
        }

        // Method to add a new item to the inventory
        static void AddNewItem(Inventory inventory)
        {
            // Read item details from user
            Console.Write("Enter item ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter item name: ");
            string name = Console.ReadLine();

            Console.Write("Enter item price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter item quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            // Create a new item and add it to the inventory
            Item newItem = new Item(id, name, price, quantity);
            inventory.AddItem(newItem);
            Console.WriteLine("Item added successfully.");
        }

        // Method to find an item by ID and display its details
        static void FindItemByID(Inventory inventory)
        {
            // Read item ID from user
            Console.Write("Enter item ID: ");
            int id = int.Parse(Console.ReadLine());

            // Find the item in the inventory
            Item item = inventory.FindItemByID(id);
            if (item != null)
            {
                Console.WriteLine("Item found: " + item);
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        // Method to update an existing item in the inventory
        static void UpdateExistingItem(Inventory inventory)
        {
            // Read item ID from user
            Console.Write("Enter item ID to update: ");
            int id = int.Parse(Console.ReadLine());

            // Read new details for the item
            Console.Write("Enter new item name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter new item price: ");
            decimal newPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Enter new item quantity: ");
            int newQuantity = int.Parse(Console.ReadLine());

            // Update the item in the inventory
            bool updated = inventory.UpdateItem(id, newName, newPrice, newQuantity);
            if (updated)
            {
                Console.WriteLine("Item updated successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        // Method to delete an item from the inventory
        static void DeleteItem(Inventory inventory)
        {
            // Read item ID from user
            Console.Write("Enter item ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            // Delete the item from the inventory
            bool deleted = inventory.DeleteItem(id);
            if (deleted)
            {
                Console.WriteLine("Item deleted successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
    }
}
