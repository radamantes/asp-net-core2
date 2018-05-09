using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisoPaises.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvisoPaises.Controllers
{
    public class PaisesController : Controller
    {
        private readonly AplicacaoContext _context;

        public PaisesController(AplicacaoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Pais> listaPaises = new List<Pais>();

            listaPaises = (from itens in _context.Paises
                           select itens).ToList();

            ViewBag.ListaPaises = listaPaises; //colocando os paises dentro de uma viewbag

            //esse código serve somente para colocar na dropdown list um paíx com o nome de selecione com o id 0
            //meio gambiarra
            listaPaises.Insert(0, new Pais { Id = 0, Nome = "Selecione" });

            return View();
        }
        [HttpPost]
        public IActionResult Index(Pais pais)
        {
            if (pais.Id == 0)
            {
                ModelState.AddModelError("", "Selecione um país");
            }
            ViewBag.ValorSelecionado = pais.Id;

            List<Pais> listaPaises = new List<Pais>();

            listaPaises = (from p in _context.Paises
                           select p).ToList();

            ViewBag.ListaPaises = listaPaises; //colocando os paises dentro de uma viewbag



            return View();
        }
    }
}