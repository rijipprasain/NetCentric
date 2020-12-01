using CSITDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CSITDemo.Controllers.API
{
    [Route("api/[controller]")]//attribute route compulsory
    [ApiController]
    public class StudentController : ControllerBase
    {
        public List<StudentModel> Get()
        {
            return GetStudentsFromDb();
        }

        private List<StudentModel> GetStudentsFromDb()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { Name = "student 1", Address = "maitidevi" });
            students.Add(new StudentModel { Name = "student 2", Address = "balaju" });
            students.Add(new StudentModel { Name = "student 3", Address = "biratnagar" });

            return students;
        }
    }
}
