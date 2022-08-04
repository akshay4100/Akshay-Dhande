using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotations.Models
{
    public class Employee
    {
        [Key]
        public int EmpNo { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(50, ErrorMessage = "The {0} value cannot exceeds {1} characers. ")]
        public string Name { get; set; }

        [Range(1000,50000, ErrorMessage = "Please Enter values Between Range 1000 - 50000")]
        [MaxLength(6),MinLength(4)]   
        [Display(Name = "Basic Salary")]
        [DataType(DataType.Currency)]
        public decimal Basic { get; set; }

        public int DeptNo { get; set; }

        [ScaffoldColumn(true)]
        public string Dummy { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter phonenumber")]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Characters are not allowed.")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string EmailId { get; set; }

        [Required(ErrorMessage ="Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password")]
    
        [Compare("Password",ErrorMessage = "Password and confirm password should be the same")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        // Allow up to 40 uppercase and lowercase 
        // characters. Use custom error.
        [RegularExpression(@"^[a-zA-z''-'\s]{1,15}$", ErrorMessage ="Characters are not allowed.")]
        public string FirstName { get; set; }

        // Allow up to 40 uppercase and lowercase 
        // characters. Use custom error.
        [RegularExpression(@"^[a-zA-z''-'\s]{1,15}$", ErrorMessage = "Characters are not allowed.")]
        public string LastName { get; set; }


    }
}

//https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netframework-4.8