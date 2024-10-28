using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testplatformu3
{
    internal class StudentController
    {
        List<Student> students = new List<Student>();

        public void AddStudent(string name, string surname, string email, string password, string questionCategory)
        {
            var student = new Student
            {
                Name = name,
                Surname = surname,
                Email = email,
                Password = password,
                QuestionCategory = questionCategory
            };
            students.Add(student);
            Console.WriteLine($"Öğrenci eklendi: {student.Name} {student.Surname}");
        }

        public List<Student> GetStudents()
        {
            return students;
        }
        public bool Login(string email, string password)
        {
          
            var student = students.FirstOrDefault(s => s.Email == email && s.Password == password);
            return student != null; 
        }
    }
}
