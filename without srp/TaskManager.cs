public class TaskManager
{
    public string ConnectToAPI()
    {
        return "Connected to API succesfully!";
    }

    public void CreateTask(string taskName)
    {
        Console.WriteLine($"Task {taskName} has been created successfully.");
    }

    public void UpdateTask(int taskId, string newTaskName)
    {
        Console.WriteLine($"Task {taskId} has been updated to {newTaskName}.");
    }

    public void DeleteTask(int taskId)
    {
        Console.WriteLine($"Task {taskId} has been deleted successfully.");
    }

    public void SendNotification(string message)
    {
        Console.WriteLine($"Notification sent: {message}");
    }

    public void GenerateReport()
    {
        Console.WriteLine("Report has been generated successfully!");
    }
}


