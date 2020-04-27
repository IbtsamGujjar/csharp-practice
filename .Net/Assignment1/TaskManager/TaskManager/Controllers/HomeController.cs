using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskRepository _taskRepository;

        public HomeController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public ViewResult Index(string search)
        {
            if (search != null)
            {
                var modeldata = _taskRepository.Search(search);
                return View(modeldata);
            }
            var model = _taskRepository.GetTasks();
            return View(model);
        }
        public ViewResult Details(int? id)
        {
            Task model = _taskRepository.GetTask(id ?? 1);
            return View(model);

        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                Task newTask = _taskRepository.Add(task);
                return RedirectToAction("Details", new { Id = newTask.Id });
            }
            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Task model = _taskRepository.GetTask(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                Task newTask = _taskRepository.Update(task);
                return RedirectToAction("Details", new { Id = newTask.Id });
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Task task = _taskRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
