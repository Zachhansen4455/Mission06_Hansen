using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Hansen.Models
{
    public class Form //used to get the information from the form
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("Category")]
        [Required] 
        public int CategoryId { get; set;}
        public Category Category { get; set; } // related to object on other table

        [Required(ErrorMessage = "The Name field is required.")]
        public string Title { get; set; }


        [Required(ErrorMessage = "The Name field is required.")]
        public string Year { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string? Edited { get; set; }

        public String? LentTo { get; set; }

        public bool CopiedToPlex { get; set; }
        
        [Range(0,25)]
        public String? Notes { get; set; }
    }
}
