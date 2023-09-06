using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListApp.Domain.Models
{
    public class ToDoList
    {

        [Column("id")]
        public Guid Id { get; set; }

        [Column("title")]
        public string Title { get; set; } = "Lista de afazeres";

        [Column("description")]
        public string Description { get; set; } = "Descrição da lista de afazeres";

        public List<Task> Tasks { get; set; } = new List<Task>();

    }
}
