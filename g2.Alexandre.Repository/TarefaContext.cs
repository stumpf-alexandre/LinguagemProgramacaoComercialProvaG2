using g2.Alexandre.Domain;
using Microsoft.EntityFrameworkCore;

namespace g2.Alexandre.Repository
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext>options)
            :base(options){}

        public DbSet<TarefaPendente> Tarefas{get;set;}
    }
}