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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        string Nom="admin";                                                                                         //Les attributs
        string mdp="1234";                                                                                          // Nom + Mot de passe
        
        private void btn_ConexionLogin_Click(object sender, EventArgs e)                                            //button Connecter
        {
            if (txtBox_utilisateur.Text == "" || txtBox_motPasse.Text == "")                                        //Condition 1
            {

                MessageBox.Show("le utilisateur ou le mot passe vide ", "erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBox_utilisateur.Text != Nom || txtBox_motPasse.Text != mdp)                                 //Codition 2
            {

                MessageBox.Show("le utlilisateur ou le mot passe incorrect", "erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else                                                                                                    //Condition 3
            {                                                                                           
                ACCUEIL A = new ACCUEIL();
                A.Show();
                this.Hide();
            }

        }

        private void btn_ResetLogin_Click(object sender, EventArgs e)                                               //Button Reset 
        {
            txtBox_utilisateur.Text = null;
            txtBox_motPasse.Text =null;
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {

        }
        private void Connection_Load(object sender, EventArgs e)
        {

        }
    }

}
