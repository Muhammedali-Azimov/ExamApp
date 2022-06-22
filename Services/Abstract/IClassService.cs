using ExamApp.Models.Classes;

namespace ExamApp.Services.Abstract
{
    public interface IClassService
    {
        public Task<List<Class>> GetAllAsync();
        public Task<Class?> GetByIdAsync(int id);
        public Task AddAsync(Class @class);
        public Task UpdateAsync(Class @class);
        public Task DeleteAsync(Class @class);
    }
}
