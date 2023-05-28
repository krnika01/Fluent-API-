using Karnika_Panoriya_Assignment.Model;
using Karnika_Panoriya_Assignment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Karnika_Panoriya_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudentList()
        {
            try
            {
                var students = await _studentRepository.GetStudentList();
                return Ok(students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{Id}")]

        public ActionResult GetStudentById(int Id)
        {
            try
            {
                var students = _studentRepository.GetStudentById(Id);
                return Ok(students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public ActionResult AddStudent(StudentModel studentModel)
        {
            try
            {
                var addedStudent = _studentRepository.AddStudent(studentModel);
                return Ok(addedStudent);
            }
            catch
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed);

            }
        }
        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateStudentDetails(StudentModel studentModel,int id)
        {
            await _studentRepository.UpdateStudentDetail(id, studentModel);
            return Ok();
        }

        [HttpDelete]

        public ActionResult DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
            return Ok();
        }
    }
}

