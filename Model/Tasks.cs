﻿using System.ComponentModel.DataAnnotations;

namespace Task_Management.Model
{
    public class Tasks
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
