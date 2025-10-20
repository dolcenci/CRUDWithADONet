using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDWithADONet.Models
{
    public class Employee
    {

        [Key]
        public int ID {  get; set; }
        [DisplayName("FirstName Name")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("Date Of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }
        public double Salary { get; set; }
        public string FullName {  
        get { return FirstName + " " + LastName; }
        
        }




    }
}
