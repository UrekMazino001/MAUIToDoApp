using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public interface IStudentService
    {
        Task<int> AddStudent(Student model);
        Task<int> DeleteStudent(Student model);
        Task<List<Student>> GetStudentList();
        Task<int> UpdateStudent(Student model);
    }
}
