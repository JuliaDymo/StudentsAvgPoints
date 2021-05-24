using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentsAvgPoints
{
    public class DataBase : DbContext
    {
        public DataBase() : base("database") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
       
        public DbSet<Subject> Subject { get; set; }

    }
}
