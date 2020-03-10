using Microsoft.EntityFrameworkCore;
using Segfy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Segfy.Repository.Entity
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Youtube> Youtube { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=admin;database=segfy");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Youtube>(entity =>
            {
                entity.ToTable("Youtube");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasMaxLength(50);

                entity.Property(e => e.PublishedAt)
                    .HasMaxLength(50);

                entity.Property(e => e.ChannelId)
                    .HasMaxLength(200);

                entity.Property(e => e.Title)
                    .HasMaxLength(200);

                entity.Property(e => e.Description)
                    .HasMaxLength(200);

                entity.Property(e => e.DefaultUrl)
                    .HasMaxLength(2000);

                entity.Property(e => e.MediumUrl)
                    .HasMaxLength(2000);

                entity.Property(e => e.HighUrl)
                    .HasMaxLength(2000);

                entity.Property(e => e.ChannelTitle)
                    .HasMaxLength(200);

                entity.Property(e => e.LiveBroadcastContent)
                    .HasMaxLength(2000);
            });
        }

    }
}
