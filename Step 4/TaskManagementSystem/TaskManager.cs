using System.Diagnostics;
using System.Threading.Channels;

namespace TaskManagementSystem
{
    public class TaskManager<T> where T : ITask
    {
        public List<T> Tasks = [];
        public Dictionary<int, T> TaskDictionary = [];
        public Queue<T> TaskQueue = new();
        public T? GetTask(int id)
        {
            TaskDictionary.TryGetValue(id, out var task);
            return task;
        }
        public void AddTask(T task)
        {
            Tasks.Add(task);
            TaskDictionary.Add(task.ID, task);

            Console.WriteLine($"Task with ID = {task.ID} and description = \"{task.Description}\" added to the system.");
        }
        public void RemoveTask(T task)
        {
            Tasks.Remove(task);
            if (TaskDictionary.TryGetValue(task.ID, out var dictTask))
            {
                dictTask.Status = UserTaskStatus.Deleted;
            }
            
            Console.WriteLine($"Task with ID = {task.ID} removed from the system.");
        }
        public void EditTask(T task, string desc, string cat)
        {
            task.Description = desc;
            task.Category = cat;

            Console.WriteLine($"Task with ID = {task.ID} updated to \"{task.Description}\" and category \"{task.Category}\"");
        }
        public void UpdateQueue()
        {
            foreach (var task in Tasks)
            {
                if (task.Status == UserTaskStatus.Deleted)
                    continue;

                if (task.DueDate <= DateTime.Now.AddDays(1))
                {
                    if (!TaskQueue.Contains(task))
                    {
                        TaskQueue.Enqueue(task);
                        task.Status = UserTaskStatus.InProgress;
                    }
                }
            }
        }
        public void ProcessNextTask()
        {
            if (TaskQueue.Count == 0)
            {
                Console.WriteLine("There are no tasks waiting for processing.");
                return;
            }

            var task = TaskQueue.Dequeue();

            if (task.Status == UserTaskStatus.Deleted)
            {
                Console.WriteLine(
                    $"Task with ID {task.ID} was deleted and will be skipped.");
                return;
            }

            Console.WriteLine(
                $"Processing task with ID {task.ID}: \"{task.Description}\"");

            task.Status = UserTaskStatus.Done;
        }
        public void PrintTasks()
        {
            Console.WriteLine("\n--- TASK LIST ---");

            foreach (var task in Tasks)
            {
                Console.WriteLine(
                    $"ID: {task.ID} | " +
                    $"Category: \"{task.Category}\" | " +
                    $"Description: \"{task.Description}\" | " +
                    $"Due: {task.DueDate} | " +
                    $"Status: {task.Status}");
            }

            Console.WriteLine("\n--- TASK DICTIONARY ---");

            foreach (var kvp in TaskDictionary)
            {
                Console.WriteLine(
                    $"ID: {kvp.Key} | " +
                    $"Category: \"{kvp.Value.Category}\" | " +
                    $"Description: \"{kvp.Value.Description}\" | " +
                    $"Status: {kvp.Value.Status}");
            }

            Console.WriteLine("\n--- TASK QUEUE ---");

            foreach (var task in TaskQueue)
            {
                Console.WriteLine(
                    $"ID: {task.ID} | " +
                    $"Description: \"{task.Description}\" | " +
                    $"Due: {task.DueDate}");
            }
        }
    }
}
