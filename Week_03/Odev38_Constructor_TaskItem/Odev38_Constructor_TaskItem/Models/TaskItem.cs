namespace Odev38_Constructor_TaskItem.Models
{

    public class TaskItem
    {
        public string Title { get; set; }
        public string AssignedTo { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string title, string assignedTo, DateTime dueDate)
        {
            Title = title;
            AssignedTo = assignedTo;
            DueDate = dueDate;
            Priority = "Normal";
        }
        public TaskItem(string title, string assignedTo, DateTime dueDate, string priority)
        {
            Title = title;
            AssignedTo = assignedTo;
            DueDate = dueDate;
            Priority = priority;
        }



    }
}