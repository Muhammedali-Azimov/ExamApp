using System.ComponentModel.DataAnnotations;

namespace ExamApp.Models.Classes
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Sinif adı")]
        public string Name { get; set; }

    }
}