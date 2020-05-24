using System;
using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    // Represent a single item in the database
    public class TodoItem
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public bool IsDone { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
    }
}
