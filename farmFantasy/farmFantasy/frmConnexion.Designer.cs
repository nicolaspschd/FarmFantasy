namespace farmFantasy
{
    partial class frmConnexion
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
            this.lblTitreConnexion = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.tbxPseudo = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblConfmdp = new System.Windows.Forms.Label();
            this.tbxConfMdp = new System.Windows.Forms.TextBox();
            this.lblAvert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitreConnexion
            // 
            this.lblTitreConnexion.AutoSize = true;
            this.lblTitreConnexion.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreConnexion.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitreConnexion.Location = new System.Drawing.Point(40, 44);
            this.lblTitreConnexion.Name = "lblTitreConnexion";
            this.lblTitreConnexion.Size = new System.Drawing.Size(457, 73);
            this.lblTitreConnexion.TabIndex = 0;
            this.lblTitreConnexion.Text = "Farm Fantasy ";
            // 
            // btnInscription
            // 
            this.btnInscription.BackColor = System.Drawing.Color.Transparent;
            this.btnInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInscription.Location = new System.Drawing.Point(334, 389);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(163, 48);
            this.btnInscription.TabIndex = 1;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.UseVisualStyleBackColor = false;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(334, 337);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(163, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Se connecter";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.BackColor = System.Drawing.Color.Transparent;
            this.lblPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudo.ForeColor = System.Drawing.Color.Yellow;
            this.lblPseudo.Location = new System.Drawing.Point(12, 168);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(116, 29);
            this.lblPseudo.TabIndex = 3;
            this.lblPseudo.Text = "Pseudo :";
            // 
            // tbxPseudo
            // 
            this.tbxPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPseudo.Location = new System.Drawing.Point(251, 168);
            this.tbxPseudo.Multiline = true;
            this.tbxPseudo.Name = "tbxPseudo";
            this.tbxPseudo.Size = new System.Drawing.Size(229, 29);
            this.tbxPseudo.TabIndex = 4;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.BackColor = System.Drawing.Color.Transparent;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.Yellow;
            this.lblMdp.Location = new System.Drawing.Point(12, 209);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(184, 29);
            this.lblMdp.TabIndex = 5;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // tbxMdp
            // 
            this.tbxMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMdp.Location = new System.Drawing.Point(251, 209);
            this.tbxMdp.Multiline = true;
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.PasswordChar = '*';
            this.tbxMdp.Size = new System.Drawing.Size(229, 29);
            this.tbxMdp.TabIndex = 6;
            this.tbxMdp.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lblConfmdp
            // 
            this.lblConfmdp.AutoSize = true;
            this.lblConfmdp.BackColor = System.Drawing.Color.Transparent;
            this.lblConfmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfmdp.ForeColor = System.Drawing.Color.Yellow;
            this.lblConfmdp.Location = new System.Drawing.Point(12, 257);
            this.lblConfmdp.Name = "lblConfmdp";
            this.lblConfmdp.Size = new System.Drawing.Size(233, 29);
            this.lblConfmdp.TabIndex = 7;
            this.lblConfmdp.Text = "Confirmation mdp :";
            this.lblConfmdp.Visible = false;
            // 
            // tbxConfMdp
            // 
            this.tbxConfMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfMdp.Location = new System.Drawing.Point(251, 257);
            this.tbxConfMdp.Multiline = true;
            this.tbxConfMdp.Name = "tbxConfMdp";
            this.tbxConfMdp.PasswordChar = '*';
            this.tbxConfMdp.Size = new System.Drawing.Size(229, 29);
            this.tbxConfMdp.TabIndex = 8;
            this.tbxConfMdp.Visible = false;
            this.tbxConfMdp.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lblAvert
            // 
            this.lblAvert.AutoSize = true;
            this.lblAvert.Location = new System.Drawing.Point(257, 302);
            this.lblAvert.Name = "lblAvert";
            this.lblAvert.Size = new System.Drawing.Size(35, 13);
            this.lblAvert.TabIndex = 9;
            this.lblAvert.Text = "label1";
            this.lblAvert.Visible = false;
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::farmFantasy.Properties.Resources.herbe;
            this.ClientSize = new System.Drawing.Size(521, 449);
            this.Controls.Add(this.lblAvert);
            this.Controls.Add(this.tbxConfMdp);
            this.Controls.Add(this.lblConfmdp);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.tbxPseudo);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.lblTitreConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConnexion";
            this.Text = "frmConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreConnexion;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.TextBox tbxPseudo;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.Label lblConfmdp;
        private System.Windows.Forms.TextBox tbxConfMdp;
        private System.Windows.Forms.Label lblAvert;
    }
}