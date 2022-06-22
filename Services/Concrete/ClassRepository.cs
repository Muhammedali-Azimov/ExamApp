using ExamApp.Models.Classes;
using ExamApp.Models.Contexts;
using ExamApp.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Services.Concrete
{
    public class ClassRepository : IClassService
    {
        private readonly ExamContext _context;

        public ClassRepository(ExamContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Class @class)
        {
            _context.Add(@class);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Class @class)
        {
            _context.Classes.Remove(@class);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Class>> GetAllAsync()
        {
            List<Class> classes = await _context.Classes.ToListAsync();
            return classes;
        }

        public async Task<Class?> GetByIdAsync(int id)
        {
            Class? @class = await _context.Classes
                .FirstOrDefaultAsync(m => m.Id == id);

            return @class;
        }

        public async Task UpdateAsync(Class @class)
        {
            _context.Update(@class);
            await _context.SaveChangesAsync();
        }
    }
}
