using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Net_core_search_crud_mvc.Models
{
    public class NewEmpClass
    {
        [Key]
        public int EmpId { get; set; }
        
        [Required(ErrorMessage = "Enter Employee Name")]
        [Display(Name = "Employee Name")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Enter email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Enter age")]
        [Display(Name = "Age")]
        [Range(20,50)]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Enter salary")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }

    }
}
