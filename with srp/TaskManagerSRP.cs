public class TaskManagerSRP
{

        public void CreateTask(string taskName)
    {
        Console.WriteLine($"Task '{taskName}' has been created successfully.");
    }   

    public void UpdateTask(int taskId, string newTaskName)
    {
        Console.WriteLine($"Task {taskId} has been updated to '{newTaskName}'.");
    }

    public void DeleteTask(int taskId)
    {
        Console.WriteLine($"Task {taskId} has been deleted successfully.");
    }

}

