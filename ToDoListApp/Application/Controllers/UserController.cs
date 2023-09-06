using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoListApp.Domain.Models;
using ToDoListApp.Domain.Models.DTOs.User;

namespace ToDoListApp.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        [AllowAnonymous]
        [HttpPost("create-account")]
        public async Task<IActionResult> CreateAccount([FromBody] CreateAccountRequest createAccountRequest)
        {
            if (createAccountRequest.Username.Equals("") || createAccountRequest.FirstName.Equals("") 
                || createAccountRequest.LastName.Equals("") || createAccountRequest.Email.Equals("")
                || createAccountRequest.Password.Equals("") || createAccountRequest.PasswordConfirm.Equals(""))
            {
                throw new Exception("Por favor, preencha todos os campos.");
            }

            if (!createAccountRequest.Password.Equals(createAccountRequest.PasswordConfirm))
            {
                throw new Exception("As senhas são diferentes.");
            }

            User newUser = new User()
            {
                UserName = createAccountRequest.Username,
                FirstName = createAccountRequest.FirstName,
                LastName = createAccountRequest.LastName,
                Email = createAccountRequest.Email,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var ret = await _userManager.CreateAsync(newUser, createAccountRequest.Password);

            foreach (IdentityError error in ret.Errors)
            {
                switch (error.Code)
                {
                    case "DuplicateUserName":
                        throw new Exception("O username já está em uso.");
                }
            }

            return Ok();
        }

    }
}
