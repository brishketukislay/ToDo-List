using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Joke_App.Models
{
    public class Task
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Task")]
        public string ListItems { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Qty { get; set; }

    }
}
