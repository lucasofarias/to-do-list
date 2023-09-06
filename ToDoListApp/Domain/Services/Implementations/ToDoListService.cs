using ToDoListApp.Domain.Models;
using ToDoListApp.Domain.Services.Interfaces;
using ToDoListApp.Infrastructure.Data.Repositories.Interfaces;

namespace ToDoListApp.Domain.Services.Implementations
{
    public class ToDoListService : IToDoListService
    {

        private readonly IToDoListRepository _toDoListRepository;

        public ToDoListService(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        public async Task<ToDoList> CreateToDoList(ToDoList toDoList)
        {
            if (toDoList.Title == "" || toDoList.Title == null)
            {
                throw new Exception("Campos vazios.");
            }

            ToDoList newToDoList = new ToDoList()
            {
                Title = toDoList.Title,
                Description = toDoList.Description
            };

            newToDoList = await _toDoListRepository.CreateToDoList(newToDoList);

            return newToDoList;
        }

        public Task<bool> DeleteToDoList(Guid toDoListId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ToDoList>> ListToDoList()
        {
            throw new NotImplementedException();
        }

        public Task<ToDoList> ReadToDoList(Guid toDoListId)
        {
            throw new NotImplementedException();
        }

        public Task<ToDoList> UpdateToDoList(ToDoList toDoList)
        {
            throw new NotImplementedException();
        }

    }
}
