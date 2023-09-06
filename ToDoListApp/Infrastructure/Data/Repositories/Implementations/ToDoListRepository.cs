using Microsoft.EntityFrameworkCore;
using ToDoListApp.Domain.Models;
using ToDoListApp.Infrastructure.Data.Contexts;
using ToDoListApp.Infrastructure.Data.Repositories.Interfaces;

namespace ToDoListApp.Infrastructure.Data.Repositories.Implementations
{
    public class ToDoListRepository : IToDoListRepository
    {

        private readonly MySQLContext _mySQLContext;

        public ToDoListRepository(MySQLContext mySQLContext)
        {
            _mySQLContext = mySQLContext;
        }

        public async Task<ToDoList> CreateToDoList(ToDoList toDoList)
        {
            await _mySQLContext.AddAsync(toDoList);
            await _mySQLContext.SaveChangesAsync();

            return toDoList;
        }

        public async Task<ToDoList> ReadToDoList(Guid toDoListId)
        {
            return await _mySQLContext.ToDoLists.FirstOrDefaultAsync(tdl => tdl.Id == toDoListId);
        }

        public async Task<ToDoList> UpdateToDoList(ToDoList toDoList)
        {
            _mySQLContext.ToDoLists.Update(toDoList);
            await _mySQLContext.SaveChangesAsync();

            return toDoList;
        }

        public async Task<bool> DeleteToDoList(Guid toDoListId)
        {
            ToDoList toDoList = await _mySQLContext.ToDoLists.FindAsync(toDoListId);

            _mySQLContext.ToDoLists.Remove(toDoList);
            await _mySQLContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<ToDoList>> ListToDoList()
        {
            return await _mySQLContext.ToDoLists.ToListAsync();
        }

    }
}
