using System;
using ContactsAppDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactsAppMaui.Data;

public class AppDbContext : DbContext
{
  public DbSet<ContactEntity> Contacts { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    base.OnConfiguring(optionsBuilder);
    optionsBuilder.UseSqlite(AppConfig.GetDbConnectionString());
  }
}
