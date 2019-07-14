using DataAnotations.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnotations.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            //if (string.IsNullOrEmpty(pessoa.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O Campo Nome é Obrigatório");
            //}
            //if (pessoa.Senha != pessoa.ConfirmarSenha) 
            //{
            //    ModelState.AddModelError("", "As Senhas não Coferem");
            //}
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }
            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoDeNomesDeExemplo = new Collection<string>
            {
                "Cleyton",
                "Anderson",
                "Renata"
            };
            return Json(bancoDeNomesDeExemplo.All(c => c.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}