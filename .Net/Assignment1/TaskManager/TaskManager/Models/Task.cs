using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Task
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Title cannot exceed 50 characters")]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public TaskStatus? Status { get; set; }
        [Required]
        public TaskPriorty? Priorty { get; set; }
    }
}
