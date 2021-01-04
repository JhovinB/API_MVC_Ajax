using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Student.Controllers
{
    public class StudentController : ApiController
    {
        public List<Student> GetAllStudents()
        {
            StudentService service = new StudentService();
            return service.Get();
        }

        public Student GetByStudent(int id)
        {
            StudentService obtener = new StudentService();
            return obtener.GetById(id);
        }
        public void SaveStudent(Student student)
        {
            StudentService add = new StudentService();
            add.Insert(student);
        }
        public void UpdateStudent(Student student, int ID)
        {
            StudentService actualizar = new StudentService();
            actualizar.Update(student,ID);
        }
        public void DeleteStudent(int id)
        {
            StudentService eliminar = new StudentService();
            eliminar.Delete(id);
           
        }
    }
}
