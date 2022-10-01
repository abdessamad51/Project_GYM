namespace Salle_De_Sport
{
    partial class Paiement
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
            this.btn_Paiement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_DatePaiement = new System.Windows.Forms.DateTimePicker();
            this.btn_reinitialiser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_nom = new System.Windows.Forms.TextBox();
            this.txtBox_prenom = new System.Windows.Forms.TextBox();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.DGV_Paiement = new System.Windows.Forms.DataGridView();
            this.Col_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_prixMensuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_dateJoindre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_typeSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_datePaiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_subrciptionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_modiferDGV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Paiement)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Paiement
            // 
            this.btn_Paiement.BackColor = System.Drawing.Color.Lime;
            this.btn_Paiement.Enabled = false;
            this.btn_Paiement.Location = new System.Drawing.Point(82, 386);
            this.btn_Paiement.Name = "btn_Paiement";
            this.btn_Paiement.Size = new System.Drawing.Size(105, 40);
            this.btn_Paiement.TabIndex = 26;
            this.btn_Paiement.Text = "Pay";
            this.btn_Paiement.UseVisualStyleBackColor = false;
            this.btn_Paiement.Click += new System.EventHandler(this.btn_Paiement_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = " Nom";
            // 
            // dateTimePicker_DatePaiement
            // 
            this.dateTimePicker_DatePaiement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DatePaiement.Location = new System.Drawing.Point(149, 139);
            this.dateTimePicker_DatePaiement.Name = "dateTimePicker_DatePaiement";
            this.dateTimePicker_DatePaiement.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker_DatePaiement.TabIndex = 23;
            // 
            // btn_reinitialiser
            // 
            this.btn_reinitialiser.BackColor = System.Drawing.Color.Lime;
            this.btn_reinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reinitialiser.Location = new System.Drawing.Point(794, 88);
            this.btn_reinitialiser.Name = "btn_reinitialiser";
            this.btn_reinitialiser.Size = new System.Drawing.Size(104, 38);
            this.btn_reinitialiser.TabIndex = 22;
            this.btn_reinitialiser.Text = "Reinitialiser";
            this.btn_reinitialiser.UseVisualStyleBackColor = false;
            this.btn_reinitialiser.Click += new System.EventHandler(this.btn_reinitialiser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = " Date Paiement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = " Prenom";
            // 
            // txtBox_nom
            // 
            this.txtBox_nom.Enabled = false;
            this.txtBox_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_nom.ForeColor = System.Drawing.Color.Red;
            this.txtBox_nom.Location = new System.Drawing.Point(149, 45);
            this.txtBox_nom.Name = "txtBox_nom";
            this.txtBox_nom.Size = new System.Drawing.Size(147, 21);
            this.txtBox_nom.TabIndex = 17;
            // 
            // txtBox_prenom
            // 
            this.txtBox_prenom.Enabled = false;
            this.txtBox_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_prenom.ForeColor = System.Drawing.Color.Red;
            this.txtBox_prenom.Location = new System.Drawing.Point(149, 89);
            this.txtBox_prenom.Name = "txtBox_prenom";
            this.txtBox_prenom.Size = new System.Drawing.Size(147, 21);
            this.txtBox_prenom.TabIndex = 16;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.BackColor = System.Drawing.Color.Lime;
            this.btn_rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.Location = new System.Drawing.Point(669, 88);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(110, 38);
            this.btn_rechercher.TabIndex = 15;
            this.btn_rechercher.Text = "Rechrecher";
            this.btn_rechercher.UseVisualStyleBackColor = false;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = " Nom";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(447, 98);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(203, 22);
            this.dateTimePicker_Date.TabIndex = 27;
            // 
            // DGV_Paiement
            // 
            this.DGV_Paiement.AllowUserToAddRows = false;
            this.DGV_Paiement.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.DGV_Paiement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Paiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Paiement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Nom,
            this.Col_prenom,
            this.Col_Sexe,
            this.Col_prixMensuel,
            this.Col_dateJoindre,
            this.Col_typeSport,
            this.Col_datePaiement,
            this.Col_subrciptionTime});
            this.DGV_Paiement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DGV_Paiement.Location = new System.Drawing.Point(336, 146);
            this.DGV_Paiement.MultiSelect = false;
            this.DGV_Paiement.Name = "DGV_Paiement";
            this.DGV_Paiement.ReadOnly = true;
            this.DGV_Paiement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Paiement.Size = new System.Drawing.Size(624, 227);
            this.DGV_Paiement.TabIndex = 54;
            // 
            // Col_Nom
            // 
            this.Col_Nom.HeaderText = "Nom";
            this.Col_Nom.Name = "Col_Nom";
            this.Col_Nom.ReadOnly = true;
            // 
            // Col_prenom
            // 
            this.Col_prenom.HeaderText = "Prenom";
            this.Col_prenom.Name = "Col_prenom";
            this.Col_prenom.ReadOnly = true;
            // 
            // Col_Sexe
            // 
            this.Col_Sexe.HeaderText = " Sexe";
            this.Col_Sexe.Name = "Col_Sexe";
            this.Col_Sexe.ReadOnly = true;
            // 
            // Col_prixMensuel
            // 
            this.Col_prixMensuel.HeaderText = "Prix Mensuel";
            this.Col_prixMensuel.Name = "Col_prixMensuel";
            this.Col_prixMensuel.ReadOnly = true;
            // 
            // Col_dateJoindre
            // 
            this.Col_dateJoindre.HeaderText = "Data Joindre";
            this.Col_dateJoindre.Name = "Col_dateJoindre";
            this.Col_dateJoindre.ReadOnly = true;
            // 
            // Col_typeSport
            // 
            this.Col_typeSport.HeaderText = "Type Sport";
            this.Col_typeSport.Name = "Col_typeSport";
            this.Col_typeSport.ReadOnly = true;
            // 
            // Col_datePaiement
            // 
            this.Col_datePaiement.HeaderText = "Date Paiement";
            this.Col_datePaiement.Name = "Col_datePaiement";
            this.Col_datePaiement.ReadOnly = true;
            // 
            // Col_subrciptionTime
            // 
            this.Col_subrciptionTime.HeaderText = "Subrciption Time";
            this.Col_subrciptionTime.Name = "Col_subrciptionTime";
            this.Col_subrciptionTime.ReadOnly = true;
            // 
            // btn_modiferDGV
            // 
            this.btn_modiferDGV.BackColor = System.Drawing.Color.Lime;
            this.btn_modiferDGV.Location = new System.Drawing.Point(557, 386);
            this.btn_modiferDGV.Name = "btn_modiferDGV";
            this.btn_modiferDGV.Size = new System.Drawing.Size(118, 42);
            this.btn_modiferDGV.TabIndex = 56;
            this.btn_modiferDGV.Text = "Modifier";
            this.btn_modiferDGV.UseVisualStyleBackColor = false;
            this.btn_modiferDGV.Click += new System.EventHandler(this.btn_modiferDGV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_nom);
            this.groupBox1.Controls.Add(this.dateTimePicker_DatePaiement);
            this.groupBox1.Controls.Add(this.txtBox_prenom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 198);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // Paiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_modiferDGV);
            this.Controls.Add(this.DGV_Paiement);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.btn_Paiement);
            this.Controls.Add(this.btn_reinitialiser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rechercher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paiement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paiement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Paiement_FormClosed);
            this.Load += new System.EventHandler(this.Paiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Paiement)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Paiement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DatePaiement;
        private System.Windows.Forms.Button btn_reinitialiser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_nom;
        private System.Windows.Forms.TextBox txtBox_prenom;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.DataGridView DGV_Paiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_prixMensuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_dateJoindre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_typeSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_datePaiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_subrciptionTime;
        private System.Windows.Forms.Button btn_modiferDGV;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}