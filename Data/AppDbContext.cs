﻿using Microsoft.EntityFrameworkCore;
using WebApplication12.Models;

namespace WebApplication12.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId

            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m=> m.Movie).WithMany(am=> am.Actor_Movies).HasForeignKey(am=>am.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.ActorId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor>? Actors { get; set; }
        public DbSet<Movie>? Movies { get; set; }
        public DbSet<Actor_Movie>? Actor_Movies { get; set; }
        public DbSet<Cinema>? Cinemas { get; set; }
        public DbSet<Producer>? Producers { get; set; }





    }
}
