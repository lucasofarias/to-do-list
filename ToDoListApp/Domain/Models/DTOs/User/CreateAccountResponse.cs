namespace ToDoListApp.Domain.Models.DTOs.User
{
    public record CreateAccountResponse(Guid Id, string Username, string FirstName, string LastName, string Email)
    {
    }
}
