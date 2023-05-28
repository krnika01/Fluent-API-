using Karnika_Panoriya_Assignment.Model;

namespace Karnika_Panoriya_Assignment.Repository
{
    public interface IStudentRepository
    {
        Task<List<StudentModel>> GetStudentList();
        StudentModel GetStudentById(int id);

        StudentModel AddStudent(StudentModel student);

        StudentModel DeleteStudent(int id);

        Task UpdateStudentDetail(int id, StudentModel model);
    }
}
