using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoWebService.Models;

namespace DemoWebService.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studentList = new List<StudentInfo>();
            for(int i = 1; i < 15; i++)
            {
                var studenInfo = new StudentInfo
                {
                    idStudent = $"Student {i}",
                    nameStudent = $"Name {i}",
                    age = DateTime.Now.Year - 2000, 
                };
                studentList.Add(studenInfo);
            }
            return studentList;
        }

        // GET: api/Student/5
        public StudentInfo Get(String id)
        {
            if (String.Compare(id, "5951071040", true) == 0)
            {
                return new StudentInfo
                {
                    idStudent = id.ToString(),
                    nameStudent = "Võ Văn Kha",
                    age = DateTime.Now.Year - 2000
                };
            }
            else return new StudentInfo
            {
                idStudent = $"Student {id}",
                nameStudent = $"Name {id}",
                age = DateTime.Now.Year - 2000,
            };
     
        }

        // POST: api/Student
       
    }
}
