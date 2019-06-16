﻿using System;
using System.Collections.Generic;
using System.Text;
using Scrum_GTD_ToDo.Models;
using System.Threading.Tasks;
using SQLite;
using System.IO;
namespace Scrum_GTD_ToDo.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private SQLiteAsyncConnection connection;
        public event EventHandler<TodoItem> OnItemAdded;
        public event EventHandler<TodoItem> OnItemUpdated;
        private async Task CreateConnection()
        {
            if(connection !=null)
            {
                return;
            }
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var databasePath = Path.Combine(documentPath, "TodoItems.db");

            connection = new SQLiteAsyncConnection(databasePath);
            await connection.CreateTableAsync<TodoItem>();
            if (await connection.Table<TodoItem>().CountAsync() == 0) 
            {
                await connection.InsertAsync(new TodoItem() { Title = "Welcome to the best GTD System" });
            }
        }
        public async Task AddItem(TodoItem item)
        {
            await CreateConnection();
            await connection.InsertAsync(item);
            OnItemAdded?.Invoke(this, item);
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
        }

        public async Task<List<TodoItem>> GetItems()
        {
            await CreateConnection();
            return await connection.Table<TodoItem>().ToListAsync();
        }

        public async Task UpdateItem(TodoItem item)
        {
            await CreateConnection();
            await connection.UpdateAsync(item);
            OnItemUpdated?.Invoke(this, item);
        }
    }

}
