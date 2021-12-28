using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonApp.Model
{
    class Log
    {
        public readonly int id;
        public readonly int student_id;
        public readonly int points;
        public readonly int transitive_points;
        public readonly int event_id;

        public Log(
            int id,
            int student_id,
            int points,
            int transitive_points,
            int event_id
            )
        {
            this.id = id;
            this.student_id = student_id;
            this.points = points;
            this.transitive_points = transitive_points;
            this.event_id = event_id;
        }
    }
}
