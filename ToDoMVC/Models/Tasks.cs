using System;
using System.Collections.Generic;

namespace ToDoMVC.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
        
        public virtual AspNetUsers UserId { get; set; }
    }
}
