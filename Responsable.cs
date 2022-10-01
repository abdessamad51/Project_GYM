using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Salle_De_Sport
{
    class Responsable
    {

        public Responsable()
        {

        }
        public void ajouterClient(Client c)
        {

            Program.Cl.Add(c);


        }
        public void ajouterEntraineur(Entraineur e)
        {
            Program.En.Add(e);

        }

        public void suppreime(int indice)
        {

            Program.Cl.RemoveAt(indice);


        }
        public void Modifier(int indice, string nom, string prenom, string sexe, double prixMensuel, DateTime dateJoindre, string typeSport, DateTime datePaiement, string tempsSubscription)
        {
            for (int i = 0; i < Program.Cl.Count; i++)
            {
                if (i == indice)
                {
                    Program.Cl[i].Nom = nom;
                    Program.Cl[i].Prenom = prenom;
                    Program.Cl[i].Sexe = sexe;
                    Program.Cl[i].PrixMensuel = prixMensuel;
                    Program.Cl[i].DateJoindre = dateJoindre;
                    Program.Cl[i].TypeSport = typeSport;
                    Program.Cl[i].DatePaiement = datePaiement;
                    Program.Cl[i].TempsSubscription = tempsSubscription;
                }


            }
        }

        public int rechercherClient(string nom)
        {
            int i;
            int j = -1;
            for (i = 0; i < Program.Cl.Count; i++)
            {
                if (Program.Cl[i].Nom == nom)
                {
                    j = i;

                }

            }
            return j;
        }
        public int rechercherEntraineur(string nom)
        {
            int i;
            int j = -1;
            for (i = 0; i < Program.En.Count; i++)
            {
                if (Program.En[i].Nom == nom)
                {
                    j = i;

                }

            }
            return j;
        }
        public void Paiemenet(DateTime datePay, string nom)
        {
            foreach (Client a in Program.Cl)
            {
                if (a.Nom == nom)
                {
                    a.DatePaiement = datePay;
                    break;
                }
            }
        }

       
       
        public void EnregistrerClient()
        {
            SaveFileDialog sfd = new SaveFileDialog();
           
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string cheminClient = sfd.FileName;
                sfd.Title = "Veuillez choisir dossier";

                FileStream fichier = File.Create(cheminClient);
                BinaryFormatter bF = new BinaryFormatter();
                bF.Serialize(fichier, Program.Cl);
                fichier.Close();


            }

        }
        public void chargerClient()
        {
             OpenFileDialog sfd = new  OpenFileDialog();

            sfd.Title = "Veuillez create ou choisir  dossier";
            

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string chemin = sfd.FileName;
                FileStream fichier = File.OpenRead(chemin);
                BinaryFormatter bF = new BinaryFormatter();
                Program.Cl = (List<Client>)bF.Deserialize(fichier);
                fichier.Close();
            }
        }
        public void EnregistrerEntraineur()
        {
            SaveFileDialog sfd = new SaveFileDialog();
          
            sfd.Title = "Veuillez choisir dossier";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string chemin = sfd.FileName;
                FileStream fichier = File.Create(chemin);
                BinaryFormatter bF = new BinaryFormatter();
                bF.Serialize(fichier, Program.En);
                fichier.Close();


            }

        }
        public void chargerEntraineur()
        {
           OpenFileDialog sfd = new OpenFileDialog();
            sfd.Title = "Veuillez choisir dossier";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string chemin = sfd.FileName;
              
                FileStream fichier = File.OpenRead(chemin);
                BinaryFormatter bF = new BinaryFormatter();
                Program.En = (List<Entraineur>)bF.Deserialize(fichier);
                fichier.Close();
            }
        }












    }
}
