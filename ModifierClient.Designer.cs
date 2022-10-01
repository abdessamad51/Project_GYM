namespace Salle_De_Sport
{
    partial class ModifierClient
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
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_modiferDGV = new System.Windows.Forms.Button();
            this.btn_suppreime = new System.Windows.Forms.Button();
            this.DGV_ModifierClient = new System.Windows.Forms.DataGridView();
            this.Col_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_prixMensuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_dateJoindre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_typeSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_datePaiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_tempsSubscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_typeSport = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_dateJoindre = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_Datepataiement = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_PrixMensuel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_tempsSubscription = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbSexe_feminin = new System.Windows.Forms.RadioButton();
            this.rbSexe_masculin = new System.Windows.Forms.RadioButton();
            this.txtBox_prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reinitialiser = new System.Windows.Forms.Button();
            this.eP_prenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.eP_nom = new System.Windows.Forms.ErrorProvider(this.components);
            this.eP_prixMensuel = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ModifierClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_prenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_nom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_prixMensuel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.BackColor = System.Drawing.Color.Lime;
            this.btn_enregistrer.Enabled = false;
            this.btn_enregistrer.Location = new System.Drawing.Point(206, 402);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(99, 42);
            this.btn_enregistrer.TabIndex = 57;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_modiferDGV
            // 
            this.btn_modiferDGV.BackColor = System.Drawing.Color.Lime;
            this.btn_modiferDGV.Location = new System.Drawing.Point(522, 402);
            this.btn_modiferDGV.Name = "btn_modiferDGV";
            this.btn_modiferDGV.Size = new System.Drawing.Size(99, 42);
            this.btn_modiferDGV.TabIndex = 55;
            this.btn_modiferDGV.Text = "Modifier";
            this.btn_modiferDGV.UseVisualStyleBackColor = false;
            this.btn_modiferDGV.Click += new System.EventHandler(this.btn_modiferDGV_Click);
            // 
            // btn_suppreime
            // 
            this.btn_suppreime.BackColor = System.Drawing.Color.Lime;
            this.btn_suppreime.Location = new System.Drawing.Point(668, 402);
            this.btn_suppreime.Name = "btn_suppreime";
            this.btn_suppreime.Size = new System.Drawing.Size(99, 42);
            this.btn_suppreime.TabIndex = 54;
            this.btn_suppreime.Text = "suppreime";
            this.btn_suppreime.UseVisualStyleBackColor = false;
            this.btn_suppreime.Click += new System.EventHandler(this.btn_suppreime_Click);
            // 
            // DGV_ModifierClient
            // 
            this.DGV_ModifierClient.AllowUserToAddRows = false;
            this.DGV_ModifierClient.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.DGV_ModifierClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_ModifierClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ModifierClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Nom,
            this.Col_prenom,
            this.Col_Sexe,
            this.Col_prixMensuel,
            this.Col_dateJoindre,
            this.Col_typeSport,
            this.Col_datePaiement,
            this.Col_tempsSubscription});
            this.DGV_ModifierClient.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_ModifierClient.Location = new System.Drawing.Point(441, 108);
            this.DGV_ModifierClient.MultiSelect = false;
            this.DGV_ModifierClient.Name = "DGV_ModifierClient";
            this.DGV_ModifierClient.ReadOnly = true;
            this.DGV_ModifierClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ModifierClient.Size = new System.Drawing.Size(540, 244);
            this.DGV_ModifierClient.TabIndex = 53;
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
            // Col_tempsSubscription
            // 
            this.Col_tempsSubscription.HeaderText = "Temps  Subscription";
            this.Col_tempsSubscription.Name = "Col_tempsSubscription";
            this.Col_tempsSubscription.ReadOnly = true;
            // 
            // comboBox_typeSport
            // 
            this.comboBox_typeSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typeSport.Enabled = false;
            this.comboBox_typeSport.FormattingEnabled = true;
            this.comboBox_typeSport.Items.AddRange(new object[] {
            "Karate",
            "Kung-fu",
            "Boxing",
            "Taekwondo",
            "musculation"});
            this.comboBox_typeSport.Location = new System.Drawing.Point(180, 229);
            this.comboBox_typeSport.Name = "comboBox_typeSport";
            this.comboBox_typeSport.Size = new System.Drawing.Size(176, 21);
            this.comboBox_typeSport.TabIndex = 54;
            // 
            // dateTimePicker_dateJoindre
            // 
            this.dateTimePicker_dateJoindre.Enabled = false;
            this.dateTimePicker_dateJoindre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateJoindre.Location = new System.Drawing.Point(180, 186);
            this.dateTimePicker_dateJoindre.Name = "dateTimePicker_dateJoindre";
            this.dateTimePicker_dateJoindre.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker_dateJoindre.TabIndex = 53;
            this.dateTimePicker_dateJoindre.Value = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 52;
            this.label9.Text = "Date Paiement";
            // 
            // dateTimePicker_Datepataiement
            // 
            this.dateTimePicker_Datepataiement.Enabled = false;
            this.dateTimePicker_Datepataiement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Datepataiement.Location = new System.Drawing.Point(180, 269);
            this.dateTimePicker_Datepataiement.Name = "dateTimePicker_Datepataiement";
            this.dateTimePicker_Datepataiement.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker_Datepataiement.TabIndex = 51;
            this.dateTimePicker_Datepataiement.Value = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = " Type Sport";
            // 
            // txtBox_PrixMensuel
            // 
            this.txtBox_PrixMensuel.BackColor = System.Drawing.Color.White;
            this.txtBox_PrixMensuel.Enabled = false;
            this.txtBox_PrixMensuel.Location = new System.Drawing.Point(180, 139);
            this.txtBox_PrixMensuel.Name = "txtBox_PrixMensuel";
            this.txtBox_PrixMensuel.Size = new System.Drawing.Size(176, 20);
            this.txtBox_PrixMensuel.TabIndex = 49;
            this.txtBox_PrixMensuel.TextChanged += new System.EventHandler(this.txtBox_PrixMensuel_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = " Date  Joindre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Prix Mensuel";
            // 
            // comboBox_tempsSubscription
            // 
            this.comboBox_tempsSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tempsSubscription.Enabled = false;
            this.comboBox_tempsSubscription.FormattingEnabled = true;
            this.comboBox_tempsSubscription.Items.AddRange(new object[] {
            "1 Months",
            "2 Months",
            "3 Months",
            "6 Months",
            "9 Months",
            "12 Months"});
            this.comboBox_tempsSubscription.Location = new System.Drawing.Point(180, 309);
            this.comboBox_tempsSubscription.Name = "comboBox_tempsSubscription";
            this.comboBox_tempsSubscription.Size = new System.Drawing.Size(176, 21);
            this.comboBox_tempsSubscription.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "Temps Subscription";
            // 
            // rbSexe_feminin
            // 
            this.rbSexe_feminin.AutoSize = true;
            this.rbSexe_feminin.Enabled = false;
            this.rbSexe_feminin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSexe_feminin.Location = new System.Drawing.Point(286, 106);
            this.rbSexe_feminin.Name = "rbSexe_feminin";
            this.rbSexe_feminin.Size = new System.Drawing.Size(70, 19);
            this.rbSexe_feminin.TabIndex = 44;
            this.rbSexe_feminin.Text = "Feminin";
            this.rbSexe_feminin.UseVisualStyleBackColor = true;
            // 
            // rbSexe_masculin
            // 
            this.rbSexe_masculin.AutoSize = true;
            this.rbSexe_masculin.Enabled = false;
            this.rbSexe_masculin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSexe_masculin.Location = new System.Drawing.Point(180, 106);
            this.rbSexe_masculin.Name = "rbSexe_masculin";
            this.rbSexe_masculin.Size = new System.Drawing.Size(75, 19);
            this.rbSexe_masculin.TabIndex = 43;
            this.rbSexe_masculin.Text = "Masculin";
            this.rbSexe_masculin.UseVisualStyleBackColor = true;
            // 
            // txtBox_prenom
            // 
            this.txtBox_prenom.Enabled = false;
            this.txtBox_prenom.Location = new System.Drawing.Point(180, 71);
            this.txtBox_prenom.Name = "txtBox_prenom";
            this.txtBox_prenom.Size = new System.Drawing.Size(176, 20);
            this.txtBox_prenom.TabIndex = 42;
            this.txtBox_prenom.TextChanged += new System.EventHandler(this.txtBox_prenom_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nom";
            // 
            // txtBox_nom
            // 
            this.txtBox_nom.Enabled = false;
            this.txtBox_nom.Location = new System.Drawing.Point(180, 34);
            this.txtBox_nom.Multiline = true;
            this.txtBox_nom.Name = "txtBox_nom";
            this.txtBox_nom.Size = new System.Drawing.Size(176, 20);
            this.txtBox_nom.TabIndex = 38;
            this.txtBox_nom.TextChanged += new System.EventHandler(this.txtBox_nom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = " Prenom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = " Sexe";
            // 
            // btn_reinitialiser
            // 
            this.btn_reinitialiser.BackColor = System.Drawing.Color.Lime;
            this.btn_reinitialiser.Location = new System.Drawing.Point(91, 402);
            this.btn_reinitialiser.Name = "btn_reinitialiser";
            this.btn_reinitialiser.Size = new System.Drawing.Size(99, 42);
            this.btn_reinitialiser.TabIndex = 58;
            this.btn_reinitialiser.Text = "Reinitialiser";
            this.btn_reinitialiser.UseVisualStyleBackColor = false;
            this.btn_reinitialiser.Click += new System.EventHandler(this.btn_reinitialiser_Click);
            // 
            // eP_prenom
            // 
            this.eP_prenom.ContainerControl = this;
            // 
            // eP_nom
            // 
            this.eP_nom.ContainerControl = this;
            // 
            // eP_prixMensuel
            // 
            this.eP_prixMensuel.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_Datepataiement);
            this.groupBox1.Controls.Add(this.comboBox_typeSport);
            this.groupBox1.Controls.Add(this.txtBox_prenom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker_dateJoindre);
            this.groupBox1.Controls.Add(this.rbSexe_masculin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBox_nom);
            this.groupBox1.Controls.Add(this.rbSexe_feminin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_tempsSubscription);
            this.groupBox1.Controls.Add(this.txtBox_PrixMensuel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 361);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // ModifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_reinitialiser);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_modiferDGV);
            this.Controls.Add(this.btn_suppreime);
            this.Controls.Add(this.DGV_ModifierClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifierClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifierClient_FormClosed);
            this.Load += new System.EventHandler(this.ModifierClient_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ModifierClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_prenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_nom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_prixMensuel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_modiferDGV;
        private System.Windows.Forms.Button btn_suppreime;
        private System.Windows.Forms.DataGridView DGV_ModifierClient;
        private System.Windows.Forms.RadioButton rbSexe_feminin;
        private System.Windows.Forms.RadioButton rbSexe_masculin;
        private System.Windows.Forms.TextBox txtBox_prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_typeSport;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateJoindre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Datepataiement;
        private System.Windows.Forms.TextBox txtBox_PrixMensuel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_tempsSubscription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_prixMensuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_dateJoindre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_typeSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_datePaiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_tempsSubscription;
        private System.Windows.Forms.Button btn_reinitialiser;
        private System.Windows.Forms.ErrorProvider eP_prenom;
        private System.Windows.Forms.ErrorProvider eP_nom;
        private System.Windows.Forms.ErrorProvider eP_prixMensuel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}