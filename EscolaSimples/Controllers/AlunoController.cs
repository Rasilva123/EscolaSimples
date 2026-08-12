using EscolaSimples.Models;
using Microsoft.AspNetCore.Mvc;

namespace EscolaSimples.Controllers
{
    public class AlunoController : Controller
    {
        // Ação GET: exibe o formulário
        public IActionResult Criar()
        {
            return View();
        }

        // Ação POST: recebe os dados preenchidos
        [HttpPost]
        public IActionResult Criar(Aluno aluno)
        {
            return Content($"Aluno '{aluno.Nome}' com matrícula '{aluno.Matricula}' recebido com sucesso!");
        }
    }
}