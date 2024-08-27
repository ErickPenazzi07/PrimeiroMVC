using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()

        {
            Aluno a1 = new Aluno(1, "Jermilson ", "Jermdocapa@gmail.com ", 9078);
            Aluno a2 = new Aluno(2, "Hegtar ", "Hdogeloinvertido@gmail.com ", 9077);
            Aluno a3 = new Aluno(3, "Vausta ", "VavaMainSage@gmail.com ", 9076);
            Aluno a4 = new Aluno(4, "Lucivalda ", "Luluparedeinquebravel@gmail.com ", 9075);


            //List para adicioanr os Aluno

            List<Aluno> ListarAluno = new List<Aluno>();

            ListarAluno.Add(a1);
            ListarAluno.Add(a2);
            ListarAluno.Add(a3);
            ListarAluno.Add(a4);


            return View(ListarAluno);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
