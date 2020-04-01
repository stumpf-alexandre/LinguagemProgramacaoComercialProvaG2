using System.Collections.Generic;
using g2.Alexandre.Domain;

namespace g2.Alexandre.Repository
{
    public interface ITarefaPendenteRepository
    {
         void Create (TarefaPendente tarefa);

         void Update(TarefaPendente tarefa);

         void Delete(int id);

         List<TarefaPendente> GetAll();

         TarefaPendente GetById(int id);
    }
}