using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Diagnostic> Diagnostic { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Consultation> Consultation { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Doctor_Schedule> Doctor_Schedule { get; set; }
    }
}
