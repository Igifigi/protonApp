using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonApp.Model
{
    public class Student
    {
        public int id;
        public string name;
        public string surname;
        public int class_id;
        public int sex; //1 - chlop, 0 - baba

        public Student(
            int id,
            string name,
            string surname,
            int class_id,
            int sex
            )
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.class_id = class_id;
            this.sex = sex;
        }
    }
}
