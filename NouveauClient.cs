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
    public partial class NouveauClient : Form
    {
        public NouveauClient()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)                                        //Button Ajouter  
        {
             

            //pour verfier les champ vide
            if (txtBox_nom.Text == "" || txtBox_prenom.Text == "" || txtBox_PrixMensuel.Text == "" || 
                dateTimePicker_dateJoindre.Value == DateTime.Parse("2021/06/15") || comboBox_typeSport.Text == "" ||
                comboBox_tempsSubscription.Text == "" || dateTimePicker_Datepataiement.Value == DateTime.Parse("2021/06/15"))
            {
                                                                                                          //pour affiche champ null
                MessageBox.Show("le information ne pas complet", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                string champ = "le champ vide";
                if (txtBox_nom.Text == "")                                                                 //Contidion: Case vide
                {
                    lbl_nom.Text = champ;
                                                                                                           //Affichee label
                    lbl_nom.Visible = true;
                }
                if (txtBox_prenom.Text == "")
                {
                    lbl_prenom.Text = champ;
                    lbl_prenom.Visible = true;                                                             //Affichee label
                }
                if (txtBox_PrixMensuel.Text == "")
                {
                    lbl_prixMensuel.Text = champ;
                    lbl_prixMensuel.Visible = true;
                }
                if (dateTimePicker_dateJoindre.Value == DateTime.Parse("2021/06/15"))
                {
                    lbl_dateJoindre.Text = "select date joindre";

                }
                if (comboBox_typeSport.Text == "")
                {
                    lbl_typeSport.Text = "select type de sport";
                }
                if (comboBox_tempsSubscription.Text == "")
                {
                    lbl_TempsSubscrption.Text = "select temps subscription";

                }

                if (dateTimePicker_Datepataiement.Value == DateTime.Parse("2021/06/15"))
                {
                    lbl_datePaiement.Text = "select date paiement";
                }

            }
            else
            {
                String sexe;
                int indice = -1;
                                                                                                       //rechercher le nom existe ou non
                indice = Program.S.Re.rechercherClient(txtBox_nom.Text.Trim());
                                                                                                       // check indice
                if (indice == -1)
                {
                    // le personne ne pas existe
                    if (rbSexe_masculin.Checked) { sexe = rbSexe_masculin.Text; }
                    else { sexe = rbSexe_feminin.Text; }
                    //declare personne
                    Client a = new Client(txtBox_nom.Text.Trim(), txtBox_prenom.Text.Trim(), sexe, 
                        dateTimePicker_dateJoindre.Value.Date, comboBox_typeSport.Text, 
                        double.Parse(txtBox_PrixMensuel.Text.Trim()), dateTimePicker_Datepataiement.Value.Date,
                        comboBox_tempsSubscription.Text);
                                                                                                      // ajoute personne in liste
                    Program.S.Re.ajouterClient(a);
                    MessageBox.Show("le ajoute effectuè succès");
                }
                else
                {
                    MessageBox.Show("le Client existe déja");
                }

            }

        }
        private void btn_reinitialiser_Click(object sender, EventArgs e)                               //Button Reset
        {
            txtBox_nom.Text = null;
            txtBox_prenom.Text = null;
            txtBox_PrixMensuel.Text = null;
            comboBox_typeSport.Text = null;
            comboBox_tempsSubscription.Text = null;
            rbSexe_feminin.Checked = false;
            rbSexe_masculin.Checked = true;
            dateTimePicker_dateJoindre.Value = DateTime.Parse("2021/06/15");
            dateTimePicker_Datepataiement.Value = DateTime.Parse("2021/06/15");
            lbl_nom.Visible = false;
            lbl_prenom.Visible = false;
            lbl_prixMensuel.Visible = false;
            lbl_tempsSubscription.Visible = false;
            lbl_typeSport.Visible = false;
            lbl_datePaiement.Visible = false;
            lbl_dateJoindre.Visible = false;
            eP_nom.Dispose();
            eP_prenom.Dispose();
            eP_prixMensuel.Dispose();
        }

        private void NouveauPersonne_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        
        bool ep = true;
        private void txtBox_nom_TextChanged(object sender, EventArgs e)
        {
                                                                                            //Car le texte changé c-a-d le champ n'est pas vide
            if (lbl_nom.Text == "le champ vide")
            {
                lbl_nom.Visible = false;
            }
                                                                                            
            Regex r = new Regex(@"^[a-z]{4,}$");                                           //Verifier Format Nom Client
            if (r.IsMatch(txtBox_nom.Text))
            {
                ep = true;
                eP_nom.Dispose();
                if (ep2 && ep1)
                {
                    btn_ajouter.Enabled = true;
                }
            }
            else
            {
                eP_nom.SetError(txtBox_nom, "Le format de ce champ est incorrect");
                btn_ajouter.Enabled = false;
                ep = false;
            }
        }

        bool ep1 = true;
        private void txtBox_PrixMensuel_TextChanged(object sender, EventArgs e)
        {
            if (lbl_prixMensuel.Text == "le champ vide")
            {
                lbl_prixMensuel.Visible = false;
            }

            Regex r = new Regex(@"^[0-9]{1,}$");                                                   //Verifier Format Prix Mensuel
            if (r.IsMatch(txtBox_PrixMensuel.Text))
            {
                ep1 = true;
                eP_prixMensuel.Dispose();
                if (ep && ep2)
                {
                    btn_ajouter.Enabled = true;
                }
            }
            else
            {
                eP_prixMensuel.SetError(txtBox_PrixMensuel, "Le format de ce champ est incorrect");
                btn_ajouter.Enabled = false;
                ep1 = false;
            }
        }

        bool ep2 = true;
        private void txtBox_prenom_TextChanged(object sender, EventArgs e)                              //Visibilite du label Prenom
        {
            if (lbl_prenom.Text == "le champ vide")
            {
                lbl_prenom.Visible = false;
            }

            Regex r = new Regex(@"^[a-z]{4,}$");                                                        //Verifier Format Prenom Client 
            if (r.IsMatch(txtBox_prenom.Text))
            {
                eP_prenom.Dispose();
                ep2 = true;
                if (ep && ep1)
                {
                    btn_ajouter.Enabled = true;
                }
            }
            else
            {
                eP_prenom.SetError(txtBox_prenom, "Le format de ce champ est incorrect");
                btn_ajouter.Enabled = false;
                ep2 = false;
            }
        }

        private void comboBox_typeSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_typeSport.Visible = false;
        }

        private void comboBox_tempsSubscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_TempsSubscrption.Visible = false;
        }
        private void comboBox_typeSport_Click(object sender, EventArgs e)
        {          
        }
        private void comboBox_tempsSubscription_Click(object sender, EventArgs e)
        {         
        }
        private void dateTimePicker_dateJoindre_ValueChanged(object sender, EventArgs e)
        {
            lbl_dateJoindre.Visible = false;
        }
        private void dateTimePicker_Datepataiement_ValueChanged(object sender, EventArgs e)          //Choisir une Date
        {                                                                                             
            lbl_datePaiement.Visible = false;                                                        //Pour ne pas affiche label
        }
        private void NouveauClient_FormClosed(object sender, FormClosedEventArgs e)                  //Fermer Form Nouveau Client
        {
            Program.N = null;
        }

        private void btn_ajouter_MouseEnter(object sender, EventArgs e)
        {
            //if(btn_ajouter.Enabled==false)
            //{
            //    btn_ajouter.Cursor = Cursors.No;
            //}
            //else
            //{
            //    btn_ajouter.Cursor = Cursors.Default;

            //}

        }
        private void btn_ajouter_MouseLeave(object sender, EventArgs e)
        {
            //btn_ajouter.Cursor = Cursors.Default;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void lbl_nom_Click(object sender, EventArgs e)
        {
        }
       
        private void NouveauClient_Load(object sender, EventArgs e)                                // Load Form Nouveau Client
        {
            
           

        }
    }
}
