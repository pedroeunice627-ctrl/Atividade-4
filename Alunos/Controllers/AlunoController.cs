using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alunos.Models;

namespace Alunos.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.nome = "Eunice e Samy";
        ViewBag.curso = "Ads";
        ViewBag.semestre = "1º semestre";
        return View();
    }

}
