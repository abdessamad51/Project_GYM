using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salle_De_Sport
{
    public partial class Paiement : Form
    {
        public Paiement()
        {
            InitializeComponent();
        }

        private void btn_rechercher_Click(object sender, EventArgs e)                           //Button rechercher
        {
            DGV_Paiement.Rows.Clear();
            rechercher();                                                                       //Appeler Methode rechercher
        }
        private void rechercher()                                                              //Methode rechercher
        {
            DGV_Paiement.Rows.Clear();
            foreach ( Client p in Program.Cl)                                                  //Dans DGV = data Grid view
            {
                if (p.TempsSubscription == "1 Months" && (dateTimePicker_Date.Value - p.DatePaiement).Days >= 30)
                {
                    DGV_Paiement.Rows.Add(p.Nom, p.Prenom, p.Sexe, p.PrixMensuel, 
                        p.DateJoindre, p.TypeSport, p.DatePaiement, p.TempsSubscription);
                }
                else if (p.TempsSubscription == "2 Months" && (dateTimePicker_Date.Value - p.DatePaiement).Days >= 60)
                {
                    DGV_Paiement.Rows.Add(p.Nom, p.Prenom, p.Sexe, p.PrixMensuel, 
                        p.DateJoindre, p.TypeSport, p.DatePaiement, p.TempsSubscription);
                }
                else if (p.TempsSubscription == "3 Months" && (dateTimePicker_Date.Value - p.DatePaiement).Days >= 90)
                {
                    DGV_Paiement.Rows.Add(p.Nom, p.Prenom, p.Sexe, p.PrixMensuel, 
                        p.DateJoindre, p.TypeSport, p.DatePaiement, p.TempsSubscription);
                }
                else if (p.TempsSubscription == "6 Months" && (dateTimePicker_Date.Value - p.DatePaiement).Days >= 180)
                {
                    DGV_Paiement.Rows.Add(p.Nom, p.Prenom, p.Sexe, p.PrixMensuel,
                        p.DateJoindre, p.TypeSport, p.DatePaiement, p.TempsSubscription);
                }
                else if (p.TempsSubscription == "5 Months" && (dateTimePicker_Date.Value - p.DatePaiement).Days >= 270)
                {
                    DGV_Paiement.Rows.Add(p.Nom, p.Prenom, p.Sexe, p.PrixMensuel,
                        p.DateJoindre, p.TypeSport, p.DatePaiement, p.TempsSubscription);
                }
                else if (p.TempsSubscription == "6 Months" && (dateTimePicker_Date.Value - p.DatePaiement).Days >= 360)
                {
                    DGV_Paiement.Rows.Add(p.Nom, p.Prenom, p.Sexe, p.PrixMensuel, 
                        p.DateJoindre, p.TypeSport, p.DatePaiement, p.TempsSubscription);
                }
            }
        }
        private void Remplir_DGVPaiement()                                                         //Remplir DGV 
        {
            foreach (Client p in Program.Cl)
            {
               DGV_Paiement.Rows.Add(p.Nom, p.Prenom, p.Sexe, p.PrixMensuel, p.DateJoindre.ToShortDateString(), 
               p.TypeSport, p.DatePaiement.ToShortDateString(), p.TempsSubscription);
            }
        }
        private void Paiement_Load(object sender, EventArgs e)
        {
            Remplir_DGVPaiement();
            dateTimePicker_Date.Value = DateTime.Now.Date;
        }
     
        private void btn_modiferDGV_Click(object sender, EventArgs e)                              //Button Modifier
        {
            int indice = -1;                                                                       //Initialiser indice
            try
            {
                indice = DGV_Paiement.SelectedRows[0].Index;                                       //Selection dans DGV

                for (int i = 0; i < Program.Cl.Count; i++)
                {
                    if (i == Program.S.Re.rechercherClient(DGV_Paiement.Rows[indice].Cells[0].Value.ToString()))
                    {                                                                                                    
                        txtBox_nom.Text = Program.Cl[i].Nom;                                       //Affiche dans texte via txt box
                        txtBox_prenom.Text = Program.Cl[i].Prenom;
                        dateTimePicker_DatePaiement.Text = Program.Cl[i].DatePaiement.ToString();
                    }
                }
                btn_Paiement.Enabled = true;
            }
            catch(Exception)                                                                        //EXCEPTION 
            {
                MessageBox.Show("Selectioner un personne pour Verifier son paiement ");
            }
        }

        private void btn_Paiement_Click(object sender, EventArgs e)
        {
            Program.S.Re.Paiemenet(dateTimePicker_DatePaiement.Value, txtBox_nom.Text);           // Appelle methode Paiement

            MessageBox.Show("Paiement avec succes");                                             // Affiche MessageBbox de Verification

            DGV_Paiement.Rows.Clear();
           
            rechercher();
            btn_Paiement.Enabled = false;
        }

        private void Paiement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.P = null;
        }

        private void btn_reinitialiser_Click(object sender, EventArgs e)
        {
            DGV_Paiement.Rows.Clear();
            Remplir_DGVPaiement();
        }
    }
}
