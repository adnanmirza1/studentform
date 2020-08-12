using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForm.Models.DbModels
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter  name")]
        [Display(Name = "Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please choose profile image")]
        public string ProfilePicture { get; set; }
    }
}
