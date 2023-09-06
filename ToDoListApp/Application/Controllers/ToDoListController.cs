using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToDoListApp.Domain.Models;
using ToDoListApp.Domain.Services.Interfaces;

namespace ToDoListApp.Application.Controllers
{
    [Authorize]
    [Route("api/to-do-list")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {

        private readonly IToDoListService _toDoListService;

        public ToDoListController(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        [HttpPost("create-to-do-list")]
        public async Task<IActionResult> CreateToDoList([FromBody] ToDoList toDoList)
        {
            try
            {
                return Ok(await _toDoListService.CreateToDoList(toDoList));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
