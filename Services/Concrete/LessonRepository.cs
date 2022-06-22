using ExamApp.Models.Classes;
using ExamApp.Models.Contexts;
using ExamApp.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Services.Concrete
{
    public class LessonRepository : ILessonService
    {
        private readonly ExamContext _context;

        public LessonRepository(ExamContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Lesson lesson)
        {
            _context.Add(lesson);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Lesson lesson)
        {
            _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Lesson>> GetAllAsync()
        {
            return await _context.Lessons.ToListAsync();
        }

        public async Task<Lesson?> GetByIdAsync(int id)
        {
            return await _context.Lessons.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task UpdateAsync(Lesson lesson)
        {
            _context.Lessons.Update(lesson);

            await _context.SaveChangesAsync();
        }
    }
}
