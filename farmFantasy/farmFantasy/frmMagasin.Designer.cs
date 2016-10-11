namespace farmFantasy
{
    partial class frmMagasin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMagasin));
            this.gbxSemence = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrixUnite = new System.Windows.Forms.Label();
            this.lblPrixProduit = new System.Windows.Forms.Label();
            this.nudQuantiteProduit = new System.Windows.Forms.NumericUpDown();
            this.btnAchatProduit = new System.Windows.Forms.Button();
            this.dudVente = new System.Windows.Forms.DomainUpDown();
            this.btnVenteProduit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxAnimaux = new System.Windows.Forms.GroupBox();
            this.lblTotAnim = new System.Windows.Forms.Label();
            this.lblPrixVache = new System.Windows.Forms.Label();
            this.lblPrixCochon = new System.Windows.Forms.Label();
            this.lblPrixMouton = new System.Windows.Forms.Label();
            this.lblPrixPoule = new System.Windows.Forms.Label();
            this.btnAcheterAnimal = new System.Windows.Forms.Button();
            this.nudVache = new System.Windows.Forms.NumericUpDown();
            this.nudCochon = new System.Windows.Forms.NumericUpDown();
            this.nudMouton = new System.Windows.Forms.NumericUpDown();
            this.nudPoule = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxProd = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblArgentMagas = new System.Windows.Forms.Label();
            this.gbxSemence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantiteProduit)).BeginInit();
            this.gbxAnimaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCochon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoule)).BeginInit();
            this.gbxProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSemence
            // 
            this.gbxSemence.Controls.Add(this.label4);
            this.gbxSemence.Controls.Add(this.label2);
            this.gbxSemence.Controls.Add(this.label1);
            this.gbxSemence.Controls.Add(this.lblStock);
            this.gbxSemence.Controls.Add(this.lblPrixUnite);
            this.gbxSemence.Controls.Add(this.lblPrixProduit);
            this.gbxSemence.Controls.Add(this.nudQuantiteProduit);
            this.gbxSemence.Controls.Add(this.btnAchatProduit);
            this.gbxSemence.Controls.Add(this.dudVente);
            this.gbxSemence.Controls.Add(this.btnVenteProduit);
            this.gbxSemence.Location = new System.Drawing.Point(12, 32);
            this.gbxSemence.Name = "gbxSemence";
            this.gbxSemence.Size = new System.Drawing.Size(219, 217);
            this.gbxSemence.TabIndex = 1;
            this.gbxSemence.TabStop = false;
            this.gbxSemence.Text = "Semence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stock :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Prix a l\'unité :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Prix Total :";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(148, 96);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(13, 13);
            this.lblStock.TabIndex = 23;
            this.lblStock.Text = "0";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // lblPrixUnite
            // 
            this.lblPrixUnite.AutoSize = true;
            this.lblPrixUnite.Location = new System.Drawing.Point(148, 121);
            this.lblPrixUnite.Name = "lblPrixUnite";
            this.lblPrixUnite.Size = new System.Drawing.Size(13, 13);
            this.lblPrixUnite.TabIndex = 23;
            this.lblPrixUnite.Text = "0";
            // 
            // lblPrixProduit
            // 
            this.lblPrixProduit.AutoSize = true;
            this.lblPrixProduit.Location = new System.Drawing.Point(148, 148);
            this.lblPrixProduit.Name = "lblPrixProduit";
            this.lblPrixProduit.Size = new System.Drawing.Size(13, 13);
            this.lblPrixProduit.TabIndex = 23;
            this.lblPrixProduit.Text = "0";
            // 
            // nudQuantiteProduit
            // 
            this.nudQuantiteProduit.Location = new System.Drawing.Point(69, 55);
            this.nudQuantiteProduit.Name = "nudQuantiteProduit";
            this.nudQuantiteProduit.Size = new System.Drawing.Size(87, 20);
            this.nudQuantiteProduit.TabIndex = 22;
            this.nudQuantiteProduit.ValueChanged += new System.EventHandler(this.nudQuantiteProduit_ValueChanged);
            // 
            // btnAchatProduit
            // 
            this.btnAchatProduit.Location = new System.Drawing.Point(111, 175);
            this.btnAchatProduit.Name = "btnAchatProduit";
            this.btnAchatProduit.Size = new System.Drawing.Size(75, 23);
            this.btnAchatProduit.TabIndex = 20;
            this.btnAchatProduit.Text = "Acheter";
            this.btnAchatProduit.UseVisualStyleBackColor = true;
            this.btnAchatProduit.Click += new System.EventHandler(this.btnAchatProduit_Click);
            // 
            // dudVente
            // 
            this.dudVente.Location = new System.Drawing.Point(69, 29);
            this.dudVente.Name = "dudVente";
            this.dudVente.ReadOnly = true;
            this.dudVente.Size = new System.Drawing.Size(87, 20);
            this.dudVente.TabIndex = 21;
            this.dudVente.SelectedItemChanged += new System.EventHandler(this.dudVente_SelectedItemChanged);
            // 
            // btnVenteProduit
            // 
            this.btnVenteProduit.Location = new System.Drawing.Point(30, 175);
            this.btnVenteProduit.Name = "btnVenteProduit";
            this.btnVenteProduit.Size = new System.Drawing.Size(75, 23);
            this.btnVenteProduit.TabIndex = 20;
            this.btnVenteProduit.Text = "Vendre";
            this.btnVenteProduit.UseVisualStyleBackColor = true;
            this.btnVenteProduit.Click += new System.EventHandler(this.btnVenteProduit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "CHF";
            // 
            // gbxAnimaux
            // 
            this.gbxAnimaux.Controls.Add(this.lblTotAnim);
            this.gbxAnimaux.Controls.Add(this.lblPrixVache);
            this.gbxAnimaux.Controls.Add(this.lblPrixCochon);
            this.gbxAnimaux.Controls.Add(this.lblPrixMouton);
            this.gbxAnimaux.Controls.Add(this.lblPrixPoule);
            this.gbxAnimaux.Controls.Add(this.btnAcheterAnimal);
            this.gbxAnimaux.Controls.Add(this.nudVache);
            this.gbxAnimaux.Controls.Add(this.nudCochon);
            this.gbxAnimaux.Controls.Add(this.nudMouton);
            this.gbxAnimaux.Controls.Add(this.nudPoule);
            this.gbxAnimaux.Controls.Add(this.label10);
            this.gbxAnimaux.Controls.Add(this.label11);
            this.gbxAnimaux.Controls.Add(this.label12);
            this.gbxAnimaux.Controls.Add(this.label13);
            this.gbxAnimaux.Location = new System.Drawing.Point(237, 32);
            this.gbxAnimaux.Name = "gbxAnimaux";
            this.gbxAnimaux.Size = new System.Drawing.Size(230, 217);
            this.gbxAnimaux.TabIndex = 4;
            this.gbxAnimaux.TabStop = false;
            this.gbxAnimaux.Text = "Animaux";
            // 
            // lblTotAnim
            // 
            this.lblTotAnim.AutoSize = true;
            this.lblTotAnim.Location = new System.Drawing.Point(142, 158);
            this.lblTotAnim.Name = "lblTotAnim";
            this.lblTotAnim.Size = new System.Drawing.Size(31, 13);
            this.lblTotAnim.TabIndex = 17;
            this.lblTotAnim.Text = "Total";
            // 
            // lblPrixVache
            // 
            this.lblPrixVache.AutoSize = true;
            this.lblPrixVache.Location = new System.Drawing.Point(157, 116);
            this.lblPrixVache.Name = "lblPrixVache";
            this.lblPrixVache.Size = new System.Drawing.Size(13, 13);
            this.lblPrixVache.TabIndex = 16;
            this.lblPrixVache.Text = "0";
            // 
            // lblPrixCochon
            // 
            this.lblPrixCochon.AutoSize = true;
            this.lblPrixCochon.Location = new System.Drawing.Point(157, 88);
            this.lblPrixCochon.Name = "lblPrixCochon";
            this.lblPrixCochon.Size = new System.Drawing.Size(13, 13);
            this.lblPrixCochon.TabIndex = 16;
            this.lblPrixCochon.Text = "0";
            // 
            // lblPrixMouton
            // 
            this.lblPrixMouton.AutoSize = true;
            this.lblPrixMouton.Location = new System.Drawing.Point(157, 59);
            this.lblPrixMouton.Name = "lblPrixMouton";
            this.lblPrixMouton.Size = new System.Drawing.Size(13, 13);
            this.lblPrixMouton.TabIndex = 16;
            this.lblPrixMouton.Text = "0";
            // 
            // lblPrixPoule
            // 
            this.lblPrixPoule.AutoSize = true;
            this.lblPrixPoule.Location = new System.Drawing.Point(157, 29);
            this.lblPrixPoule.Name = "lblPrixPoule";
            this.lblPrixPoule.Size = new System.Drawing.Size(13, 13);
            this.lblPrixPoule.TabIndex = 16;
            this.lblPrixPoule.Text = "0";
            // 
            // btnAcheterAnimal
            // 
            this.btnAcheterAnimal.Location = new System.Drawing.Point(66, 175);
            this.btnAcheterAnimal.Name = "btnAcheterAnimal";
            this.btnAcheterAnimal.Size = new System.Drawing.Size(60, 23);
            this.btnAcheterAnimal.TabIndex = 15;
            this.btnAcheterAnimal.Text = "Acheter";
            this.btnAcheterAnimal.UseVisualStyleBackColor = true;
            this.btnAcheterAnimal.Click += new System.EventHandler(this.transaction_Click);
            // 
            // nudVache
            // 
            this.nudVache.Location = new System.Drawing.Point(81, 114);
            this.nudVache.Name = "nudVache";
            this.nudVache.Size = new System.Drawing.Size(60, 20);
            this.nudVache.TabIndex = 11;
            this.nudVache.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudCochon
            // 
            this.nudCochon.Location = new System.Drawing.Point(81, 86);
            this.nudCochon.Name = "nudCochon";
            this.nudCochon.Size = new System.Drawing.Size(60, 20);
            this.nudCochon.TabIndex = 12;
            this.nudCochon.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudMouton
            // 
            this.nudMouton.Location = new System.Drawing.Point(81, 57);
            this.nudMouton.Name = "nudMouton";
            this.nudMouton.Size = new System.Drawing.Size(60, 20);
            this.nudMouton.TabIndex = 13;
            this.nudMouton.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudPoule
            // 
            this.nudPoule.Location = new System.Drawing.Point(81, 27);
            this.nudPoule.Name = "nudPoule";
            this.nudPoule.Size = new System.Drawing.Size(60, 20);
            this.nudPoule.TabIndex = 14;
            this.nudPoule.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Vache : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cochon :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Mouton :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Poule :";
            // 
            // gbxProd
            // 
            this.gbxProd.Controls.Add(this.label16);
            this.gbxProd.Controls.Add(this.label15);
            this.gbxProd.Controls.Add(this.label14);
            this.gbxProd.Location = new System.Drawing.Point(12, 255);
            this.gbxProd.Name = "gbxProd";
            this.gbxProd.Size = new System.Drawing.Size(455, 119);
            this.gbxProd.TabIndex = 3;
            this.gbxProd.TabStop = false;
            this.gbxProd.Text = "Production des animaux";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(331, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "La laine se vend à 150 CHF l\'unité mais prend 2 heures à se produire";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Les oeufs se vendent a 0.20 CHF/Unité";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(346, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lait se vend toutes les 10 minutes pour le nombre de vache X 1.25 CHF";
            // 
            // lblArgentMagas
            // 
            this.lblArgentMagas.AutoSize = true;
            this.lblArgentMagas.Location = new System.Drawing.Point(46, 9);
            this.lblArgentMagas.Name = "lblArgentMagas";
            this.lblArgentMagas.Size = new System.Drawing.Size(33, 13);
            this.lblArgentMagas.TabIndex = 5;
            this.lblArgentMagas.Text = "Label";
            // 
            // frmMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(482, 384);
            this.Controls.Add(this.lblArgentMagas);
            this.Controls.Add(this.gbxProd);
            this.Controls.Add(this.gbxAnimaux);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbxSemence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMagasin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magasin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMagasin_FormClosing);
            this.Load += new System.EventHandler(this.frmMagasin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMagasin_KeyPress);
            this.gbxSemence.ResumeLayout(false);
            this.gbxSemence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantiteProduit)).EndInit();
            this.gbxAnimaux.ResumeLayout(false);
            this.gbxAnimaux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCochon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoule)).EndInit();
            this.gbxProd.ResumeLayout(false);
            this.gbxProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSemence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxAnimaux;
        private System.Windows.Forms.Button btnAcheterAnimal;
        private System.Windows.Forms.NumericUpDown nudVache;
        private System.Windows.Forms.NumericUpDown nudCochon;
        private System.Windows.Forms.NumericUpDown nudMouton;
        private System.Windows.Forms.NumericUpDown nudPoule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbxProd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblArgentMagas;
        private System.Windows.Forms.Label lblPrixVache;
        private System.Windows.Forms.Label lblPrixCochon;
        private System.Windows.Forms.Label lblPrixMouton;
        private System.Windows.Forms.Label lblPrixPoule;
        private System.Windows.Forms.Label lblTotAnim;
        private System.Windows.Forms.Button btnAchatProduit;
        private System.Windows.Forms.Button btnVenteProduit;
        private System.Windows.Forms.DomainUpDown dudVente;
        private System.Windows.Forms.NumericUpDown nudQuantiteProduit;
        private System.Windows.Forms.Label lblPrixProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrixUnite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStock;
    }
}