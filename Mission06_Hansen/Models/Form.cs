using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Hansen.Models
{
    public class Form //used to get the information from the form
    {
        [Key]
        [Required(ErrorMessage = "The Name field is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Category { get; set; }


        [Required(ErrorMessage = "The Name field is required.")]
        public string Year { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string? Edited { get; set; }

        public String? LentTo { get; set; }
        
        [Range(0,25)]
        public String? Notes { get; set; }
    }
}
