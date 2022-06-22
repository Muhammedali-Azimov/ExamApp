using ExamApp.Models.Classes;

namespace ExamApp.Services.Abstract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetAllAsync();
        public Task<Student?> GetByIdAsync(int id);
        public Task AddAsync(Student student);
        public Task UpdateAsync(Student student);
        public Task DeleteAsync(Student student);
    }
}
