namespace Salle_De_Sport
{
    partial class NouveauClient
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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_prenom = new System.Windows.Forms.TextBox();
            this.txtBox_PrixMensuel = new System.Windows.Forms.TextBox();
            this.rbSexe_masculin = new System.Windows.Forms.RadioButton();
            this.rbSexe_feminin = new System.Windows.Forms.RadioButton();
            this.btn_reinitialiser = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_Datepataiement = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_dateJoindre = new System.Windows.Forms.DateTimePicker();
            this.comboBox_typeSport = new System.Windows.Forms.ComboBox();
            this.comboBox_tempsSubscription = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tempsSubscription = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_prixMensuel = new System.Windows.Forms.Label();
            this.lbl_datePaiement = new System.Windows.Forms.Label();
            this.lbl_dateJoindre = new System.Windows.Forms.Label();
            this.lbl_typeSport = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_TempsSubscrption = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.eP_prenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.eP_nom = new System.Windows.Forms.ErrorProvider(this.components);
            this.eP_prixMensuel = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_prenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_nom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_prixMensuel)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prix Mensuel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date Joindre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sexe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // txtBox_nom
            // 
            this.txtBox_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_nom.Location = new System.Drawing.Point(147, 60);
            this.txtBox_nom.Name = "txtBox_nom";
            this.txtBox_nom.Size = new System.Drawing.Size(176, 21);
            this.txtBox_nom.TabIndex = 1;
            this.txtBox_nom.TextChanged += new System.EventHandler(this.txtBox_nom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtBox_prenom
            // 
            this.txtBox_prenom.BackColor = System.Drawing.Color.White;
            this.txtBox_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_prenom.Location = new System.Drawing.Point(147, 111);
            this.txtBox_prenom.Name = "txtBox_prenom";
            this.txtBox_prenom.Size = new System.Drawing.Size(176, 21);
            this.txtBox_prenom.TabIndex = 12;
            this.txtBox_prenom.TextChanged += new System.EventHandler(this.txtBox_prenom_TextChanged);
            // 
            // txtBox_PrixMensuel
            // 
            this.txtBox_PrixMensuel.BackColor = System.Drawing.Color.White;
            this.txtBox_PrixMensuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PrixMensuel.Location = new System.Drawing.Point(147, 222);
            this.txtBox_PrixMensuel.Name = "txtBox_PrixMensuel";
            this.txtBox_PrixMensuel.Size = new System.Drawing.Size(176, 21);
            this.txtBox_PrixMensuel.TabIndex = 16;
            this.txtBox_PrixMensuel.TextChanged += new System.EventHandler(this.txtBox_PrixMensuel_TextChanged);
            // 
            // rbSexe_masculin
            // 
            this.rbSexe_masculin.AutoSize = true;
            this.rbSexe_masculin.Checked = true;
            this.rbSexe_masculin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSexe_masculin.Location = new System.Drawing.Point(147, 163);
            this.rbSexe_masculin.Name = "rbSexe_masculin";
            this.rbSexe_masculin.Size = new System.Drawing.Size(79, 20);
            this.rbSexe_masculin.TabIndex = 19;
            this.rbSexe_masculin.TabStop = true;
            this.rbSexe_masculin.Text = "Masculin";
            this.rbSexe_masculin.UseVisualStyleBackColor = true;
            // 
            // rbSexe_feminin
            // 
            this.rbSexe_feminin.AutoSize = true;
            this.rbSexe_feminin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSexe_feminin.Location = new System.Drawing.Point(252, 163);
            this.rbSexe_feminin.Name = "rbSexe_feminin";
            this.rbSexe_feminin.Size = new System.Drawing.Size(73, 20);
            this.rbSexe_feminin.TabIndex = 20;
            this.rbSexe_feminin.Text = "Feminin";
            this.rbSexe_feminin.UseVisualStyleBackColor = true;
            // 
            // btn_reinitialiser
            // 
            this.btn_reinitialiser.BackColor = System.Drawing.Color.Lime;
            this.btn_reinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reinitialiser.Location = new System.Drawing.Point(341, 394);
            this.btn_reinitialiser.Name = "btn_reinitialiser";
            this.btn_reinitialiser.Size = new System.Drawing.Size(109, 50);
            this.btn_reinitialiser.TabIndex = 25;
            this.btn_reinitialiser.Text = "Reinitialiser";
            this.btn_reinitialiser.UseVisualStyleBackColor = false;
            this.btn_reinitialiser.Click += new System.EventHandler(this.btn_reinitialiser_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.Lime;
            this.btn_ajouter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.Location = new System.Drawing.Point(505, 394);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(112, 50);
            this.btn_ajouter.TabIndex = 26;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            this.btn_ajouter.MouseEnter += new System.EventHandler(this.btn_ajouter_MouseEnter);
            this.btn_ajouter.MouseLeave += new System.EventHandler(this.btn_ajouter_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Type Sport";
            // 
            // dateTimePicker_Datepataiement
            // 
            this.dateTimePicker_Datepataiement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Datepataiement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Datepataiement.Location = new System.Drawing.Point(214, 157);
            this.dateTimePicker_Datepataiement.Name = "dateTimePicker_Datepataiement";
            this.dateTimePicker_Datepataiement.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker_Datepataiement.TabIndex = 31;
            this.dateTimePicker_Datepataiement.Value = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            this.dateTimePicker_Datepataiement.ValueChanged += new System.EventHandler(this.dateTimePicker_Datepataiement_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Date Paiement";
            // 
            // dateTimePicker_dateJoindre
            // 
            this.dateTimePicker_dateJoindre.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dateJoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dateJoindre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateJoindre.Location = new System.Drawing.Point(214, 50);
            this.dateTimePicker_dateJoindre.Name = "dateTimePicker_dateJoindre";
            this.dateTimePicker_dateJoindre.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker_dateJoindre.TabIndex = 34;
            this.dateTimePicker_dateJoindre.Value = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            this.dateTimePicker_dateJoindre.ValueChanged += new System.EventHandler(this.dateTimePicker_dateJoindre_ValueChanged);
            // 
            // comboBox_typeSport
            // 
            this.comboBox_typeSport.BackColor = System.Drawing.Color.White;
            this.comboBox_typeSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typeSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_typeSport.ForeColor = System.Drawing.Color.Gray;
            this.comboBox_typeSport.FormattingEnabled = true;
            this.comboBox_typeSport.Items.AddRange(new object[] {
            "Karate",
            "Kung-fu",
            "Boxing",
            "Taek-wondo",
            "Musculation"});
            this.comboBox_typeSport.Location = new System.Drawing.Point(214, 100);
            this.comboBox_typeSport.Name = "comboBox_typeSport";
            this.comboBox_typeSport.Size = new System.Drawing.Size(176, 23);
            this.comboBox_typeSport.TabIndex = 35;
            this.comboBox_typeSport.SelectedIndexChanged += new System.EventHandler(this.comboBox_typeSport_SelectedIndexChanged);
            this.comboBox_typeSport.Click += new System.EventHandler(this.comboBox_typeSport_Click);
            // 
            // comboBox_tempsSubscription
            // 
            this.comboBox_tempsSubscription.BackColor = System.Drawing.Color.White;
            this.comboBox_tempsSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tempsSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tempsSubscription.ForeColor = System.Drawing.Color.Gray;
            this.comboBox_tempsSubscription.FormattingEnabled = true;
            this.comboBox_tempsSubscription.Items.AddRange(new object[] {
            "1 Months",
            "2 Months",
            "3 Months",
            "6 Months",
            "9 Months",
            "12 Months"});
            this.comboBox_tempsSubscription.Location = new System.Drawing.Point(216, 216);
            this.comboBox_tempsSubscription.Name = "comboBox_tempsSubscription";
            this.comboBox_tempsSubscription.Size = new System.Drawing.Size(176, 23);
            this.comboBox_tempsSubscription.TabIndex = 36;
            this.comboBox_tempsSubscription.SelectedIndexChanged += new System.EventHandler(this.comboBox_tempsSubscription_SelectedIndexChanged);
            this.comboBox_tempsSubscription.Click += new System.EventHandler(this.comboBox_tempsSubscription_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(348, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "DH";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.ForeColor = System.Drawing.Color.Red;
            this.lbl_nom.Location = new System.Drawing.Point(143, 82);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(0, 18);
            this.lbl_nom.TabIndex = 38;
            this.lbl_nom.Visible = false;
            this.lbl_nom.Click += new System.EventHandler(this.lbl_nom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lbl_tempsSubscription);
            this.groupBox1.Controls.Add(this.lbl_prenom);
            this.groupBox1.Controls.Add(this.lbl_nom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbSexe_feminin);
            this.groupBox1.Controls.Add(this.rbSexe_masculin);
            this.groupBox1.Controls.Add(this.txtBox_PrixMensuel);
            this.groupBox1.Controls.Add(this.lbl_prixMensuel);
            this.groupBox1.Controls.Add(this.txtBox_prenom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_nom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(23, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 312);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_tempsSubscription
            // 
            this.lbl_tempsSubscription.AutoSize = true;
            this.lbl_tempsSubscription.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tempsSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempsSubscription.ForeColor = System.Drawing.Color.Red;
            this.lbl_tempsSubscription.Location = new System.Drawing.Point(693, 287);
            this.lbl_tempsSubscription.Name = "lbl_tempsSubscription";
            this.lbl_tempsSubscription.Size = new System.Drawing.Size(0, 18);
            this.lbl_tempsSubscription.TabIndex = 42;
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenom.ForeColor = System.Drawing.Color.Red;
            this.lbl_prenom.Location = new System.Drawing.Point(143, 135);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(0, 18);
            this.lbl_prenom.TabIndex = 39;
            this.lbl_prenom.Visible = false;
            // 
            // lbl_prixMensuel
            // 
            this.lbl_prixMensuel.AutoSize = true;
            this.lbl_prixMensuel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prixMensuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prixMensuel.ForeColor = System.Drawing.Color.Red;
            this.lbl_prixMensuel.Location = new System.Drawing.Point(144, 246);
            this.lbl_prixMensuel.Name = "lbl_prixMensuel";
            this.lbl_prixMensuel.Size = new System.Drawing.Size(0, 18);
            this.lbl_prixMensuel.TabIndex = 40;
            this.lbl_prixMensuel.Visible = false;
            // 
            // lbl_datePaiement
            // 
            this.lbl_datePaiement.AutoSize = true;
            this.lbl_datePaiement.BackColor = System.Drawing.Color.Transparent;
            this.lbl_datePaiement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datePaiement.ForeColor = System.Drawing.Color.Red;
            this.lbl_datePaiement.Location = new System.Drawing.Point(212, 182);
            this.lbl_datePaiement.Name = "lbl_datePaiement";
            this.lbl_datePaiement.Size = new System.Drawing.Size(0, 18);
            this.lbl_datePaiement.TabIndex = 44;
            // 
            // lbl_dateJoindre
            // 
            this.lbl_dateJoindre.AutoSize = true;
            this.lbl_dateJoindre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dateJoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateJoindre.ForeColor = System.Drawing.Color.Red;
            this.lbl_dateJoindre.Location = new System.Drawing.Point(212, 75);
            this.lbl_dateJoindre.Name = "lbl_dateJoindre";
            this.lbl_dateJoindre.Size = new System.Drawing.Size(0, 18);
            this.lbl_dateJoindre.TabIndex = 43;
            // 
            // lbl_typeSport
            // 
            this.lbl_typeSport.AutoSize = true;
            this.lbl_typeSport.BackColor = System.Drawing.Color.Transparent;
            this.lbl_typeSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeSport.ForeColor = System.Drawing.Color.Red;
            this.lbl_typeSport.Location = new System.Drawing.Point(212, 129);
            this.lbl_typeSport.Name = "lbl_typeSport";
            this.lbl_typeSport.Size = new System.Drawing.Size(0, 18);
            this.lbl_typeSport.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_TempsSubscrption);
            this.groupBox2.Controls.Add(this.lbl_datePaiement);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_dateJoindre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_typeSport);
            this.groupBox2.Controls.Add(this.dateTimePicker_Datepataiement);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePicker_dateJoindre);
            this.groupBox2.Controls.Add(this.comboBox_typeSport);
            this.groupBox2.Controls.Add(this.comboBox_tempsSubscription);
            this.groupBox2.Location = new System.Drawing.Point(519, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 312);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // lbl_TempsSubscrption
            // 
            this.lbl_TempsSubscrption.AutoSize = true;
            this.lbl_TempsSubscrption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TempsSubscrption.ForeColor = System.Drawing.Color.Red;
            this.lbl_TempsSubscrption.Location = new System.Drawing.Point(213, 246);
            this.lbl_TempsSubscrption.Name = "lbl_TempsSubscrption";
            this.lbl_TempsSubscrption.Size = new System.Drawing.Size(0, 18);
            this.lbl_TempsSubscrption.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Temps Subscription";
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
            // NouveauClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_reinitialiser);
            this.Controls.Add(this.btn_ajouter);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NouveauClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NouveauClient_FormClosed);
            this.Load += new System.EventHandler(this.NouveauClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_prenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_nom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_prixMensuel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_prenom;
        private System.Windows.Forms.TextBox txtBox_PrixMensuel;
        private System.Windows.Forms.RadioButton rbSexe_masculin;
        private System.Windows.Forms.RadioButton rbSexe_feminin;
        private System.Windows.Forms.Button btn_reinitialiser;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Datepataiement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateJoindre;
        private System.Windows.Forms.ComboBox comboBox_typeSport;
        private System.Windows.Forms.ComboBox comboBox_tempsSubscription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_prixMensuel;
        private System.Windows.Forms.Label lbl_tempsSubscription;
        private System.Windows.Forms.Label lbl_typeSport;
        private System.Windows.Forms.Label lbl_datePaiement;
        private System.Windows.Forms.Label lbl_dateJoindre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider eP_prenom;
        private System.Windows.Forms.ErrorProvider eP_nom;
        private System.Windows.Forms.ErrorProvider eP_prixMensuel;
        private System.Windows.Forms.Label lbl_TempsSubscrption;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}