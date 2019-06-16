using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Scrum_GTD_ToDo.Models
{
    public class TodoItem
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
        public DateTime Due { get; set; }
    }
}
