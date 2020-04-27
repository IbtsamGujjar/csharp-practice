using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public interface ITaskRepository
    {
        Task GetTask(int id);
        IEnumerable<Task> GetTasks();
        Task Add(Task task);
        Task Update(Task task);
        Task Delete(int id);
        IEnumerable<Task> Search(string searchString);

    }
}
