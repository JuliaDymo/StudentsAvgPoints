using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAvgPoints
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual List<Subject> Subjects { get; set; }
        public int Average() {
            int average = 0;
            foreach (Subject s in Subjects) {
                average += s.Points;
            }
            return average / Subjects.Count;
        }


    }
}
