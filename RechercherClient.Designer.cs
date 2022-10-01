namespace Salle_De_Sport
{
    partial class RechercherClient
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
            this.components = new System.ComponentModel.Container();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.btn_reinitialiser = new System.Windows.Forms.Button();
            this.txtBox_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_RechercherClient = new System.Windows.Forms.DataGridView();
            this.eP_nom = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RechercherClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_nom)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.BackColor = System.Drawing.Color.Lime;
            this.btn_rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.Location = new System.Drawing.Point(512, 100);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(111, 36);
            this.btn_rechercher.TabIndex = 56;
            this.btn_rechercher.Text = "rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = false;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // btn_reinitialiser
            // 
            this.btn_reinitialiser.BackColor = System.Drawing.Color.Lime;
            this.btn_reinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reinitialiser.Location = new System.Drawing.Point(629, 100);
            this.btn_reinitialiser.Name = "btn_reinitialiser";
            this.btn_reinitialiser.Size = new System.Drawing.Size(112, 36);
            this.btn_reinitialiser.TabIndex = 57;
            this.btn_reinitialiser.Text = "reinitialiser";
            this.btn_reinitialiser.UseVisualStyleBackColor = false;
            this.btn_reinitialiser.Click += new System.EventHandler(this.btn_reinitialiser_Click);
            // 
            // txtBox_nom
            // 
            this.txtBox_nom.Location = new System.Drawing.Point(229, 110);
            this.txtBox_nom.Name = "txtBox_nom";
            this.txtBox_nom.Size = new System.Drawing.Size(256, 20);
            this.txtBox_nom.TabIndex = 0;
            this.txtBox_nom.TextChanged += new System.EventHandler(this.txtBox_nom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = " Nom";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Subrciption Time";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "date paiement";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "type sport";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Data Joindre";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix Mensuel";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = " Sexe";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prenom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // DGV_RechercherClient
            // 
            this.DGV_RechercherClient.AllowUserToAddRows = false;
            this.DGV_RechercherClient.AllowUserToDeleteRows = false;
            this.DGV_RechercherClient.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.DGV_RechercherClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_RechercherClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_RechercherClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column5});
            this.DGV_RechercherClient.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DGV_RechercherClient.Location = new System.Drawing.Point(62, 172);
            this.DGV_RechercherClient.MultiSelect = false;
            this.DGV_RechercherClient.Name = "DGV_RechercherClient";
            this.DGV_RechercherClient.ReadOnly = true;
            this.DGV_RechercherClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_RechercherClient.Size = new System.Drawing.Size(831, 256);
            this.DGV_RechercherClient.TabIndex = 60;
            // 
            // eP_nom
            // 
            this.eP_nom.ContainerControl = this;
            // 
            // RechercherClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 456);
            this.Controls.Add(this.DGV_RechercherClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_nom);
            this.Controls.Add(this.btn_reinitialiser);
            this.Controls.Add(this.btn_rechercher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RechercherClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RechercherClient_FormClosed);
            this.Load += new System.EventHandler(this.RechercherClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RechercherClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_nom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_reinitialiser;
        private System.Windows.Forms.TextBox txtBox_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView DGV_RechercherClient;
        private System.Windows.Forms.ErrorProvider eP_nom;
    }
}