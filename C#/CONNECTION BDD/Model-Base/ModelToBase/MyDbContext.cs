﻿using Microsoft.EntityFrameworkCore;
using ModelToBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelToBase
{

    public class MyDbContext : DbContext
    {
        public DbSet<Personnes> Personnes { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Personnes>(e => e.Property(o =>
           o.Age).HasColumnType("tinyint(1)").HasConversion<short>());


        }
    }
