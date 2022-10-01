namespace Salle_De_Sport
{
    partial class ACCUEIL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCUEIL));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MS_NouveauClient = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_RechercherClient = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ModifierClient = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Paiement = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_entraîneur = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_enregistrerClient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_enregistrerEntraîneur = new System.Windows.Forms.ToolStripMenuItem();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_importerClient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_importerEntraineur = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_sortir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_NouveauClient,
            this.MS_RechercherClient,
            this.MS_ModifierClient,
            this.MS_Paiement,
            this.MS_entraîneur,
            this.TSMI_fichier,
            this.MS_sortir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1287, 58);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MS_NouveauClient
            // 
            this.MS_NouveauClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_NouveauClient.ForeColor = System.Drawing.Color.Black;
            this.MS_NouveauClient.Image = ((System.Drawing.Image)(resources.GetObject("MS_NouveauClient.Image")));
            this.MS_NouveauClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MS_NouveauClient.Name = "MS_NouveauClient";
            this.MS_NouveauClient.Size = new System.Drawing.Size(170, 54);
            this.MS_NouveauClient.Text = " Ajouter";
            this.MS_NouveauClient.Click += new System.EventHandler(this.MS_NouveauClient_Click);
            // 
            // MS_RechercherClient
            // 
            this.MS_RechercherClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_RechercherClient.ForeColor = System.Drawing.Color.Black;
            this.MS_RechercherClient.Image = ((System.Drawing.Image)(resources.GetObject("MS_RechercherClient.Image")));
            this.MS_RechercherClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MS_RechercherClient.Name = "MS_RechercherClient";
            this.MS_RechercherClient.Size = new System.Drawing.Size(195, 54);
            this.MS_RechercherClient.Text = "Rechercher  ";
            this.MS_RechercherClient.Click += new System.EventHandler(this.MS_RechercherClient_Click);
            // 
            // MS_ModifierClient
            // 
            this.MS_ModifierClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_ModifierClient.ForeColor = System.Drawing.Color.Black;
            this.MS_ModifierClient.Image = ((System.Drawing.Image)(resources.GetObject("MS_ModifierClient.Image")));
            this.MS_ModifierClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MS_ModifierClient.Name = "MS_ModifierClient";
            this.MS_ModifierClient.Size = new System.Drawing.Size(280, 54);
            this.MS_ModifierClient.Text = "Modifier/suppreimer";
            this.MS_ModifierClient.Click += new System.EventHandler(this.MS_ModifierClient_Click);
            // 
            // MS_Paiement
            // 
            this.MS_Paiement.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_Paiement.ForeColor = System.Drawing.Color.Black;
            this.MS_Paiement.Image = ((System.Drawing.Image)(resources.GetObject("MS_Paiement.Image")));
            this.MS_Paiement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MS_Paiement.Name = "MS_Paiement";
            this.MS_Paiement.Size = new System.Drawing.Size(164, 54);
            this.MS_Paiement.Text = "Paiement";
            this.MS_Paiement.Click += new System.EventHandler(this.MS_Paiement_Click);
            // 
            // MS_entraîneur
            // 
            this.MS_entraîneur.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_entraîneur.Image = ((System.Drawing.Image)(resources.GetObject("MS_entraîneur.Image")));
            this.MS_entraîneur.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MS_entraîneur.Name = "MS_entraîneur";
            this.MS_entraîneur.Size = new System.Drawing.Size(177, 54);
            this.MS_entraîneur.Text = "Entraîneur";
            this.MS_entraîneur.Click += new System.EventHandler(this.MS_entraîneur_Click);
            // 
            // TSMI_fichier
            // 
            this.TSMI_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.importerToolStripMenuItem});
            this.TSMI_fichier.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMI_fichier.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_fichier.Image")));
            this.TSMI_fichier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMI_fichier.Name = "TSMI_fichier";
            this.TSMI_fichier.Size = new System.Drawing.Size(138, 54);
            this.TSMI_fichier.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.enregistrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_enregistrerClient,
            this.TSMI_enregistrerEntraîneur});
            this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
            this.enregistrerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(224, 54);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // TSMI_enregistrerClient
            // 
            this.TSMI_enregistrerClient.Name = "TSMI_enregistrerClient";
            this.TSMI_enregistrerClient.Size = new System.Drawing.Size(188, 34);
            this.TSMI_enregistrerClient.Text = "Client";
            this.TSMI_enregistrerClient.Click += new System.EventHandler(this.TSMI_enregistrerClient_Click_1);
            // 
            // TSMI_enregistrerEntraîneur
            // 
            this.TSMI_enregistrerEntraîneur.Name = "TSMI_enregistrerEntraîneur";
            this.TSMI_enregistrerEntraîneur.Size = new System.Drawing.Size(188, 34);
            this.TSMI_enregistrerEntraîneur.Text = "Entraîneur";
            this.TSMI_enregistrerEntraîneur.Click += new System.EventHandler(this.TSMI_enregistrerEntraîneur_Click_1);
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.importerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_importerClient,
            this.TSMI_importerEntraineur});
            this.importerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importerToolStripMenuItem.Image")));
            this.importerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(224, 54);
            this.importerToolStripMenuItem.Text = "Importer";
            // 
            // TSMI_importerClient
            // 
            this.TSMI_importerClient.Name = "TSMI_importerClient";
            this.TSMI_importerClient.Size = new System.Drawing.Size(188, 34);
            this.TSMI_importerClient.Text = "Client";
            this.TSMI_importerClient.Click += new System.EventHandler(this.TSMI_importerClient_Click);
            // 
            // TSMI_importerEntraineur
            // 
            this.TSMI_importerEntraineur.Name = "TSMI_importerEntraineur";
            this.TSMI_importerEntraineur.Size = new System.Drawing.Size(188, 34);
            this.TSMI_importerEntraineur.Text = "Entraîneur";
            this.TSMI_importerEntraineur.Click += new System.EventHandler(this.TSMI_importerEntraineur_Click);
            // 
            // MS_sortir
            // 
            this.MS_sortir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_sortir.Image = ((System.Drawing.Image)(resources.GetObject("MS_sortir.Image")));
            this.MS_sortir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MS_sortir.Name = "MS_sortir";
            this.MS_sortir.Size = new System.Drawing.Size(131, 54);
            this.MS_sortir.Text = "Sortir";
            this.MS_sortir.Click += new System.EventHandler(this.MS_sortir_Click);
            // 
            // ACCUEIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 495);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "ACCUEIL";
            this.Text = "ACCUEIL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ACCUEIL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_NouveauClient;
        private System.Windows.Forms.ToolStripMenuItem MS_RechercherClient;
        private System.Windows.Forms.ToolStripMenuItem MS_ModifierClient;
        private System.Windows.Forms.ToolStripMenuItem MS_entraîneur;
        private System.Windows.Forms.ToolStripMenuItem MS_Paiement;
        private System.Windows.Forms.ToolStripMenuItem MS_sortir;
        private System.Windows.Forms.ToolStripMenuItem TSMI_fichier;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_enregistrerClient;
        private System.Windows.Forms.ToolStripMenuItem TSMI_enregistrerEntraîneur;
        private System.Windows.Forms.ToolStripMenuItem importerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_importerClient;
        private System.Windows.Forms.ToolStripMenuItem TSMI_importerEntraineur;
    }
}