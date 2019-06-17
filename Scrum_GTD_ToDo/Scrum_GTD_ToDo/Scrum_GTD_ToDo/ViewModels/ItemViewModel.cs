using System;
using System.Collections.Generic;
using System.Text;
using Scrum_GTD_ToDo.Repositories;
using Scrum_GTD_ToDo.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace Scrum_GTD_ToDo.ViewModels
{
    public class ItemViewModel:ViewModel
    {
        private TodoItemRepository repository;
        public ItemViewModel(TodoItemRepository repository)
        {
            this.repository = repository;
        }
    }
}
