using System;

namespace InventoryManagementSystem
{
    // The Item class represents an individual item in the inventory
    public class Item
    {
        // Properties for ID, Name, Price, and Quantity of the item
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // Constructor to initialize the item attributes
        public Item(int id, string name, decimal price, int quantity)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Override ToString method for better display of item details
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Price: {Price:C}, Quantity: {Quantity}";
        }
    }
}
