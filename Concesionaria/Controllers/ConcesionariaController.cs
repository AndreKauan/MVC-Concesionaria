using Microsoft.AspNetCore.Mvc;
using Concesionaria.Models;

namespace Concesionaria.Controllers
{
    public class ConcesionariaController : Controller
    {
        private readonly List<Conc> carros = new List<Conc>();

        public ConcesionariaController()
        {
            carros.Add(new Conc()
            {
                id = "0001",
                marca = "Mercedes",
                modelo = "GLE 400",
                cor = "Preto",
                valor = 750900
            });

            carros.Add(new Conc()
            {
                id = "0002",
                marca = "Range Ronver",
                modelo = "Velar",
                cor = "Vermelho",
                valor = 624900
            });
        }
        

        public IActionResult Index()
        {
            return View(carros);
        }

        public IActionResult Details(string id)
        {
            var carro = carros.Find(c => c.id == id);
            if (carro == null) return NotFound();

            return View(carro);

        }



    }
}
