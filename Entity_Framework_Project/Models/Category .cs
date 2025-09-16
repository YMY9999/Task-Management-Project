using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Project.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }


        List<TaskItem> taskItems { get; set; } = new List<TaskItem>(); // One-To-Many

    }

}
