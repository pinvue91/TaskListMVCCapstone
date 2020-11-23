using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoMVC.Models;

namespace ToDoMVC.Controllers
{
    [Authorize]
    public class ToDoMVCController : Controller
    {
        //context field
        private readonly ToDoMVCContext _db;

        //overload Controller's Constructor
        public ToDoMVCController(ToDoMVCContext db)
        {
            this._db = db;
        }

        public IActionResult Users()
        {
            List<AspNetUsers> Users = _db.AspNetUsers.ToList();
            return View(Users);
        }

        public IActionResult CreateTask()
        {
            List<AspNetUsers> users = _db.AspNetUsers.ToList();
            return View(users);
        }

        [HttpPost]
        public IActionResult CreateTask(string UserID, string TaskDescription, DateTime DueDate)
        {
            Tasks t = new Tasks();
            t.UserId = UserID;
            t.User = _db.AspNetUsers.Find(UserID);
            t.TaskDescription = TaskDescription;
            t.DueDate = DueDate;
            t.Completed = false;

            if(ModelState.IsValid)
            {
                _db.Tasks.Add(t);
                _db.SaveChanges();

            }
            

            return RedirectToAction("ViewTasks");
        }

        public IActionResult ViewTasks()
        {
            List<Tasks> tasks = _db.Tasks.ToList();
            return View(tasks);
        }


        [HttpGet]
        public IActionResult EditTask(int Id)
        {
            Tasks task = _db.Tasks.Find(Id);
            return View(task);
        }

        [HttpPost]
        public IActionResult EditTask(Tasks task, string UserId, string TaskDescription, DateTime DueDate, bool Completed)
        {
            task.TaskDescription = TaskDescription;
            task.UserId = UserId;
            task.DueDate = DueDate;
            task.Completed = Completed;
            _db.Tasks.Update(task);
            _db.SaveChanges();
            return View("Index");
        }

        public IActionResult DeleteTask(int Id)
        {
            Tasks task = _db.Tasks.Find(Id);
            return View(task);
        }

        [HttpPost]
        public IActionResult DeleteTask(Tasks task)
        {
            _db.Tasks.Remove(task);
            _db.SaveChanges();
            return View("Index");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
