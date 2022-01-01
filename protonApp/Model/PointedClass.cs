using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonApp.Model
{
    class PointedClass : Class
    {
        public int points;
        public PointedClass(int id, string name, int points) : base(id, name)
        {
            this.points = points;
            this.name = name;
            this.id = id;
        }
    }
}
