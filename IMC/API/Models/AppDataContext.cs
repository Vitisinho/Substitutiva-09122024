using Microsoft.EntityFrameworkCore;

namespace API.Models;

public class AppDataContext : DbContext
{
    //Define quais classes quer que virem tabelas no banco de dados
    public DbSet<aluno> Alunos { get; set; }
    public DbSet<imc> Imcs { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=imc.db");
    }
}