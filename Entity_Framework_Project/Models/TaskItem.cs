using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Project.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        [Column(TypeName = "int")]
        public Task_Status status { get; set; }

        [Column(TypeName = "int")]
        public Task_Priority priority { get; set; }


        // Foreign Key for User
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }


        // Foreign Key for Category
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


    }

    public enum Task_Priority
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    public enum Task_Status
    {
        Pending = 1,
        InProgress = 2,
        Completed = 3
    }

}
