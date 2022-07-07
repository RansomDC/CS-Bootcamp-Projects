using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataBaseFirst_Submission_Assignment
{
    // This class creates a derived context, which represents a session with the database, allowing us to query and save data.
    // StudentContext must inherit from DbContext in order to be used in the using statement parameters in the Program.cs file.
    class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
