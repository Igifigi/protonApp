using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using protonApp.Model;

namespace protonApp.Model
{
    class Ranking
    {
        public readonly List<PointedStudent> students;
        public readonly List<PointedClass> classes;

        public Ranking(
            List<PointedStudent> students,
            List<PointedClass> classes
            )
        {
            this.students = students;
            this.classes = classes;
        }
    }
}
