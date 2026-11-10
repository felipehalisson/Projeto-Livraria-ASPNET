using Microsoft.AspNetCore.Mvc;
using ProjetoLivraria.Data;
using ProjetoLivraria.Models;

namespace ProjetoLivraria.Controllers
{
    public class LivroController(LivrariaContext db) : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("UsuarioNome") is null)
            {
                return RedirectToAction("Login", "Conta");
            }

            return View(new Livro());
        }
    }
}