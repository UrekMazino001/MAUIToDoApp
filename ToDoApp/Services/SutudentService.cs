using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class StudentService: IStudentService
    {
        private SQLiteAsyncConnection connection;

        public StudentService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (connection is null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Student.db3");
                connection = new SQLiteAsyncConnection(dbPath);
                await connection.CreateTableAsync<Student>();
            }
        }

        public async Task<List<Student>> GetStudentList()
        {
            var students = await connection.Table<Student>().ToListAsync();
            return students;    
        }
        public async Task<int> AddStudent(Student model)
        {
           return await connection.InsertAsync(model);
        }
        public async Task<int> DeleteStudent(Student model)
        {
            return await connection.DeleteAsync(model);
        }
        public async Task<int> UpdateStudent(Student model)
        {
            return await connection.UpdateAsync(model);
        }
    }
}
 