using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListApp.Domain.Models
{
    public class Task
    {

        [Column("id")]
        public Guid Id { get; set; }

        [Column("description")]
        public string Description { get; set; } = "Descrição da tarefa.";

        [Column("is_completed")]
        public bool IsCompleted { get; set; } = false;

        [Column("todo_list_id")]
        public Guid ToDoListId { get; set; }

        public ToDoList ToDoList { get; set; } = new ToDoList();

    }
}
