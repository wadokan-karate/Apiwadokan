﻿using Data;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<EventEntity> Events { get; set; }
        public DbSet<FileEntity> Files { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EventEntity>(entity =>
            {
                entity.ToTable("Events");
                entity.HasOne<FileEntity>()
                .WithMany()
                .HasForeignKey(p => p.IdPhotoFile);
            });

            builder.Entity<FileEntity>(user =>
            {
                user.ToTable("t_files");
            });

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }

    }
}

public class ServiceContextFactory : IDesignTimeDbContextFactory<ServiceContext>
{
    public ServiceContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", false, true);
        var config = builder.Build();
        var connectionString = config.GetConnectionString("ServiceContext");
        var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
        optionsBuilder.UseSqlServer(config.GetConnectionString("ServiceContext"));

        return new ServiceContext(optionsBuilder.Options);
    }
}


