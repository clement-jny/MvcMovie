using System;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data;

public class MvcMovieContext : DbContext
{
	//public MvcMovieContext() { }

	public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options) { }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //    {
    //        optionsBuilder.UseMySql("server=localhost;database=mvc-movie;user=root;password=root", ServerVersion.AutoDetect("server=localhost;database=mvc-movie;user=root;password=root"));
    //    }
    //}

    public DbSet<Movie> Movies { get; set; }
}