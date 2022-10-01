namespace Salle_De_Sport
{
    partial class NouveauEntraîneur
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
            this.lbl_nom = new System.Windows.Forms.Label();
            this.rbSexe_femininEntraineur = new System.Windows.Forms.RadioButton();
            this.rbSexe_masculinEntraineur = new System.Windows.Forms.RadioButton();
            this.txtBox_prenomEntraineur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_nomEntraineur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_typeSportEntraineur = new System.Windows.Forms.Label();
            this.dateTimePicker_dateJoindreEntraineur = new System.Windows.Forms.DateTimePicker();
            this.comboBox_typeSportEntraineur = new System.Windows.Forms.ComboBox();
            this.btn_reinitialiserEntraineur = new System.Windows.Forms.Button();
            this.btn_ajouterEntraineur = new System.Windows.Forms.Button();
            this.eP_prenomEntraineur = new System.Windows.Forms.ErrorProvider(this.components);
            this.eP_nomEntraineur = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_nomEntraineur = new System.Windows.Forms.Label();
            this.lbl_dateJoindreEntraineur = new System.Windows.Forms.Label();
            this.lbl_prenomEntraineur = new System.Windows.Forms.Label();
            this.DGV_Entraineur = new System.Windows.Forms.DataGridView();
            this.Col_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_dateJoindre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_typeSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eP_prenomEntraineur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_nomEntraineur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Entraineur)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.ForeColor = System.Drawing.Color.Red;
            this.lbl_nom.Location = new System.Drawing.Point(195, 99);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(0, 18);
            this.lbl_nom.TabIndex = 49;
            this.lbl_nom.Visible = false;
            // 
            // rbSexe_femininEntraineur
            // 
            this.rbSexe_femininEntraineur.AutoSize = true;
            this.rbSexe_femininEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSexe_femininEntraineur.Location = new System.Drawing.Point(297, 187);
            this.rbSexe_femininEntraineur.Name = "rbSexe_femininEntraineur";
            this.rbSexe_femininEntraineur.Size = new System.Drawing.Size(73, 20);
            this.rbSexe_femininEntraineur.TabIndex = 48;
            this.rbSexe_femininEntraineur.Text = "Feminin";
            this.rbSexe_femininEntraineur.UseVisualStyleBackColor = true;
            // 
            // rbSexe_masculinEntraineur
            // 
            this.rbSexe_masculinEntraineur.AutoSize = true;
            this.rbSexe_masculinEntraineur.Checked = true;
            this.rbSexe_masculinEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSexe_masculinEntraineur.Location = new System.Drawing.Point(194, 187);
            this.rbSexe_masculinEntraineur.Name = "rbSexe_masculinEntraineur";
            this.rbSexe_masculinEntraineur.Size = new System.Drawing.Size(79, 20);
            this.rbSexe_masculinEntraineur.TabIndex = 47;
            this.rbSexe_masculinEntraineur.TabStop = true;
            this.rbSexe_masculinEntraineur.Text = "Masculin";
            this.rbSexe_masculinEntraineur.UseVisualStyleBackColor = true;
            // 
            // txtBox_prenomEntraineur
            // 
            this.txtBox_prenomEntraineur.BackColor = System.Drawing.Color.White;
            this.txtBox_prenomEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_prenomEntraineur.Location = new System.Drawing.Point(194, 130);
            this.txtBox_prenomEntraineur.Name = "txtBox_prenomEntraineur";
            this.txtBox_prenomEntraineur.Size = new System.Drawing.Size(178, 21);
            this.txtBox_prenomEntraineur.TabIndex = 45;
            this.txtBox_prenomEntraineur.TextChanged += new System.EventHandler(this.txtBox_prenomEntraineur_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nom";
            // 
            // txtBox_nomEntraineur
            // 
            this.txtBox_nomEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_nomEntraineur.Location = new System.Drawing.Point(194, 74);
            this.txtBox_nomEntraineur.Name = "txtBox_nomEntraineur";
            this.txtBox_nomEntraineur.Size = new System.Drawing.Size(178, 21);
            this.txtBox_nomEntraineur.TabIndex = 41;
            this.txtBox_nomEntraineur.TextChanged += new System.EventHandler(this.txtBox_nomEntraineur_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Sexe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Date Joindre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Type Sport";
            // 
            // lbl_typeSportEntraineur
            // 
            this.lbl_typeSportEntraineur.AutoSize = true;
            this.lbl_typeSportEntraineur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_typeSportEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeSportEntraineur.ForeColor = System.Drawing.Color.Red;
            this.lbl_typeSportEntraineur.Location = new System.Drawing.Point(201, 331);
            this.lbl_typeSportEntraineur.Name = "lbl_typeSportEntraineur";
            this.lbl_typeSportEntraineur.Size = new System.Drawing.Size(0, 18);
            this.lbl_typeSportEntraineur.TabIndex = 55;
            // 
            // dateTimePicker_dateJoindreEntraineur
            // 
            this.dateTimePicker_dateJoindreEntraineur.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dateJoindreEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dateJoindreEntraineur.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateJoindreEntraineur.Location = new System.Drawing.Point(194, 237);
            this.dateTimePicker_dateJoindreEntraineur.Name = "dateTimePicker_dateJoindreEntraineur";
            this.dateTimePicker_dateJoindreEntraineur.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker_dateJoindreEntraineur.TabIndex = 53;
            this.dateTimePicker_dateJoindreEntraineur.Value = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            this.dateTimePicker_dateJoindreEntraineur.ValueChanged += new System.EventHandler(this.dateTimePicker_dateJoindreEntraineur_ValueChanged);
            // 
            // comboBox_typeSportEntraineur
            // 
            this.comboBox_typeSportEntraineur.BackColor = System.Drawing.Color.White;
            this.comboBox_typeSportEntraineur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typeSportEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_typeSportEntraineur.ForeColor = System.Drawing.Color.Gray;
            this.comboBox_typeSportEntraineur.FormattingEnabled = true;
            this.comboBox_typeSportEntraineur.Location = new System.Drawing.Point(194, 305);
            this.comboBox_typeSportEntraineur.Name = "comboBox_typeSportEntraineur";
            this.comboBox_typeSportEntraineur.Size = new System.Drawing.Size(176, 23);
            this.comboBox_typeSportEntraineur.TabIndex = 54;
            this.comboBox_typeSportEntraineur.SelectedIndexChanged += new System.EventHandler(this.comboBox_typeSportEntraineur_SelectedIndexChanged);
            // 
            // btn_reinitialiserEntraineur
            // 
            this.btn_reinitialiserEntraineur.BackColor = System.Drawing.Color.Lime;
            this.btn_reinitialiserEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reinitialiserEntraineur.Location = new System.Drawing.Point(83, 378);
            this.btn_reinitialiserEntraineur.Name = "btn_reinitialiserEntraineur";
            this.btn_reinitialiserEntraineur.Size = new System.Drawing.Size(109, 50);
            this.btn_reinitialiserEntraineur.TabIndex = 57;
            this.btn_reinitialiserEntraineur.Text = "Reinitialiser";
            this.btn_reinitialiserEntraineur.UseVisualStyleBackColor = false;
            this.btn_reinitialiserEntraineur.Click += new System.EventHandler(this.btn_reinitialiserEntraineur_Click);
            // 
            // btn_ajouterEntraineur
            // 
            this.btn_ajouterEntraineur.BackColor = System.Drawing.Color.Lime;
            this.btn_ajouterEntraineur.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ajouterEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterEntraineur.Location = new System.Drawing.Point(246, 378);
            this.btn_ajouterEntraineur.Name = "btn_ajouterEntraineur";
            this.btn_ajouterEntraineur.Size = new System.Drawing.Size(112, 50);
            this.btn_ajouterEntraineur.TabIndex = 58;
            this.btn_ajouterEntraineur.Text = "Ajouter";
            this.btn_ajouterEntraineur.UseVisualStyleBackColor = false;
            this.btn_ajouterEntraineur.Click += new System.EventHandler(this.btn_ajouterEntraineur_Click);
            // 
            // eP_prenomEntraineur
            // 
            this.eP_prenomEntraineur.ContainerControl = this;
            // 
            // eP_nomEntraineur
            // 
            this.eP_nomEntraineur.ContainerControl = this;
            // 
            // lbl_nomEntraineur
            // 
            this.lbl_nomEntraineur.AutoSize = true;
            this.lbl_nomEntraineur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEntraineur.ForeColor = System.Drawing.Color.Red;
            this.lbl_nomEntraineur.Location = new System.Drawing.Point(201, 99);
            this.lbl_nomEntraineur.Name = "lbl_nomEntraineur";
            this.lbl_nomEntraineur.Size = new System.Drawing.Size(12, 18);
            this.lbl_nomEntraineur.TabIndex = 59;
            this.lbl_nomEntraineur.Text = " ";
            this.lbl_nomEntraineur.Visible = false;
            // 
            // lbl_dateJoindreEntraineur
            // 
            this.lbl_dateJoindreEntraineur.AutoSize = true;
            this.lbl_dateJoindreEntraineur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dateJoindreEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateJoindreEntraineur.ForeColor = System.Drawing.Color.Red;
            this.lbl_dateJoindreEntraineur.Location = new System.Drawing.Point(196, 267);
            this.lbl_dateJoindreEntraineur.Name = "lbl_dateJoindreEntraineur";
            this.lbl_dateJoindreEntraineur.Size = new System.Drawing.Size(12, 18);
            this.lbl_dateJoindreEntraineur.TabIndex = 61;
            this.lbl_dateJoindreEntraineur.Text = " ";
            // 
            // lbl_prenomEntraineur
            // 
            this.lbl_prenomEntraineur.AutoSize = true;
            this.lbl_prenomEntraineur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prenomEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenomEntraineur.ForeColor = System.Drawing.Color.Red;
            this.lbl_prenomEntraineur.Location = new System.Drawing.Point(201, 155);
            this.lbl_prenomEntraineur.Name = "lbl_prenomEntraineur";
            this.lbl_prenomEntraineur.Size = new System.Drawing.Size(12, 18);
            this.lbl_prenomEntraineur.TabIndex = 60;
            this.lbl_prenomEntraineur.Text = " ";
            this.lbl_prenomEntraineur.Visible = false;
            // 
            // DGV_Entraineur
            // 
            this.DGV_Entraineur.AllowUserToAddRows = false;
            this.DGV_Entraineur.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.DGV_Entraineur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Entraineur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Entraineur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Nom,
            this.Col_prenom,
            this.Col_Sexe,
            this.Col_dateJoindre,
            this.Col_typeSport});
            this.DGV_Entraineur.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Entraineur.Location = new System.Drawing.Point(418, 120);
            this.DGV_Entraineur.MultiSelect = false;
            this.DGV_Entraineur.Name = "DGV_Entraineur";
            this.DGV_Entraineur.ReadOnly = true;
            this.DGV_Entraineur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Entraineur.Size = new System.Drawing.Size(542, 244);
            this.DGV_Entraineur.TabIndex = 63;
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
            // NouveauEntraîneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 485);
            this.Controls.Add(this.DGV_Entraineur);
            this.Controls.Add(this.lbl_dateJoindreEntraineur);
            this.Controls.Add(this.lbl_prenomEntraineur);
            this.Controls.Add(this.lbl_nomEntraineur);
            this.Controls.Add(this.btn_reinitialiserEntraineur);
            this.Controls.Add(this.btn_ajouterEntraineur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_typeSportEntraineur);
            this.Controls.Add(this.dateTimePicker_dateJoindreEntraineur);
            this.Controls.Add(this.comboBox_typeSportEntraineur);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.rbSexe_femininEntraineur);
            this.Controls.Add(this.rbSexe_masculinEntraineur);
            this.Controls.Add(this.txtBox_prenomEntraineur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_nomEntraineur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NouveauEntraîneur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NouveauEntraîneur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NouveauEntraîneur_FormClosed);
            this.Load += new System.EventHandler(this.NouveauEntraîneur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eP_prenomEntraineur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_nomEntraineur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Entraineur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.RadioButton rbSexe_femininEntraineur;
        private System.Windows.Forms.RadioButton rbSexe_masculinEntraineur;
        private System.Windows.Forms.TextBox txtBox_prenomEntraineur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_nomEntraineur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_typeSportEntraineur;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateJoindreEntraineur;
        private System.Windows.Forms.ComboBox comboBox_typeSportEntraineur;
        private System.Windows.Forms.Button btn_reinitialiserEntraineur;
        private System.Windows.Forms.Button btn_ajouterEntraineur;
        private System.Windows.Forms.ErrorProvider eP_prenomEntraineur;
        private System.Windows.Forms.ErrorProvider eP_nomEntraineur;
        private System.Windows.Forms.Label lbl_nomEntraineur;
        private System.Windows.Forms.Label lbl_dateJoindreEntraineur;
        private System.Windows.Forms.Label lbl_prenomEntraineur;
        private System.Windows.Forms.DataGridView DGV_Entraineur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_dateJoindre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_typeSport;
    }
}