namespace Salle_De_Sport
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_motPasse = new System.Windows.Forms.TextBox();
            this.txtBox_utilisateur = new System.Windows.Forms.TextBox();
            this.lbl_PasswordLogin = new System.Windows.Forms.Label();
            this.lbl_NomLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ResetLogin = new System.Windows.Forms.Button();
            this.btn_ConexionLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(406, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Club";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fitness ";
            // 
            // txtBox_motPasse
            // 
            this.txtBox_motPasse.Location = new System.Drawing.Point(372, 211);
            this.txtBox_motPasse.Name = "txtBox_motPasse";
            this.txtBox_motPasse.PasswordChar = '*';
            this.txtBox_motPasse.Size = new System.Drawing.Size(113, 20);
            this.txtBox_motPasse.TabIndex = 19;
            // 
            // txtBox_utilisateur
            // 
            this.txtBox_utilisateur.Location = new System.Drawing.Point(372, 177);
            this.txtBox_utilisateur.Name = "txtBox_utilisateur";
            this.txtBox_utilisateur.Size = new System.Drawing.Size(113, 20);
            this.txtBox_utilisateur.TabIndex = 0;
            // 
            // lbl_PasswordLogin
            // 
            this.lbl_PasswordLogin.AutoSize = true;
            this.lbl_PasswordLogin.Location = new System.Drawing.Point(287, 214);
            this.lbl_PasswordLogin.Name = "lbl_PasswordLogin";
            this.lbl_PasswordLogin.Size = new System.Drawing.Size(53, 13);
            this.lbl_PasswordLogin.TabIndex = 17;
            this.lbl_PasswordLogin.Text = "Password";
            // 
            // lbl_NomLogin
            // 
            this.lbl_NomLogin.AutoSize = true;
            this.lbl_NomLogin.Location = new System.Drawing.Point(287, 180);
            this.lbl_NomLogin.Name = "lbl_NomLogin";
            this.lbl_NomLogin.Size = new System.Drawing.Size(29, 13);
            this.lbl_NomLogin.TabIndex = 16;
            this.lbl_NomLogin.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(352, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sign Up";
            // 
            // btn_ResetLogin
            // 
            this.btn_ResetLogin.Location = new System.Drawing.Point(304, 274);
            this.btn_ResetLogin.Name = "btn_ResetLogin";
            this.btn_ResetLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_ResetLogin.TabIndex = 12;
            this.btn_ResetLogin.Text = "Reset";
            this.btn_ResetLogin.UseVisualStyleBackColor = true;
            this.btn_ResetLogin.Click += new System.EventHandler(this.btn_ResetLogin_Click);
            // 
            // btn_ConexionLogin
            // 
            this.btn_ConexionLogin.Location = new System.Drawing.Point(397, 274);
            this.btn_ConexionLogin.Name = "btn_ConexionLogin";
            this.btn_ConexionLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_ConexionLogin.TabIndex = 11;
            this.btn_ConexionLogin.Text = "Log in";
            this.btn_ConexionLogin.UseVisualStyleBackColor = true;
            this.btn_ConexionLogin.Click += new System.EventHandler(this.btn_ConexionLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(585, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_motPasse);
            this.Controls.Add(this.txtBox_utilisateur);
            this.Controls.Add(this.lbl_PasswordLogin);
            this.Controls.Add(this.lbl_NomLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ResetLogin);
            this.Controls.Add(this.btn_ConexionLogin);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_motPasse;
        private System.Windows.Forms.TextBox txtBox_utilisateur;
        private System.Windows.Forms.Label lbl_PasswordLogin;
        private System.Windows.Forms.Label lbl_NomLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ResetLogin;
        private System.Windows.Forms.Button btn_ConexionLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

