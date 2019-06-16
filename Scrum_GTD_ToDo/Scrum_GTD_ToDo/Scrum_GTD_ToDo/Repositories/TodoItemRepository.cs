using System;
using System.Collections.Generic;
using System.Text;
using Scrum_GTD_ToDo.Models;
using System.Threading.Tasks;

namespace Scrum_GTD_ToDo.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {
        public event EventHandler<TodoItem> OnItemAdded;
        public event EventHandler<TodoItem> OnItemUpdated;

        public async Task AddItem(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public async Task AddOrUpdate(TodoItem item)
        {
            if(item.Id == 0)
            {
                await AddItem(item);
            }
            else
            {
                await UpdateItem(item);
            }
            throw new NotImplementedException();
        }

        public async Task<List<TodoItem>> GetItems()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateItem(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
