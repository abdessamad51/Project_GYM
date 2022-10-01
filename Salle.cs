using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Salle_De_Sport
{

    class Salle
    {

        private Responsable re;
        private string nom;
        private string adress;
        public string Nom { get => nom; set => nom = value; }
        public string Adress { get => adress; set => adress = value; }
        public Responsable Re { get => re; set => re = value; }

        public Salle(Responsable re_, string nom, string adress)
        {
            this.re = re_;
            this.nom = nom;
            this.adress = adress;
        }

        //public void paiement(DateTime date)
        //{
        //    foreach (Personne p in Program.lst)
        //    {
        //        if (p.TempsSubscription=="1 Months"&&( p.DatePaiement - date).Days > 30)
        //        {


        //        }

        //       else  if (p.TempsSubscription == "2 Months"&& (p.DatePaiement - date).Days >60)
        //        {


        //        }

        //        else if (p.TempsSubscription == "3 Months" && (p.DatePaiement - date).Days >90)
        //        {


        //        }

        //        else if (p.TempsSubscription == "6 Months" && (p.DatePaiement - date).Days > 180)
        //        {


        //        }

        //        else if (p.TempsSubscription == "5 Months" && (p.DatePaiement - date).Days > 270)
        //        {


        //        }
        //        else if (p.TempsSubscription == "6 Months" && (p.DatePaiement - date).Days > 360)

        //        { }

        //    }
        //}
    }
}
