using CSITDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSITDemo.Services
{
    public interface IStudentService
    {
        List<StudentModel> GetAllStudents();

        StudentModel GetStudentById(int id);

        Task<int> SendEmail(List<StudentModel> model);
    }
}
