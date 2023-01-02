using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTVN.Models;

    public class LTQLDbContext : DbContext
    {
        public LTQLDbContext (DbContextOptions<LTQLDbContext> options)
            : base(options)
        {
        }

        public DbSet<BTVN.Models.LopHoc> LopHoc { get; set; } = default!;

        public DbSet<BTVN.Models.Sinhvien> Sinhvien { get; set; } = default!;
    }
