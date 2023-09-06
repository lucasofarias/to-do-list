using ToDoListApp.Domain.Models;

namespace ToDoListApp.Domain.Services.Interfaces
{
    public interface IToDoListService
    {

        Task<ToDoList> CreateToDoList(ToDoList toDoList);
        Task<ToDoList> ReadToDoList(Guid toDoListId);
        Task<ToDoList> UpdateToDoList(ToDoList toDoList);
        Task<bool> DeleteToDoList(Guid toDoListId);
        Task<List<ToDoList>> ListToDoList();

    }
}
