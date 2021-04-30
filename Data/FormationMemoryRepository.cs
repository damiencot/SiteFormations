using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data
{
    public class FormationMemoryRepository
    {
        private List<Formation> _formations = new List<Formation>();

        public FormationMemoryRepository()
        {
            _formations.Add(new Formation { Id = 1, Nom = "Créer votre site web avec .net", NomSeo = "asp-net-core" , Description = "Devenez pro du .net"});
            _formations.Add(new Formation { Id = 2, Nom = "Créer votre site web avec java", NomSeo = "java", Description = "Devenez pro du java"});
            _formations.Add(new Formation { Id = 3, Nom = "Commencez le jardinage", NomSeo = "pro-jardinage", Description = "Devenez pro jardinage"});
            _formations.Add(new Formation { Id = 4, Nom = "Photo pro", NomSeo = "pro-photo", Description = "Devenez pro de la photo"});


        }

        public List<Formation> GetAllFormations()
        {
            return _formations; 
        }

        public Formation GetFormationById(int iIdFormation)
        {
            return _formations.Where(f => f.Id == iIdFormation).FirstOrDefault();
        }
    }
}
