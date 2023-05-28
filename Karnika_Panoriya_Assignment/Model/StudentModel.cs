using System.ComponentModel.DataAnnotations;

namespace Karnika_Panoriya_Assignment.Model
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        
        public string Mobile { get; set; }

        public string Address { get; set; }


    }
}

