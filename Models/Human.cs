using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class Human
    {
        [Required]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Name must contain letters only")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Age must contain numbers only")]
        [Range(0, int.MaxValue)]
        public int Age { get; set; }

        public bool Handsome { get; set; }
    }
}
