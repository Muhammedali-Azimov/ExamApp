using ExamApp.Models.Classes;
using ExamApp.Models.Contexts;
using ExamApp.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Services.Concrete
{
    public class ExamRepository : IExamService
    {
        private readonly ExamContext _context;

        public ExamRepository(ExamContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Exam exam)
        {
            _context.Add(exam);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Exam exam)
        {
            _context.Exams.Remove(exam);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Exam>> GetAllAsync()
        {
            return await _context.Exams
                .Include(e => e.LessonId).ToListAsync();
        }

        public async Task<Exam?> GetByIdAsync(int id)
        {
            return await _context.Exams
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Exam exam)
        {
            _context.Exams.Update(exam);

            await _context.SaveChangesAsync();
        }
    }
}
