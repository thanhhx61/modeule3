
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IStudentService
    {
        Task<Student> Create(Student createBook);
        Task<Student> GetBookById(int bookId);
        Task<Student> Modify(Student book);
        Task<Student> Remove(int bookId);
        Task<Student> Restore(int bookId);
        List<Student> GetStudents();
        Student GetStudent(int studentId);
    }
}
