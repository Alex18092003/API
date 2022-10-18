using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ModelTeacher
    {
        public ModelTeacher(Teacher teacher)
        {
            Kod_teacher = teacher.Kod_teacher;
            Name = teacher.Name;
            Surname = teacher.Surname;
            Patronymic = teacher.Patronymic;
            Subject = teacher.Subject;
            Images = teacher.Images;
        }
        public int Kod_teacher { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Subject { get; set; }
        public string Images { get; set; }
    }
   
}