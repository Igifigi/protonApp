using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonApp.Model
{
    class Student
    {
        public readonly int id;
        public readonly string name;
        public readonly string surname;
        public readonly int class_id;
        public readonly int sex; //1 - chlop, 2 - baba

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
