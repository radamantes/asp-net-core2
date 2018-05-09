using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuadroAvisos.Data;

namespace QuadroAvisos.Pages
{
    public class AdicionarAvisoModel : PageModel
    {
        private AvisoContext _context;

        public AdicionarAvisoModel(AvisoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Aviso Item { get; set; }

        public void OnGet()
        {
            if (Item == null)
            {
                Item = new Aviso(); //se n�o existir item � pq n�o tem aviso, ent�o crio uma instancia de um aviso
            }
            Item.Hora = DateTime.Now;
        }

        //QUANDO EU FOR FAZER UM POST VERIFICO SE � VALIDO
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)//SE O MODELO N�O � VALIDO
            {
                return Page();
            }
            Item.Id = 0;
            _context.Avisos.Add(Item); //ARMAZENDO NO BANCO AS INFORMACOS DO AVISO ITEM CONTEM AS INFORMACIONES
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}