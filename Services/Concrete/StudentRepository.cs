using ExamApp.Models.Classes;
using ExamApp.Models.Contexts;
using ExamApp.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Services.Concrete
{
    public class StudentRepository : IStudentService
    {
        private readonly ExamContext _context;

        public StudentRepository(ExamContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Student student)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Student student)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _context.Students
                .ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Student student)
        {
            _context.Update(student);
            await _context.SaveChangesAsync();
        }
    }
}
