namespace ToDoListApp.Domain.Models.DTOs.User
{
    public record CreateAccountRequest(string Username, string FirstName, string LastName, string Email, 
        string Password, string PasswordConfirm)
    {
    }
}
