using Microsoft.AspNetCore.Identity;

namespace ToDoListApp.Domain.Models
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
