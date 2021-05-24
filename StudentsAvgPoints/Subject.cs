﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAvgPoints
{
   public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int Points { get; set; }

        public virtual Student Student { get; set; }
    }
}
