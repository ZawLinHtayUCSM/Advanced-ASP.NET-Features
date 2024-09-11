using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.DI.Models;

namespace WebApi.DI.Data
{
    public class StudentRepository : IStudentRepository
    {
        public IEnumerable<StudentV1> GetAllV1()
        {
            return GetStudentsFromDbV1();
        }

        public IEnumerable<StudentV2> GetAllV2()
        {
            return GetStudentsFromDbV2();
        }

        private IEnumerable<StudentV1> GetStudentsFromDbV1()
        {
            List<StudentV1> students = new List<StudentV1>()
            {
                new StudentV1
                {
                    Id = 1,
                    FullName = "John Smith",
                    GPA = 3.5
                },

                new StudentV1
                {
                    Id = 2,
                    FullName = "Jimmy Wright",
                    GPA = 3.9
                }
            };

            return students;
        }

        private IEnumerable<StudentV2> GetStudentsFromDbV2()
        {
            List<StudentV2> students = new List<StudentV2>()
            {
                new StudentV2
                {
                    Id = 1,
                    FullName = "John Version2",
                    GPA = 3.5,
                    Age = 22
                },

                new StudentV2
                {
                    Id = 2,
                    FullName = "Jimmy Version2",
                    GPA = 3.9,
                    Age = 24
                }
            };

            return students;
        }
    }
}