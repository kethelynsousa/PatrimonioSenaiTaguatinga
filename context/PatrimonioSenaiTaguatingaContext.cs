using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTaguatinga.Entities;

namespace PatrimonioSenaiTaguatinga.Contexts;

public class PatrimonioSenaiTaguatinga:DbContext{
    public DbSet<Nivel> Nivels=>Set<Nivel>();


}