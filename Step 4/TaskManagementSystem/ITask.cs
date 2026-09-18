namespace TaskManagementSystem
{
    public interface ITask
    {
        int ID { get; }
        string Description { get; set; }
        string Category { get; set; }
        DateTime DueDate { get; set; }
        UserTaskStatus Status { get; set; }
    }
}