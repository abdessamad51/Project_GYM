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
    public partial class ACCUEIL : Form
    {
        public ACCUEIL()
        {
            InitializeComponent();
        }

        private void MS_NouveauClient_Click(object sender, EventArgs e)
        {
            if (Program.N == null)
            {
                Program.N = new NouveauClient();
                Program.N.MdiParent = this;
                Program.N.Show();

            }
            else
            {
                Program.N.Focus();
            }
        }

        private void MS_RechercherClient_Click(object sender, EventArgs e)
        {
            if (Program.R == null)
            {
                Program.R = new RechercherClient();
                Program.R.MdiParent = this;
                Program.R.Show();

            }
            else
            {
                Program.R.Focus();
            }
        }

        private void MS_ModifierClient_Click(object sender, EventArgs e)
        {
            if (Program.M == null)
            {
                Program.M = new ModifierClient();
                Program.M.MdiParent = this;
                Program.M.Show();

            }
            else
            {
                Program.M.Focus();
            }
        }

        private void MS_entraîneur_Click(object sender, EventArgs e)
        {
            if (Program.NE == null)
            {
                Program.NE = new NouveauEntraîneur();
                Program.NE.MdiParent = this;
                Program.NE.Show();
        
            }
            else
            {
                Program.NE.Focus();
            }
        }

        private void MS_Paiement_Click(object sender, EventArgs e)
        {
            if (Program.P == null)
            {
                Program.P = new Paiement();
                Program.P.MdiParent = this;
                Program.P.Show();

            }
            else
            {
                Program.P.Focus();
            }
        }

        private void MS_sortir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Voulez-vous sortir", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                Application.Exit();
            }
        }
        private void TSMI_importerClient_Click(object sender, EventArgs e)
        {
            Program.S.Re.chargerClient();
        }

        private void TSMI_importerEntraineur_Click(object sender, EventArgs e)
        {
            Program.S.Re.chargerEntraineur();
        }

        private void TSMI_enregistrerEntraîneur_Click_1(object sender, EventArgs e)
        {
            Program.S.Re.EnregistrerEntraineur();
            MessageBox.Show("Enregistre avec succès");
        }

        private void MS_Enregistrer_Click(object sender, EventArgs e)
        {

        }
        private void ACCUEIL_Load(object sender, EventArgs e)
        {

        }
        private void TSMI_EnregistrerEntraîneur_Click(object sender, EventArgs e)
        {



        }
        private void TSMI_ouvrirClient_Click(object sender, EventArgs e)
        {



        }
        private void TSMI_ouvrirEntraîneur_Click(object sender, EventArgs e)
        {

        }
        private void TSMI_enregistrerClient_Click_1(object sender, EventArgs e)
        {

            Program.S.Re.EnregistrerClient();
            MessageBox.Show("Enregistre avec succès");

        }
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
