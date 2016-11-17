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
            this.btnVenteProduit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxAnimaux = new System.Windows.Forms.GroupBox();
            this.btnAcheterAnimal = new System.Windows.Forms.Button();
            this.gbxProd = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblArgentMagas = new System.Windows.Forms.Label();
            this.cbxProduits = new System.Windows.Forms.ComboBox();
            this.cbxAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStockAnimal = new System.Windows.Forms.Label();
            this.lblPrixUniteAnimal = new System.Windows.Forms.Label();
            this.lblPrixTotalAnimal = new System.Windows.Forms.Label();
            this.nudQteAnimal = new System.Windows.Forms.NumericUpDown();
            this.gbxSemence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantiteProduit)).BeginInit();
            this.gbxAnimaux.SuspendLayout();
            this.gbxProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQteAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSemence
            // 
            this.gbxSemence.BackColor = System.Drawing.Color.Transparent;
            this.gbxSemence.Controls.Add(this.cbxProduits);
            this.gbxSemence.Controls.Add(this.label4);
            this.gbxSemence.Controls.Add(this.label2);
            this.gbxSemence.Controls.Add(this.label1);
            this.gbxSemence.Controls.Add(this.lblStock);
            this.gbxSemence.Controls.Add(this.lblPrixUnite);
            this.gbxSemence.Controls.Add(this.lblPrixProduit);
            this.gbxSemence.Controls.Add(this.nudQuantiteProduit);
            this.gbxSemence.Controls.Add(this.btnAchatProduit);
            this.gbxSemence.Controls.Add(this.btnVenteProduit);
            this.gbxSemence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSemence.ForeColor = System.Drawing.Color.White;
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
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stock :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Prix a l\'unité :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Prix Total :";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(148, 96);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(15, 15);
            this.lblStock.TabIndex = 23;
            this.lblStock.Text = "0";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // lblPrixUnite
            // 
            this.lblPrixUnite.AutoSize = true;
            this.lblPrixUnite.BackColor = System.Drawing.Color.Transparent;
            this.lblPrixUnite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixUnite.ForeColor = System.Drawing.Color.White;
            this.lblPrixUnite.Location = new System.Drawing.Point(148, 121);
            this.lblPrixUnite.Name = "lblPrixUnite";
            this.lblPrixUnite.Size = new System.Drawing.Size(15, 15);
            this.lblPrixUnite.TabIndex = 23;
            this.lblPrixUnite.Text = "0";
            // 
            // lblPrixProduit
            // 
            this.lblPrixProduit.AutoSize = true;
            this.lblPrixProduit.BackColor = System.Drawing.Color.Transparent;
            this.lblPrixProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixProduit.ForeColor = System.Drawing.Color.White;
            this.lblPrixProduit.Location = new System.Drawing.Point(148, 148);
            this.lblPrixProduit.Name = "lblPrixProduit";
            this.lblPrixProduit.Size = new System.Drawing.Size(15, 15);
            this.lblPrixProduit.TabIndex = 23;
            this.lblPrixProduit.Text = "0";
            // 
            // nudQuantiteProduit
            // 
            this.nudQuantiteProduit.Location = new System.Drawing.Point(69, 55);
            this.nudQuantiteProduit.Name = "nudQuantiteProduit";
            this.nudQuantiteProduit.Size = new System.Drawing.Size(87, 21);
            this.nudQuantiteProduit.TabIndex = 22;
            this.nudQuantiteProduit.ValueChanged += new System.EventHandler(this.nudQuantiteProduit_ValueChanged);
            // 
            // btnAchatProduit
            // 
            this.btnAchatProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchatProduit.ForeColor = System.Drawing.Color.Black;
            this.btnAchatProduit.Location = new System.Drawing.Point(111, 175);
            this.btnAchatProduit.Name = "btnAchatProduit";
            this.btnAchatProduit.Size = new System.Drawing.Size(75, 23);
            this.btnAchatProduit.TabIndex = 20;
            this.btnAchatProduit.Text = "Acheter";
            this.btnAchatProduit.UseVisualStyleBackColor = true;
            this.btnAchatProduit.Click += new System.EventHandler(this.btnAchatProduit_Click);
            // 
            // btnVenteProduit
            // 
            this.btnVenteProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenteProduit.ForeColor = System.Drawing.Color.Black;
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
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "CHF";
            // 
            // gbxAnimaux
            // 
            this.gbxAnimaux.BackColor = System.Drawing.Color.Transparent;
            this.gbxAnimaux.Controls.Add(this.nudQteAnimal);
            this.gbxAnimaux.Controls.Add(this.label3);
            this.gbxAnimaux.Controls.Add(this.label6);
            this.gbxAnimaux.Controls.Add(this.label7);
            this.gbxAnimaux.Controls.Add(this.cbxAnimal);
            this.gbxAnimaux.Controls.Add(this.lblStockAnimal);
            this.gbxAnimaux.Controls.Add(this.lblPrixUniteAnimal);
            this.gbxAnimaux.Controls.Add(this.btnAcheterAnimal);
            this.gbxAnimaux.Controls.Add(this.lblPrixTotalAnimal);
            this.gbxAnimaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAnimaux.ForeColor = System.Drawing.Color.White;
            this.gbxAnimaux.Location = new System.Drawing.Point(237, 32);
            this.gbxAnimaux.Name = "gbxAnimaux";
            this.gbxAnimaux.Size = new System.Drawing.Size(230, 217);
            this.gbxAnimaux.TabIndex = 4;
            this.gbxAnimaux.TabStop = false;
            this.gbxAnimaux.Text = "Animaux";
            // 
            // btnAcheterAnimal
            // 
            this.btnAcheterAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcheterAnimal.ForeColor = System.Drawing.Color.Black;
            this.btnAcheterAnimal.Location = new System.Drawing.Point(73, 175);
            this.btnAcheterAnimal.Name = "btnAcheterAnimal";
            this.btnAcheterAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAcheterAnimal.TabIndex = 15;
            this.btnAcheterAnimal.Text = "Acheter";
            this.btnAcheterAnimal.UseVisualStyleBackColor = true;
            this.btnAcheterAnimal.Click += new System.EventHandler(this.btnAcheterAnimal_Click);
            // 
            // gbxProd
            // 
            this.gbxProd.BackColor = System.Drawing.Color.Transparent;
            this.gbxProd.Controls.Add(this.label16);
            this.gbxProd.Controls.Add(this.label15);
            this.gbxProd.Controls.Add(this.label14);
            this.gbxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProd.ForeColor = System.Drawing.Color.White;
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
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(452, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "La laine se vend à 150 CHF l\'unité mais prend 2 heures à se produire";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(255, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Les oeufs se vendent a 0.20 CHF/Unité";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(464, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lait se vend toutes les 10 minutes pour le nombre de vache X 1.25 CHF";
            // 
            // lblArgentMagas
            // 
            this.lblArgentMagas.AutoSize = true;
            this.lblArgentMagas.BackColor = System.Drawing.Color.Transparent;
            this.lblArgentMagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArgentMagas.ForeColor = System.Drawing.Color.White;
            this.lblArgentMagas.Location = new System.Drawing.Point(46, 9);
            this.lblArgentMagas.Name = "lblArgentMagas";
            this.lblArgentMagas.Size = new System.Drawing.Size(43, 15);
            this.lblArgentMagas.TabIndex = 5;
            this.lblArgentMagas.Text = "Label";
            // 
            // cbxProduits
            // 
            this.cbxProduits.FormattingEnabled = true;
            this.cbxProduits.Location = new System.Drawing.Point(69, 29);
            this.cbxProduits.Name = "cbxProduits";
            this.cbxProduits.Size = new System.Drawing.Size(87, 23);
            this.cbxProduits.TabIndex = 25;
            this.cbxProduits.SelectedIndexChanged += new System.EventHandler(this.cbxProduits_SelectedIndexChanged);
            // 
            // cbxAnimal
            // 
            this.cbxAnimal.FormattingEnabled = true;
            this.cbxAnimal.Location = new System.Drawing.Point(61, 29);
            this.cbxAnimal.Name = "cbxAnimal";
            this.cbxAnimal.Size = new System.Drawing.Size(87, 23);
            this.cbxAnimal.TabIndex = 26;
            this.cbxAnimal.SelectedIndexChanged += new System.EventHandler(this.cbxAnimal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Stock :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Prix a l\'unité :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(64, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Prix Total :";
            // 
            // lblStockAnimal
            // 
            this.lblStockAnimal.AutoSize = true;
            this.lblStockAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblStockAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAnimal.ForeColor = System.Drawing.Color.White;
            this.lblStockAnimal.Location = new System.Drawing.Point(146, 87);
            this.lblStockAnimal.Name = "lblStockAnimal";
            this.lblStockAnimal.Size = new System.Drawing.Size(15, 15);
            this.lblStockAnimal.TabIndex = 26;
            this.lblStockAnimal.Text = "0";
            // 
            // lblPrixUniteAnimal
            // 
            this.lblPrixUniteAnimal.AutoSize = true;
            this.lblPrixUniteAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrixUniteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixUniteAnimal.ForeColor = System.Drawing.Color.White;
            this.lblPrixUniteAnimal.Location = new System.Drawing.Point(146, 112);
            this.lblPrixUniteAnimal.Name = "lblPrixUniteAnimal";
            this.lblPrixUniteAnimal.Size = new System.Drawing.Size(15, 15);
            this.lblPrixUniteAnimal.TabIndex = 27;
            this.lblPrixUniteAnimal.Text = "0";
            // 
            // lblPrixTotalAnimal
            // 
            this.lblPrixTotalAnimal.AutoSize = true;
            this.lblPrixTotalAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrixTotalAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixTotalAnimal.ForeColor = System.Drawing.Color.White;
            this.lblPrixTotalAnimal.Location = new System.Drawing.Point(146, 139);
            this.lblPrixTotalAnimal.Name = "lblPrixTotalAnimal";
            this.lblPrixTotalAnimal.Size = new System.Drawing.Size(15, 15);
            this.lblPrixTotalAnimal.TabIndex = 28;
            this.lblPrixTotalAnimal.Text = "0";
            // 
            // nudQteAnimal
            // 
            this.nudQteAnimal.Location = new System.Drawing.Point(61, 55);
            this.nudQteAnimal.Name = "nudQteAnimal";
            this.nudQteAnimal.Size = new System.Drawing.Size(87, 21);
            this.nudQteAnimal.TabIndex = 32;
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
            this.gbxProd.ResumeLayout(false);
            this.gbxProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQteAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSemence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxAnimaux;
        private System.Windows.Forms.Button btnAcheterAnimal;
        private System.Windows.Forms.GroupBox gbxProd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblArgentMagas;
        private System.Windows.Forms.Button btnAchatProduit;
        private System.Windows.Forms.Button btnVenteProduit;
        private System.Windows.Forms.NumericUpDown nudQuantiteProduit;
        private System.Windows.Forms.Label lblPrixProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrixUnite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ComboBox cbxProduits;
        private System.Windows.Forms.NumericUpDown nudQteAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxAnimal;
        private System.Windows.Forms.Label lblStockAnimal;
        private System.Windows.Forms.Label lblPrixUniteAnimal;
        private System.Windows.Forms.Label lblPrixTotalAnimal;
    }
}