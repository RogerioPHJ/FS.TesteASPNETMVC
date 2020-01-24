using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FS.TesteASPNET.Web.Models;

namespace FS.TesteASPNET.Web.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Nome,Idade,Endereco,Email")]Pessoa pessoa)
        {
            // string nome = formCollection["nome"];
            /*ViewBag.PessoaInformada = pessoa;
            return View("Saudacao")*/ //Esses dois foram trocados pela linha abaixo
            if (ModelState.IsValid) 
            {
                pessoa.Ativo = true;
                return View("Saudacao", pessoa);
            }
            else
            {
                return View(pessoa);
            }
        }

    }
}