using System.ComponentModel.DataAnnotations;

namespace ExamApp.Models.Classes
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Dərs adı")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Sinif İd")]
        public int ClassId { get; set; }
        [MaxLength(20)]
        [Display(Name = "Müəllim adı")]
        public string TeacherName { get; set; }
        [MaxLength(20)]
        [Display(Name = "Müəllim Soyadı")]
        public string TeacherSurname { get; set; }
    }
}
