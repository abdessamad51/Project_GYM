using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_De_Sport
{
    [Serializable]
    class Client:Personne
    {
    
        private DateTime datePaiement;
        private string tempsSubscription;
        private double prixMensuel;

        public DateTime DatePaiement { get => datePaiement; set => datePaiement = value; }
        public string TempsSubscription { get => tempsSubscription; set => tempsSubscription = value; }
        public double PrixMensuel { get => prixMensuel; set => prixMensuel = value; }

        public Client()
        {

        }

        public Client(string nom, string prenom, string sexe, DateTime dateJoindre, string typeSport, double prixMensuel, DateTime datePaiement, string tempsSubscription) : base(nom, prenom, sexe, dateJoindre, typeSport)
        {
            this.datePaiement = datePaiement;
            this.tempsSubscription = tempsSubscription;
            this.prixMensuel = prixMensuel;

        }















    }
}
