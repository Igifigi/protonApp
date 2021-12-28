using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Types;

namespace protonApp.Model
{
    class Event
    {
        public readonly int id;
        public readonly string name;
        public readonly DateTime date;

        public Event(
            int id,
            string name,
            DateTime date
            )
        {
            this.id = id;
            this.name = name;
            this.date = date;
        }
    }
}
