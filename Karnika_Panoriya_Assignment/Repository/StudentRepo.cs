using Karnika_Panoriya_Assignment.Data;
using Karnika_Panoriya_Assignment.Model;
using Microsoft.EntityFrameworkCore;

namespace Karnika_Panoriya_Assignment.Repository
{
    public class StudentRepo : IStudentRepository
    {
        private readonly DatabaseContext _databaseContext;

        public StudentRepo(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<StudentModel>> GetStudentList()
        {
            var studentList = await _databaseContext.studentModels.ToListAsync();
            return studentList;
        }
        public StudentModel GetStudentById(int id)
        {
            var student = _databaseContext.studentModels.FirstOrDefault(x => x.Id == id);
            return student;
        }

        public StudentModel AddStudent(StudentModel studentModel)
        {
            _databaseContext.studentModels.Add(studentModel);
            _databaseContext.SaveChanges();
            return studentModel;
        }

        public async Task UpdateStudentDetail(int id, StudentModel studentModel)
        {
            var up = await _databaseContext.studentModels.FindAsync(id);
            if (up != null)
            {
                up.FirstName = studentModel.FirstName;
                up.LastName = studentModel.LastName;
                up.Mobile = studentModel.Mobile;
                up.Address = studentModel.Address;

                await _databaseContext.SaveChangesAsync();
            }


        }

        public StudentModel DeleteStudent(int id)
        {
            var del = new StudentModel() { Id = id };
            _databaseContext.studentModels.Remove(del);
            _databaseContext.SaveChanges();
            return del;
        }
    }
}

