using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnCareDataSystemApp.Domain.Entities;

namespace OnCareDataSystemApp.Data.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    }

    public DbSet<Colaborador> Colaboradores;
    public DbSet<Colaborador> Paciente;
    public DbSet<Colaborador> Usuario;
}
