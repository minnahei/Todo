using System;
namespace Todo.Models
{
    // We make a viewmodel because in the view you might want to show an array of todoitems
    public class TodoViewModel
    {
        public TodoItem[] Items { get; set; }
    }
}
