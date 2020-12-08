using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hospital_Management.Models;

namespace Hospital_Management.Data
{
    public class Hospital_ManagementContext : DbContext
    {
        public Hospital_ManagementContext (DbContextOptions<Hospital_ManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Hospital_Management.Models.Hospital> Hospital { get; set; }

        public DbSet<Hospital_Management.Models.Doctor> Doctor { get; set; }

        public DbSet<Hospital_Management.Models.Medicine> Medicine { get; set; }

        public DbSet<Hospital_Management.Models.Patient> Patient { get; set; }
    }
}
