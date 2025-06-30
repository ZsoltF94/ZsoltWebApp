namespace ToDoWebApp
{
    public class TaskItem
    {
        public string TaskName { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;
        public string Prio { get; set; } = "normal";
    }
}