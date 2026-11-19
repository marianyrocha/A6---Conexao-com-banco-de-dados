using BlazorApp1.Components.Models;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp1.Data;

public class LojaContext : DbContext
{
    public LojaContext(DbContextOptions<LojaContext> options) : base(options) {}
    
    public DbSet<Produto> Produtos => Set<Produto>();
}