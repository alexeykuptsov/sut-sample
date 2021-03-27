using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SutSampleWebApplication.Models
{
    public class HomeIndexModel
    {
        [Required]
        public string NewItem { get; set; }

        public List<TodoItem> Items { get; } = new()
        {
            new TodoItem {Text = "Buy milk"},
            new TodoItem {Text = "Repair a shelf"},
            new TodoItem {Text = "Manage new bills"},
        };
    }
}