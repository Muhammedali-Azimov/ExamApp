using System.ComponentModel.DataAnnotations;

namespace ExamApp.Models.Classes
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Telebe adı")]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Telebe Soyadi")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Sinif")]
        public int ClassId { get; set; }
        public string Number { get; set; }

    }
}
