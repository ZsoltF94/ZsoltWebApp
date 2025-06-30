using System.ComponentModel;
using Microsoft.AspNetCore.Components;
using System.Linq;
using Microsoft.AspNetCore.Components.Web;

namespace ToDoWebApp.Pages
{
    public partial class ToDo : ComponentBase
    {

        protected List<TaskItem> tasks = new();
        protected string newTask = "";
        protected string newDescription = "";
        protected string newPrio = "normal";

        protected string filterStatus = "all";
        protected string prioFilter = "all";

        private TaskItem? draggedTask = null;

        protected void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(newTask))
            {
                TaskItem task = new TaskItem();
                task.TaskName = newTask;
                task.TaskDescription = newDescription;
                task.Prio = newPrio;
                tasks.Add(task);

                newTask = string.Empty;
                newDescription = string.Empty;
            }
        }

        protected void DeleteTask(TaskItem task)
        {
            tasks.Remove(task);
        }

        private void OnDragStart(TaskItem task)
        {
            draggedTask = task;
        }

        private void OnDrop(bool isDoneTarget)
        {
            if (draggedTask != null)
            {
                draggedTask.IsDone = isDoneTarget;
                draggedTask = null;
            }
        }

    

    }
}