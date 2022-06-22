using System.ComponentModel.DataAnnotations;

namespace ExamApp.Models.Classes
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Imtahan adı")]
        public string Name { get; set; }
        [Required]
        public int LessonId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Imtahan Tarixi")]
        public DateTime ExamDate { get; set; }
        [Display(Name = "Bal")]
        public int Score { get; set; }
    }
}
