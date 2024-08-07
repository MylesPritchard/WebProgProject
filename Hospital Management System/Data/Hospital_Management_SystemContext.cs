﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hospital_Management_System.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Hospital_Management_System.Data
{
    public class Hospital_Management_SystemContext : IdentityDbContext
    {
        public Hospital_Management_SystemContext (DbContextOptions<Hospital_Management_SystemContext> options)
            : base(options)
        {
        }
        public DbSet<Hospital_Management_System.Models.Doctor> Doctor { get; set; } = default!;
        public DbSet<Hospital_Management_System.Models.Patient> Patient { get; set; } = default!;
        public DbSet<Hospital_Management_System.Models.Visit> Visit { get; set; } = default!;
    }
}
