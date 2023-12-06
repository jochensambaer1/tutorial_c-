using System;
using System.Collections.Generic;

class Program
{
    static void Main()

    
    {
            {
                List<string> taskList = new List<string>();

                while (true)
                {
                    Console.WriteLine("Enter a task (or 'exit' to quit):");
                    string task = Console.ReadLine();

                    if (task.ToLower() == "exit")
                        break;

                    taskList.Add(task);
                }

                Console.WriteLine("Task List:");
                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {taskList[i]}");
                }

                while (true)
                {
                    Console.WriteLine("Enter the number of the task to remove, 'add' to add a task, or 'exit' to quit:");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                        break;

                    if (input.ToLower() == "add")
                    {
                        Console.WriteLine("Enter a task to add:");
                        string task = Console.ReadLine();
                        taskList.Add(task);
                        Console.WriteLine("Task added successfully.");
                    }
                    else if (int.TryParse(input, out int taskNumber) && taskNumber >= 1 && taskNumber <= taskList.Count)
                    {
                        taskList.RemoveAt(taskNumber - 1);
                        Console.WriteLine("Task removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }

                    Console.WriteLine("Updated Task List:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {taskList[i]}");
                    }
                }
            }
        }
}
