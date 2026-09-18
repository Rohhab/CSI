namespace TaskManagementSystem
{
    internal class UserTask : ITask
    {
        static int _nextId = 1;
        public int ID { get; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime DueDate { get; set; }
        public UserTaskStatus Status { get; set; }
        public UserTask()
        {
            ID = _nextId++;
            Description = string.Empty;
            Category = string.Empty;
            DueDate = DateTime.Now;
            Status = UserTaskStatus.Pending;
        }
    }
}