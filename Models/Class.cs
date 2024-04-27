﻿using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Models
{
    public class Class
    {
        public int Id { get; set; }
        [Required]
        public string ClassName { get; set; } 

        public string CreatedAt { get; set; } = string.Empty;
        public DateTime CreatedBy { get; set; } = DateTime.Now;
        public string UpdatedAt { get; set; } = string.Empty;
        public DateTime UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;


    }
}
