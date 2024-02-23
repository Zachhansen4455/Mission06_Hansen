using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mission06_Hansen.Models
{
    //page to connect the databases
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; } // related to object on other table

        [Required(ErrorMessage = "The Name field is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public int Edited { get; set; }

        public String? LentTo { get; set; }

        [Required]
        public int CopiedToPlex { get; set; }

        [Range(0, 25)]
        public String? Notes { get; set; }
    }
}
