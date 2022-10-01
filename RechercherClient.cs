using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salle_De_Sport
{
    public partial class RechercherClient : Form
    {
       
        //Salle s = new Salle();
        public RechercherClient()
        {
            InitializeComponent();
        }

        private void RechercherPersonne_Load(object sender, EventArgs e)
        {
            
        }
        private void remplirDGVRechercherClient()                                      //Remplir Data-Grid-View
        {
            foreach ( Client p in Program.Cl)                                                         
            {
                DGV_RechercherClient.Rows.Add(p.Nom, p.Prenom, p.Sexe, p.PrixMensuel, p.DateJoindre.ToShortDateString(),
                    p.TypeSport, p.DatePaiement.ToShortDateString(), p.TempsSubscription); ;
            }

        }
        int indice = -1;                                                               //Initialisation d'un Indise
        private void btn_rechercher_Click(object sender, EventArgs e)                  //Button Rechercher
        {
            // rechercher
            indice = Program.S.Re.rechercherClient(txtBox_nom.Text);
            //indice =  s.rechercher(txtBox_nom.Text);
            if (txtBox_nom.Text != "")
            {
                if (indice != -1)                                                      //Condition 1
                {
                    DGV_RechercherClient.Rows.Clear();
                    DGV_RechercherClient.Rows.Add(Program. Cl[indice].Nom, Program.Cl[indice].Prenom, Program.Cl[indice].Sexe, 
                        Program.Cl[indice].PrixMensuel, Program.Cl[indice].DateJoindre, Program.Cl[indice].TypeSport,
                        Program.Cl[indice].DatePaiement, Program.Cl[indice].TempsSubscription);
                }
                else                                                                    //Condition 2
                {
                    MessageBox.Show("le nom ne existe pas");                            //Message Box
                }
            }
            else
            {
                MessageBox.Show("le  champ est vide");
            }
        }

        private void btn_reinitialiser_Click(object sender, EventArgs e)
        {
            DGV_RechercherClient.Rows.Clear();
            remplirDGVRechercherClient();
            txtBox_nom.Text = null;
            btn_rechercher.Enabled = true;
            eP_nom.Dispose();
        }

        private void RechercherPersonne_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void txtBox_nom_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[a-z]{4,}$");                                         //Ferification Format Login-Nom                              
            if (r.IsMatch(txtBox_nom.Text))
            {
                eP_nom.Dispose();
                btn_rechercher.Enabled = true;
            }
            else                                                                          //Codition Exception
            {
                eP_nom.SetError(txtBox_nom, "Le format de ce champ est incorrect");
                btn_rechercher.Enabled = false;
            }
        }

        private void RechercherClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.R = null;
        }

        private void RechercherClient_Load(object sender, EventArgs e)
        {
            remplirDGVRechercherClient();
        }
    }
}
