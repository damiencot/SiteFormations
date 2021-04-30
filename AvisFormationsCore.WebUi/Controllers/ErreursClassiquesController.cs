using AvisFormationsCore.WebUi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationsCore.WebUi.Controllers
{
    public class ErreursClassiquesController : Controller
    {
        public IActionResult VueManquante()
        {
            var vm = new TouteLesFormationsViewModel();
            vm.Message = "Ceci est un message du controlleur";
            return View(vm);
        }

        public IActionResult ViewModelNonPasse()
        {
            var vm = new TouteLesFormationsViewModel();
            vm.Message = "Ceci est un message du controlleur";
            return View(vm);
        }

        public IActionResult MauvaisViewsModel()
        {
            var vm = new TouteLesFormationsViewModel();
            vm.Message = "Ceci est un message du controller";
            return View(vm);
        }

        public IActionResult VueErreurHtml()
        {
            return View();
        }

        public IActionResult NombreDedicmaux(string nombre)
        {

            return View(nombre);
        }
    }
}
