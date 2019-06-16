using Scrum_GTD_ToDo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scrum_GTD_ToDo.ViewModel
{
    public class TodoItemViewModel:ViewModel
    {
        public TodoItemViewModel(TodoItem item) => Item = item;
        public event EventHandler ItemStatusChanged;
        public TodoItem Item { get; private set; }
        public string StatusText => Item.Completed ? "Reactiveate" : "Completed"; //Todo: Understand

    }
}
