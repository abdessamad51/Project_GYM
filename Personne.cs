using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_De_Sport
{
    [Serializable]
    class Personne
    {
        protected string nom;
        protected string prenom;
        protected string sexe;
        protected static int computer=0;
       
        protected DateTime dateJoindre;
        protected string typeSport;
         
        public Personne()
        {
            computer++;
        }
        public Personne(string nom, string prenom, string sexe, DateTime dateJoindre, string typeSport)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
             
            this.dateJoindre = dateJoindre;
            this.typeSport = typeSport;
            computer++;

        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public static int Computer { get => computer; }
        public DateTime DateJoindre { get => dateJoindre; set => dateJoindre = value; }
        public string TypeSport { get => typeSport; set => typeSport = value; }
       


    }





}
