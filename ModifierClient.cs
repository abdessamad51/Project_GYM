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
    public partial class ModifierClient : Form
    {

        public ModifierClient()
        {
            InitializeComponent();
        }

        int indice = -1;                                                                                     //Initialiser un indice
        private void btn_modiferDGV_Click(object sender, EventArgs e)
        {
            try
            {
                indice = DGV_ModifierClient.SelectedRows[0].Index;
                                                                                                             // remplir dans les elements
                txtBox_nom.Text = DGV_ModifierClient.Rows[indice].Cells[0].Value.ToString();
                txtBox_prenom.Text = DGV_ModifierClient.Rows[indice].Cells[1].Value.ToString();
                txtBox_PrixMensuel.Text = DGV_ModifierClient.Rows[indice].Cells[3].Value.ToString();
                dateTimePicker_dateJoindre.Text = DGV_ModifierClient.Rows[indice].Cells[4].Value.ToString();

                                                                                                             //Condition Genre M/F
                if (DGV_ModifierClient.Rows[indice].Cells[2].Value.ToString() == rbSexe_masculin.Text)
                {
                    rbSexe_masculin.Checked = true;
                }
                if (DGV_ModifierClient.Rows[indice].Cells[2].Value.ToString() == rbSexe_feminin.Text)
                {
                    rbSexe_feminin.Checked = true;
                }
                comboBox_typeSport.Text = DGV_ModifierClient.Rows[indice].Cells[5].Value.ToString();
                dateTimePicker_Datepataiement.Text = DGV_ModifierClient.Rows[indice].Cells[6].Value.ToString();
                comboBox_tempsSubscription.Text = DGV_ModifierClient.Rows[indice].Cells[7].Value.ToString();

                //enbled
                txtBox_nom.Enabled = true;
                txtBox_prenom.Enabled = true;
                txtBox_PrixMensuel.Enabled = true;
                dateTimePicker_dateJoindre.Enabled = true;
                rbSexe_masculin.Enabled = true;
                rbSexe_feminin.Enabled = true;
                comboBox_typeSport.Enabled = true;
                dateTimePicker_Datepataiement.Enabled = true;
                comboBox_tempsSubscription.Enabled = true;
                btn_enregistrer.Enabled = true;


            }
            catch (Exception)                                                                   //Gerer l'Exception
            {
                MessageBox.Show("select element pour modifier", " information", MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }

        }

        private void Remplir_DGVModifierClient()                                                //Remplir_DGV
        {
            foreach (Client p in Program.Cl)
            {
                DGV_ModifierClient.Rows.Add(p.Nom, p.Prenom, p.Sexe, p.PrixMensuel, p.DateJoindre.ToShortDateString(),
                    p.TypeSport, p.DatePaiement.ToShortDateString(), p.TempsSubscription);
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)                          //Button Enregistrer
        {
            string sexe;

            // pour selection sexe
            if (rbSexe_masculin.Checked)                                                       //Condition Genre M/F
            {
                sexe = rbSexe_masculin.Text;
            }
            else
            {
                sexe = rbSexe_feminin.Text;
            }

                                                           //Methode Trim "Supprimer les espaces"
            // appelle methode modifier
            Program.S.Re.Modifier(indice, txtBox_nom.Text.Trim(), txtBox_prenom.Text.Trim(), sexe,
                double.Parse(txtBox_PrixMensuel.Text.Trim()), dateTimePicker_dateJoindre.Value.Date,
                comboBox_typeSport.Text, dateTimePicker_Datepataiement.Value.Date, comboBox_tempsSubscription.Text);
            DGV_ModifierClient.Rows.Clear();
            Remplir_DGVModifierClient();
            MessageBox.Show(" Modifier avec succès");
            btn_enregistrer.Enabled = false;


        }

        private void btn_suppreime_Click(object sender, EventArgs e)
        {
            try
            {
                indice = DGV_ModifierClient.SelectedRows[0].Index;
                                                                                               // donner le nom du personne selection
                string nom = DGV_ModifierClient.Rows[indice].Cells[0].Value.ToString();

                DialogResult r = MessageBox.Show("Voulez-vous supprimer", "Questions"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == r)
                {
                    DGV_ModifierClient.Rows.Clear();
                    Program.S.Re.suppreime(Program.S.Re.rechercherClient(nom));
                    Remplir_DGVModifierClient();
                }
            }
            catch (Exception)                                                                  //Exception sous Forme MessageBox
            {
                MessageBox.Show("select element pour suppreime", " information", MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }
        }

        private void btn_reinitialiser_Click(object sender, EventArgs e)                       //Button Reset
        {
            txtBox_nom.Text = null;
            txtBox_prenom.Text = null;
            txtBox_PrixMensuel.Text = null;
            dateTimePicker_dateJoindre.Value = DateTime.Parse("2020/06/15");
            dateTimePicker_Datepataiement.Value = DateTime.Parse("2020/06/15");
            comboBox_typeSport.Text = null;
            comboBox_tempsSubscription.Text = null;
            eP_nom.Dispose();
            eP_prenom.Dispose();
            eP_prixMensuel.Dispose();
        }


        bool ep = true;                                                                     //Initialiser Une Variable Bool
        private void txtBox_nom_TextChanged(object sender, EventArgs e)                     //txtBox_nom
        {
            //Car le texte change c-a-d le champ n'est pas vide
            Regex r = new Regex(@"^[a-z]{4,}$");
            if (r.IsMatch(txtBox_nom.Text))
            {
                ep = true;
                eP_nom.Dispose();
                if (ep2 && ep1)
                {
                    btn_enregistrer.Enabled = true;
                }
            }
            else
            {                                                                         //Afficher un message
                eP_nom.SetError(txtBox_nom, "Le format de ce champ est incorrect");
                btn_enregistrer.Enabled = false;
                ep = false;
            }
        }

        bool ep1 = true;
        bool ep2 = true;

        private void txtBox_prenom_TextChanged_1(object sender, EventArgs e)
        {                                                                             //txtBox_Prenom
            Regex r = new Regex(@"^[a-z]{4,}$");                                      //Verifier la Format
            if (r.IsMatch(txtBox_prenom.Text))
            {
                eP_prenom.Dispose();
                ep2 = true;
                if (ep && ep1)
                {
                    btn_enregistrer.Enabled = true;
                }
            }
            else
            {
                eP_prenom.SetError(txtBox_prenom, "Le format de ce champ est incorrect");
                btn_enregistrer.Enabled = false;
                ep2 = false;
            }
        }

        private void txtBox_PrixMensuel_TextChanged_1(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{2,}$");                                     //Verifier la Format
            if (r.IsMatch(txtBox_PrixMensuel.Text))
            {
                ep1 = true;
                eP_prixMensuel.Dispose();
                if (ep && ep2)
                {
                    btn_enregistrer.Enabled = true;
                }
            }
            else
            {                                                                        //Gerer l'Exception
                eP_prixMensuel.SetError(txtBox_PrixMensuel, "Le format de ce champ est incorrect");
                btn_enregistrer.Enabled = false;
                ep1 = false;
            }
        }

        private void ModifierClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.M = null;
        }

        private void ModifierClient_Load_1(object sender, EventArgs e)
        {
            Remplir_DGVModifierClient();
        }
    }
}
