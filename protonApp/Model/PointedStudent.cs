using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonApp.Model
{
    internal class PointedStudent : Student
    {
        public int points;
        public PointedStudent(int id, string name, string surname, int class_id, int sex, int points) : base(id, name, surname, class_id, sex)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.class_id = class_id;
            this.surname = surname;
            this.points = points;
        }
    }
}
