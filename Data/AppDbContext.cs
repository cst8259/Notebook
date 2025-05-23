using System;
using Microsoft.EntityFrameworkCore;
using Notebook.Models;

namespace Notebook.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
  public DbSet<Note> Notes { get; set; }
  public DbSet<Category> Categories { get; set; }
  public DbSet<User> Users { get; set; }
}
