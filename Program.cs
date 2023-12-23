using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
namespace ToDoTasks;
public class Program
{
    static List<string> tasks = new List<string>();
    public static void Main(String[] args)
    {
    try
    {
            


        while (true)
        {
            System.Console.WriteLine("Welcome to Task Management");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Please select an option");
            System.Console.WriteLine("1.- Add Task");
            System.Console.WriteLine("2.- View Task");
            System.Console.WriteLine("3.- Delete Task");
            System.Console.WriteLine("4.- Exit");

            int OptionSelected = Convert.ToInt16(Console.ReadLine());
        
        switch(OptionSelected)
            {
            case 1:
                AddTask();
            break;

            case 2:
                ViewTask();
            break;

            case 3:
                DeleteTask();
            break;

            case 4:
                System.Console.WriteLine("Exiting....");
            return;

            default:
                System.Console.WriteLine("Invalid Option, Try again.");
            break;
            }
        }
    }
    catch (Exception ex)
    {
            System.Console.WriteLine($"Something went wrong: {ex.Message}");
    }
        
        
    }
    static void AddTask()
    {
        System.Console.WriteLine("Enter the task description");
        string taskDescription = Console.ReadLine();
        tasks.Add(taskDescription);
        System.Console.WriteLine("Task added succefully!");
        Console.Clear();
    }    
    static void ViewTask()
    {
        if(tasks.Count == 0)
        {
            System.Console.WriteLine("No tasks available");
        }
        else{ListTasks();}
    }

    static void DeleteTask()
    {
    ListTasks();

    if (tasks.Count == 0)
    {
        System.Console.WriteLine("No tasks available to delete.");
        return;
    }

    System.Console.WriteLine("Enter the index of the task to remove:");
    if (int.TryParse(Console.ReadLine(), out int taskToRemoveIndex) && taskToRemoveIndex >= 1 && taskToRemoveIndex <= tasks.Count)
    {
        tasks.RemoveAt(taskToRemoveIndex - 1);
        System.Console.WriteLine("Task removed successfully!");
    }
    else
    {
        System.Console.WriteLine("Invalid index. Please enter a valid index to remove a task.");
    }
}


    static void ListTasks()
    {
            System.Console.WriteLine("Task List:");
            for (int i = 0; i < tasks.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}.- {tasks[i]}");
            }
    }
}
