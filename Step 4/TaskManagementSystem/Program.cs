using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Schema;

namespace TaskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taskManager = new TaskManager<UserTask>();
            taskManager.AddTask(new UserTask()
            {
                Description = "Buy cheese",
                Category = "Shopping",
                DueDate = DateTime.Now.AddHours(12)
            });

            bool exit = false;
            MenuCreator();
            while (!exit)
            {
                var menuInput = Console.ReadLine();

                if (menuInput is not "1" and not "2" and not "3" and not "4")
                {
                    WrongMenuInput();
                }

                if (menuInput is "1")
                {
                    Console.Write("Enter the task description: ");
                    var taskDescription = Console.ReadLine() ?? String.Empty;

                    Console.Write("Enter the task category: ");
                    var taskCategory = Console.ReadLine() ?? String.Empty;

                    Console.Write("Enter the due date in format yyyy-MM-dd: ");
                    var dueDate = DateTime.Parse(Console.ReadLine() ?? String.Empty);

                    var task = new UserTask()
                    {
                        Description = taskDescription,
                        Category = taskCategory,
                        DueDate = dueDate
                    };

                    taskManager.AddTask(task);
                    taskManager.UpdateQueue();

                    ExitToMenu();
                }

                if (menuInput is "2")
                {
                    Console.Write("Please enter the task ID: ");
                    if (!int.TryParse(Console.ReadLine(), out var taskId))
                    {
                        WrongMenuInput();
                        continue;
                    }

                    var task = taskManager.GetTask(taskId);

                    if(task is null)
                    {
                        Console.WriteLine($"No task with ID = {taskId} exists.");
                        ExitToMenu();
                        continue;
                    }

                    Console.WriteLine("Please select your desired action:\n1. Edit\n2. Delete");
                    var userInput = Console.ReadLine();

                    if (userInput is not "1" and not "2")
                        WrongMenuInput();

                    if (userInput is "1")
                    {
                        Console.Write("Please enter the new description: ");
                        var newDescription = Console.ReadLine() ?? String.Empty;
                        Console.Write("Please enter the new category: ");
                        var newCategory = Console.ReadLine() ?? String.Empty;

                        taskManager.EditTask(task, newDescription, newCategory);

                        ExitToMenu();
                    }

                    if (userInput is "2")
                    {
                        taskManager.RemoveTask(task);

                        ExitToMenu();
                    }
                }

                if (menuInput is "3")
                {
                    taskManager.PrintTasks();
                    ExitToMenu();
                }

                if (menuInput is "4")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nAre you sure? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Press space to confirm, or any other key to return to menu.");

                    var response = Console.ReadKey(true);
                    if (response.Key != ConsoleKey.Spacebar)
                    {
                        MenuCreator();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n\nTake care!");
                        Console.ResetColor();
                        exit = true;
                    }
                }
            }
        }
        static void MenuCreator()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-X- TASK MANAGEMENT SYSTEM -X-\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Add a task to the system");
            Console.WriteLine("2. Update / Delete an existing task");
            Console.WriteLine("3. Show all tasks");
            Console.WriteLine("4. Exit\n");
            Console.Write("Please select an option (1...4) to continue: ");
        }
        static void WrongMenuInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThinking out of the box? You might want to think again!");
            ExitToMenu();
        }
        static void ExitToMenu()
        {
            Console.WriteLine("Press space to return to menu.");

            while (true)
            {
                var response = Console.ReadKey(true);
                if (response.Key == ConsoleKey.Spacebar)
                    break;

                Console.WriteLine("Please press space key, the long one on your keyboard :D");
            }
            MenuCreator();
        }
    }
}
