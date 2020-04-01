using System;
using System.Collections.Generic;
using System.Linq;
using g2.Alexandre.Domain;
using Microsoft.EntityFrameworkCore;

namespace g2.Alexandre.Repository
{
    public class TarefaPendenteRepository : ITarefaPendenteRepository
    {
        private TarefaContext context;

        public TarefaPendenteRepository(TarefaContext context){
            this.context = context;
        }

        public void Create(TarefaPendente tarefa){
            context.Tarefas.Add(tarefa);
            context.SaveChanges();
        }

        public void Delete(int id){
            context.Tarefas.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(TarefaPendente tarefa){
            context.Entry(tarefa).State=EntityState.Modified;
            context.SaveChanges();
        }

        public TarefaPendente GetById(int id){
            return context.Tarefas.SingleOrDefault(x=>x.id==id);
        }

        public List<TarefaPendente> GetAllConcluida(){
            return context.Tarefas.Where(x=>x.percentual==100).ToList();
        }

        public List<TarefaPendente> GetAll(){
            return context.Tarefas.Where(x=>x.percentual<100).ToList();
        }
    }
}
