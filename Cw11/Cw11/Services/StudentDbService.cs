using Cw11.Models;
using System;
using System.Collections.Generic;

namespace Cw11.Services
{
    public class StudentDbService : IStudentDbService
    {
    
        public static List<Student> Students = new List<Student>()
        {
            new Student
            {
                IdStudent = 1,
                UrlPhoto = "https://www.shareicon.net/data/128x128/2015/12/21/690947_face_512x512.png",
                FirstName = "Jan",
                LastName = "Nowak",
                BirthDate = DateTime.Now.AddYears(-19),
                Studies = "IT"
            },

            new Student
            {
                IdStudent = 2,
                UrlPhoto = "https://www.shareicon.net/data/128x128/2015/12/21/690952_man_512x512.png",
                FirstName = "Paweł",
                LastName = "Kowalski",
                BirthDate = DateTime.Now.AddYears(-20),
                Studies = "IT"
            },

            new Student
            {
                IdStudent = 3,
                UrlPhoto = "https://www.shareicon.net/data/128x128/2015/12/21/691035_glasses_512x512.png",
                FirstName = "Krzysztof",
                LastName = "Ibisz",
                BirthDate = DateTime.Now.AddYears(-40),
                Studies = "SNM"
            },

            new Student
            {
                IdStudent = 4,
                UrlPhoto = "https://www.shareicon.net/data/128x128/2015/12/21/691066_face_512x512.png",
                FirstName = "Jola",
                LastName = "Lojalna",
                BirthDate = DateTime.Now.AddYears(-22),
                Studies = "SNM"
            },

            new Student
            {
                IdStudent = 5,
                UrlPhoto = "https://www.shareicon.net/data/128x128/2015/09/26/646591_people_512x512.png",
                FirstName = "Pola",
                LastName = "Żuk",
                BirthDate = DateTime.Now.AddYears(-25),
                Studies = "Kultura Japonii"
            },

            new Student
            {
                IdStudent = 6,
                UrlPhoto = "https://www.shareicon.net/data/128x128/2015/09/26/646591_people_512x512.png",
                FirstName = "asdasdasd",
                LastName = "Żuk",
                BirthDate = DateTime.Now.AddYears(-25),
                Studies = "Kultura Japonii"
            }

        };

        public void DeleteStudent(int idStudent)
        {
            var student = FindStudentById(idStudent);

            if (student != null)
                Students.Remove(student); ;
        }

        public Student FindStudentById(int idStudent)
        {
            return Students.Find(s => s.IdStudent == idStudent);
        }


    }
}
