using StudentForm.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForm.Models.ViewModels
{
    public class StudentDetailsViewModel
    {
        public Student Student { get; set; }
        public string PageTitle { get; set; }
    }
}
