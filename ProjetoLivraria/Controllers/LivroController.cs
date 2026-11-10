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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Livro livro)
        {
            if (HttpContext.Session.GetString("UsuarioNome") is null)
            {
                return RedirectToAction("Login", "Conta");
            }

            if (!ModelState.IsValid)
            {
                return View(livro);
            }

            if (db.Livros.Any(l => l.Isbn == livro.Isbn))
            {
                ModelState.AddModelError(nameof(Livro.Isbn), "Já existe um livro com este ISBN.");
                return View(livro);
            }

            db.Livros.Add(livro);
            await db.SaveChangesAsync();

            TempData["Mensagem"] = $"Livro \"{livro.Nome}\" cadastrado com sucesso.";
            return RedirectToAction("Index", "Home");
        }
    }
}