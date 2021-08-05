
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBContexts;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class StudentService : IStudentService
    {
        private List<Student> Students;
        private readonly StudentDBContext context;
        public StudentService(StudentDBContext context)
        {
            this.context = context;
        }

        public async Task<Student> Create(Student createStudent)
        {
            try
            {
                context.Add(createStudent);
                var studentId = await context.SaveChangesAsync();
                createStudent.StudentId = studentId;
                return createStudent;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Student> GetBookById(int bookId)
        {
            return await context.Students.Include(c => c.classs).FirstOrDefaultAsync(b => b.StudentId == bookId);
        }

        public Student GetStudent(int studentId)
        {
            return Students.FirstOrDefault(s => s.StudentId == studentId);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public async Task<Student> Modify(Student student)
        {
            try
            {
                context.Attach(student);
                context.Entry<Student>(student).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return student;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Student> Remove(int studentId)
        {
            try
            {
                var student = await GetBookById(studentId);
                student.IsDeleted = true;
                context.Attach(student);
                context.Entry<Student>(student).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return student;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Student> Restore(int studentId)
        {
            try
            {
                var student = await GetBookById(studentId);
                student.IsDeleted = false;
                context.Attach(student);
                context.Entry<Student>(student).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return student;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
