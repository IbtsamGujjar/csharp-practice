using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskManager.Models
{
    public class MockTaskRepository : ITaskRepository
    {
        private readonly List<Task> _tasks;

        public MockTaskRepository()
        {
            _tasks = new List<Task>()
            {
                new Task()
                {
                    Id = 1,
                    Title = "CRUD",
                    Description = "Implement basic create read update delete operations",
                    Priorty = TaskPriorty.High,
                    Status = TaskStatus.InProgress
                },
                new Task()
                {
                    Id = 2,
                    Title = "Database",
                    Description = "Setup database using entity framework",
                    Priorty = TaskPriorty.Medium,
                    Status = TaskStatus.Open
                },
            };
        }
        public Task Add(Task task)
        {
            task.Id = _tasks.Count() > 0 ? _tasks.Max(t => t.Id) + 1 : 1;
            _tasks.Add(task);
            return task;
        }

        public Task Delete(int id)
        {
            Task task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
            return task;
        }

        public Task GetTask(int id)
        {
            Task task = _tasks.FirstOrDefault(t => t.Id == id);
            return task;
        }

        public IEnumerable<Task> GetTasks()
        {
            return _tasks;
        }

        public IEnumerable<Task> Search(string searchString)
        {
            return _tasks.FindAll(t => t.Title.ToLower().Contains(searchString.ToLower()));
        }

        public Task Update(Task taskUpdates)
        {
            Task task = _tasks.FirstOrDefault(t => t.Id == taskUpdates.Id);
            if (task != null)
            {
                task.Title = taskUpdates.Title;
                task.Description = taskUpdates.Description;
                task.Priorty = taskUpdates.Priorty;
                task.Status = taskUpdates.Status;
            }
            return task;
        }
    }
}
