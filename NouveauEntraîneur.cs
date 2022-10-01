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
    public partial class NouveauEntraîneur : Form
    { 
        public NouveauEntraîneur()
        {
            InitializeComponent();
        }

        private void NouveauEntraîneur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.NE = null;
        }

        private void NouveauEntraîneur_Load(object sender, EventArgs e)
        {
            comboBox_typeSportEntraineur.Items.Add("Karate");
            comboBox_typeSportEntraineur.Items.Add("Kung-Fu");
            comboBox_typeSportEntraineur.Items.Add("Boxing");
            comboBox_typeSportEntraineur.Items.Add("Taek-wondo");
            comboBox_typeSportEntraineur.Items.Add("Musculation");

            remplir_DGVEntraineur();
        }

     

        private void remplir_DGVEntraineur()
        {
            
                foreach (Entraineur E in Program.En)
                {

                DGV_Entraineur.Rows.Add(E.Nom, E.Prenom, E.Sexe, E.DateJoindre.ToShortDateString(), E.TypeSport);
                 }
        }

       
         
        






         

        bool ep2Entraineur = true;
        bool ep1Entraineur = true;
        private void txtBox_nomEntraineur_TextChanged(object sender, EventArgs e)
        {
            if (lbl_nomEntraineur.Text == "le champ vide")
            {
                lbl_nomEntraineur.Visible = false;
            }



            Regex r = new Regex(@"^[a-z]{4,}$");
            if (r.IsMatch(txtBox_nomEntraineur.Text))
            {
                ep1Entraineur = true;
                eP_nomEntraineur.Dispose();
                if (ep2Entraineur  )
                {
                    btn_ajouterEntraineur.Enabled = true;
                }

            }
            else
            {

                eP_nomEntraineur.SetError(txtBox_nomEntraineur, "Le format de ce champ est incorrect");
                btn_ajouterEntraineur.Enabled = false;
                ep1Entraineur = false;

            }
        }

        private void txtBox_prenomEntraineur_TextChanged(object sender, EventArgs e)
        {
            if (lbl_prenomEntraineur.Text == "le champ vide")
            {
                lbl_prenomEntraineur.Visible = false;
            }


            Regex r = new Regex(@"^[a-z]{4,}$");
            if (r.IsMatch(txtBox_prenomEntraineur.Text))
            {
                ep2Entraineur = true;
                eP_prenomEntraineur.Dispose();
                
                if (ep1Entraineur)
                {

                    btn_ajouterEntraineur.Enabled = true;
                }

            }
            else
            {
                eP_prenomEntraineur.SetError(txtBox_prenomEntraineur, "Le format de ce champ est incorrect");
                btn_ajouterEntraineur.Enabled = false;
                ep2Entraineur = false;
            }
        }

        private void dateTimePicker_dateJoindreEntraineur_ValueChanged(object sender, EventArgs e)
        {
            lbl_dateJoindreEntraineur.Visible = false;
        }

        private void comboBox_typeSportEntraineur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_typeSportEntraineur.Visible = false;
        }

        private void btn_reinitialiserEntraineur_Click(object sender, EventArgs e)
        {
            txtBox_nomEntraineur.Text = null;
            txtBox_prenomEntraineur.Text = null;

            comboBox_typeSportEntraineur.Text = null;
            
            rbSexe_femininEntraineur.Checked = false;
            rbSexe_masculinEntraineur.Checked = true;
            dateTimePicker_dateJoindreEntraineur.Value = DateTime.Parse("2021/06/15");

            lbl_nom.Visible = false;
            lbl_prenomEntraineur.Visible = false;

            lbl_typeSportEntraineur.Visible = false;

            lbl_dateJoindreEntraineur.Visible = false;
            eP_nomEntraineur.Dispose();
            eP_prenomEntraineur.Dispose();
        }

        private void btn_ajouterEntraineur_Click(object sender, EventArgs e)
        {

            if (txtBox_nomEntraineur.Text == "" || txtBox_prenomEntraineur.Text == "" || dateTimePicker_dateJoindreEntraineur.Value == DateTime.Parse("2021/06/15") || comboBox_typeSportEntraineur.Text == "")
            {

                //pour affiche champ null
                MessageBox.Show("le information ne pas complet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string champ = "le champ vide";
                if (txtBox_nomEntraineur.Text == "")
                {

                    lbl_nom.Text = champ;
                    //affichee label
                    lbl_nom.Visible = true;
                }
                if (txtBox_prenomEntraineur.Text == "")
                {
                    lbl_prenomEntraineur.Text = champ;
                    lbl_prenomEntraineur.Visible = true;
                }

                if (dateTimePicker_dateJoindreEntraineur.Value == DateTime.Parse("2021/06/15"))
                {
                    lbl_dateJoindreEntraineur.Text = "select date joindre";

                }
                if (comboBox_typeSportEntraineur.Text == "")
                {
                    lbl_typeSportEntraineur.Text = "select type de sport";
                }





            }
            else
            {
                String sexe;
                int indice = -1;
                //            rechercher le nom existe ou no
                indice = Program.S.Re.rechercherEntraineur(txtBox_nomEntraineur.Text.Trim());
                // check indice
                if (indice == -1)
                {
                    // le  Client ne pas existe
                    if (rbSexe_masculinEntraineur.Checked) { sexe = rbSexe_masculinEntraineur.Text; }
                    else { sexe = rbSexe_femininEntraineur.Text; }
                    //declare personne
                    Entraineur E = new Entraineur(txtBox_nomEntraineur.Text.Trim(), txtBox_prenomEntraineur.Text.Trim(), sexe, dateTimePicker_dateJoindreEntraineur.Value.Date, comboBox_typeSportEntraineur.Text);
                    // ajoute personne in liste
                    Program.S.Re.ajouterEntraineur(E);
                    MessageBox.Show("le ajoute effectuè succès");
                    DGV_Entraineur.Rows.Clear();
                    remplir_DGVEntraineur();
                }

                else
                {
                    MessageBox.Show("le Entraineur existe déja");
                }


            }
        }

        private void DGV_Entraineur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
