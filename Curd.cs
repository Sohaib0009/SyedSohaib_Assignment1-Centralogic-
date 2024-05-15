using System;
using System.Collections.Generic;

class Program
{
    static List<Task> tasks = new List<Task>();

    static void Main(string[] args)
    {
        bool exit = false;

        do
        {
            Console.WriteLine("Task List Application\n");
            Console.WriteLine("1. Create a task");
            Console.WriteLine("2. Read tasks");
            Console.WriteLine("3. Update a task");
            Console.WriteLine("4. Delete a task");
            Console.WriteLine("5. Exit\n");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateTask();
                    break;
                case 2:
                    ReadTasks();
                    break;
                case 3:
                    UpdateTask();
                    break;
                case 4:
                    DeleteTask();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

        } while (!exit);
    }

    static void CreateTask()
    {
        Console.WriteLine("Create a Task\n");

        Console.Write("Enter task title: ");
        string title = Console.ReadLine();

        tasks.Add(new Task(title));
        Console.WriteLine("Task created successfully!");
    }

    static void ReadTasks()
    {
        Console.WriteLine("Task List\n");

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found!");
        }
        else
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Title: {task.Title}");
            }
        }
    }

    static void UpdateTask()
    {
        Console.WriteLine("Update a Task\n");

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found!");
            return;
        }

        Console.Write("Enter the title of the task to update: ");
        string title = Console.ReadLine();

        Task taskToUpdate = tasks.Find(t => t.Title == title);

        if (taskToUpdate == null)
        {
            Console.WriteLine("Task not found!");
            return;
        }

        Console.Write("Enter new title for the task: ");
        string newTitle = Console.ReadLine();

        taskToUpdate.Title = newTitle;
        Console.WriteLine("Task updated successfully!");
    }

    static void DeleteTask()
    {
        Console.WriteLine("Delete a Task\n");

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found!");
            return;
        }

        Console.Write("Enter the title of the task to delete: ");
        string title = Console.ReadLine();

        Task taskToDelete = tasks.Find(t => t.Title == title);

        if (taskToDelete == null)
        {
            Console.WriteLine("Task not found!");
            return;
        }

        tasks.Remove(taskToDelete);
        Console.WriteLine("Task deleted successfully!");
    }
}

class Task
{
    public string Title { get; set; }

    public Task(string title)
    {
        Title = title;
    }
}
