using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_De_Sport
{
    [Serializable]
    class Entraineur:Personne
    {
      
        public Entraineur()
        {

        }
        public Entraineur(string nom, string prenom, string sexe, DateTime dateJoindre, string typeSport) : base(nom, prenom, sexe, dateJoindre, typeSport)
        {

        }







    }
}
