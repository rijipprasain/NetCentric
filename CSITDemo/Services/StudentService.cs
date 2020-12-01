using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CSITDemo.Models;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;

namespace CSITDemo.Services
{
    public class StudentOracleServices : IStudentServices
    {
        public List<StudentModel> GetAllStudent()
        {
            List<StudentModel> students = new List<StudentModel>();
            /*students.Add(new StudentModel { id = 1, name = "Aavash", address = "satdobato" });
            students.Add(new StudentModel { id = 2, name = "Sabin", address = "Bhaktapur" });
            students.Add(new StudentModel { id = 3, name = "Bibek", address = "Jadibuti" });
*/
            var conStr = "Data Source=RZPPRASAIN/EXPRESS;initial catalog=Orchid;integrated security=True;MultipleActiveResultSets=True";
            
            /*var cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from student";*/
            var sql = "Select * from student";

            /*conn.Open();*/
            /*SqlDataReader result=cmd.ExecuteReader();*/

            using (var conn = new SqlConnection(conStr))
            {
                var adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);




                /*while (result.Read())*/
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    StudentModel std = new StudentModel
                    {
                        /*id = (int)result["Id"],
                        name = result["Name"].ToString(),
                        email = result["Email"].ToString(),
                        address = result["Address"].ToString()*/
                        Id = (int)row["Id"],
                        Name = row["Name"].ToString(),
                        Email = row["Email"].ToString(),
                        Address = row["Address"].ToString()
                    };
                    students.Add(std);
                }

            }

            /*conn.Close();
            conn.Dispose();*/


            return students;
        }
        public StudentModel GetStudentById(int id)
        {

            return new StudentModel { Id = id, Name = "Aavash", Address = "satdobato" };

            /*List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { id = 0, name = "Aavash", address = "satdobato" });
            students.Add(new StudentModel { id = 1, name = "Sabin", address = "Bhaktapur" });
            students.Add(new StudentModel { id = 2, name = "Bibke", address = "Jadibuti" });*/


            /*int exist = findIndex(students,id);

            if (exist >= 0)
            {
                return students[exist];
            }
            else
            {
                return null;
            }*/
        }
        /*private int findIndex(List<StudentModel> students,int id)
        {
            for(int i = 0; i < students.Count; i++)
            {
                if (students[i].id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }*/

        public async Task<int> SendEmail(List<StudentModel> model)
        {
            await Task.Delay(5000);
            foreach (var std in model)
            {
                Console.WriteLine($"Email sent to {std.Name}");
            }
            return 1;
        }
    }

    public interface IStudentServices
    {
    }
}
