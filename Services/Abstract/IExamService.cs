using ExamApp.Models.Classes;

namespace ExamApp.Services.Abstract
{
    public interface IExamService
    {
        public Task<List<Exam>> GetAllAsync();
        public Task<Exam?> GetByIdAsync(int id);
        public Task AddAsync(Exam exam);
        public Task UpdateAsync(Exam exam);
        public Task DeleteAsync(Exam exam);
    }
}
