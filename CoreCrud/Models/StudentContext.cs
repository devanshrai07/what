using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class StudentContext : DbContext

    {
        public StudentContext()
        {

        }
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
