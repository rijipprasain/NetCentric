using FirstASPProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPProj.Services
{
    public class TeacherServices: ITeacherServices
    {
        public List<TeacherModel> GetTeacherModelsDB()
        {
            List<TeacherModel> teachers = new List<TeacherModel>();
            teachers.Add(new TeacherModel { name = "Ram", subject = "math" });
            teachers.Add(new TeacherModel { name = "Hari", subject = "science" });
            teachers.Add(new TeacherModel { name = "shyam", subject = "nepali" });
            return teachers;
        }
        public TeacherModel GetTeacherById(int id)
        {
            return new TeacherModel {id=id, name = "shyam", subject = "nepali" };
        }
    }
}
