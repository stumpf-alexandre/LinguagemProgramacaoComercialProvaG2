using g2.Alexandre.Domain;
using g2.Alexandre.Repository;
using Microsoft.AspNetCore.Mvc;

namespace g2.Alexandre.UI.Controllers
{
    public class TarefaPendenteController : Controller
    {
        private readonly ITarefaPendenteRepository _repository;

        public TarefaPendenteController(ITarefaPendenteRepository repository){
            _repository = repository;
        }

        public IActionResult Index(){
            var tarefas = _repository.GetAll();
            return View(tarefas);
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }        

        [HttpPost]
        public IActionResult Create(TarefaPendente tarefa){
            _repository.Create(tarefa);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id){
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(TarefaPendente tarefa){
            _repository.Update(tarefa);
            return RedirectToAction("Index");
        }
    }
}