using Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationsCore.WebUi.Controllers
{
    public class AvisController : Controller
    {
        public IActionResult LaisserUnAvis(string idFormation)
        {
            int iIdFormation = -1;
            if (!Int32.TryParse(idFormation, out iIdFormation))
            {
                return RedirectToAction("ToutesLesFormations", "Formation");
            }

            FormationMemoryRepository repository = new FormationMemoryRepository();
            var formation = repository.GetFormationById(iIdFormation);
            if (formation == null)
            {
                return RedirectToAction("ToutesLesFormations", "Formation");
            }
            return View(formation);
        }

        public IActionResult SaveComment(string commentaire, string nom, string note, string idFormation)
        {
            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(note))
            {
                return RedirectToAction("LaisserUnAvis");
            }

            AvisRepository repository = new AvisRepository();
            repository.SaveAvis(commentaire, nom);

            return RedirectToAction("DetailsFormation", "Formation", new { idFormation= idFormation });
        }
    }
}
