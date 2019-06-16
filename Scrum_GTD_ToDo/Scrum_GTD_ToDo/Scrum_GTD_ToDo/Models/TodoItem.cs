using System;
using System.Collections.Generic;
using System.Text;

namespace Scrum_GTD_ToDo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
        public DateTime Due { get; set; }
    }
}
