using Microsoft.EntityFrameworkCore;
using Webapp.Models;

namespace Webapp.Data;

public class MyAppContext : DbContext
{
    public MyAppContext(DbContextOptions<MyAppContext> options) : base(options){}
    public DbSet<Items> Items { get; set; }
    
}