_**I have Created Three Classes (C# file) which are Item.cs , Inventory.cs and Program.cs the detail explaination as follow.**__

**💡 Item Class:**

Represents individual items in the inventory with properties for ID, Name, Price, and Quantity.
Includes a constructor for initializing item attributes and an overridden ToString method for displaying item details.

**💡 Inventory Class:**

Manages a collection of items using both an array and a list.
The array (itemsArray) is used to store items, and the list (itemsList) is used for dynamic operations.
Methods include adding, displaying, finding, updating, and deleting items.
The AddItem method checks if there is space in the array before adding an item.
The DisplayAllItems method prints all items in the array.
The FindItemByID method uses LINQ to find an item in the list.
The UpdateItem method updates the item's attributes and also updates the item in the array.
The DeleteItem method removes the item from both the list and the array, and shifts the array elements if necessary.

**💡 Program Class:**

Contains the main method with a loop to display a menu and handle user inputs.
Calls appropriate methods in the Inventory class based on user choices.
Includes methods for handling specific operations like adding, finding, updating, and deleting items.
Each method reads input from the user and performs the corresponding action on the inventory.


![inventory1](https://github.com/Sohaib0009/SyedSohaib_DotNet_Assignment_Centralogic/assets/97386434/5b0b4970-e4ec-4bf6-87cc-57929688257b)

![inventory2](https://github.com/Sohaib0009/SyedSohaib_DotNet_Assignment_Centralogic/assets/97386434/d258a026-f34f-483a-b876-b26e9c66b8ea)

![inventory3](https://github.com/Sohaib0009/SyedSohaib_DotNet_Assignment_Centralogic/assets/97386434/03601c32-848e-454d-98ff-47429331894a)
