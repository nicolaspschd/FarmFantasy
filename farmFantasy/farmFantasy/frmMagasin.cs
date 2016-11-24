/*
 * Auteurs : RAMUSHI Ardi && PASCHOUD Nicolas
 * Nom du programme : Farm Fantasy
 * Description : FarmFantasy est un jeu de gestion de ferme évolutif. 
 *               Plusieurs animaux et type de cultures seront 
 *               disponible ainsi que des améliorations de bâtiments.
 * Date : 1 Septembre 2016
 * Version 1.0
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace farmFantasy
{
    public partial class frmMagasin : Form
    {
        public int totalPrixAnim = 0;
        public int prixProduit = 0;
        public int prixTotPoule = 0;
        public int prixTotMouton = 0;
        public int prixTotCochon = 0;
        public int prixTotVache = 0;
        public string produitSelect = string.Empty;
        public string animalSelect = string.Empty;

        public Dictionary<string, int> prix = new Dictionary<string, int> { 
            {"ble", PRIXBLE},
            {"colza", PRIXCOLZA},
            {"carotte", PRIXCAROTTE},
            {"patate", PRIXPATATE},
            {"mais", PRIXMAIS},
            {"oeufs", PRIXOEUFS},
            {"laine", PRIXLAINE},
            {"lait", PRIXLAIT},
            {"bacon", PRIXBACON},
            {"poule", PRIXPOULE},
            {"mouton",PRIXMOUTON},
            {"vache", PRIXVACHE},
            {"cochon", PRIXCOCHON}
        };

        #region Constante prix
        const int PRIXPOULE = 25;
        const int PRIXMOUTON = 75;
        const int PRIXCOCHON = 150;
        const int PRIXVACHE = 300;

        const int PRIXOEUFS = 2;
        const int PRIXLAINE = 2;
        const int PRIXLAIT = 2;
        const int PRIXBACON = 2;

        const int PRIXBLE = 5;
        const int PRIXCOLZA = 15;
        const int PRIXCAROTTE = 30;
        const int PRIXPATATE = 50;
        const int PRIXMAIS = 75;
        #endregion

        public int argent;
        frmMain _FrmMain;

        public frmMagasin()
        {
            InitializeComponent();
        }

        private void frmMagasin_Load(object sender, EventArgs e)
        {
            //  Récupération de frmMain
            _FrmMain = (frmMain)this.Owner;

            //  Récupération de l'argent de frmMain
            argent = (int)(_FrmMain.argent);

            if (cbxProduits.Items.Count == 0)
            {
                for (int i = 0; i < _FrmMain.entrepot.Count(); i++)
                {
                    cbxProduits.Items.Add(_FrmMain.entrepot.ElementAt(i).Key);
                }
            }

            if (cbxAnimal.Items.Count == 0)
            {
                for (int i = 0; i < _FrmMain.repertoryAnimaux.Count; i++)
                {
                    cbxAnimal.Items.Add(_FrmMain.repertoryAnimaux.ElementAt(i).Key);
                }
            }

            cbxProduits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProduits.SelectedIndex = 0;
            cbxAnimal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAnimal.SelectedIndex = 0;

            //  Mise a jour du label avec l'argent actuel
            lblArgentMagas.Text = argent.ToString();
            ResetMag();
        }

        private void btnVenteProduit_Click(object sender, EventArgs e)
        {

            if (produitSelect != string.Empty)
            {
                if (_FrmMain.entrepot[produitSelect] - nudQuantiteProduit.Value >= 0)
                {
                    _FrmMain.entrepot[produitSelect] -= (int)nudQuantiteProduit.Value;
                    argent += prixProduit;
                    lblArgentMagas.Text = argent.ToString();
                    nudQuantiteProduit.Value = 0;
                }
                else
                {
                    MessageBox.Show("Vous n'avez plus de " + produitSelect + " dans l'entrepôt", "", MessageBoxButtons.OK);
                    btnVenteProduit.Enabled = false;
                }
            }
        }

        private void nudQuantiteProduit_ValueChanged(object sender, EventArgs e)
        {
            if (!(nudQuantiteProduit.Value <= -1))
            {

                if (produitSelect != string.Empty)
                {
                    prixProduit = (int)(nudQuantiteProduit.Value * prix[produitSelect]);
                    if (_FrmMain.entrepot[produitSelect] - nudQuantiteProduit.Value >= 0)
                    {
                        if (btnVenteProduit.Enabled == false)
                        {
                            btnVenteProduit.Enabled = true;
                            lblStock.BackColor = Color.Transparent;
                        }


                        lblStock.Text = _FrmMain.entrepot[produitSelect].ToString();
                    }
                    else
                    {
                        btnVenteProduit.Enabled = false;
                        lblStock.BackColor = Color.Red;
                    }

                    if (prixProduit > argent)
                        lblPrixProduit.BackColor = Color.Red;
                    else
                        lblPrixProduit.BackColor = Color.Transparent;

                    lblPrixProduit.Text = prixProduit.ToString();
                }
            }
        }

        private void btnAchatProduit_Click(object sender, EventArgs e)
        {
            if ((argent - prixProduit) >= 0)
            {
                if (produitSelect != string.Empty)
                {
                    _FrmMain.entrepot[produitSelect] += (int)nudQuantiteProduit.Value;
                    argent -= prixProduit;
                    lblArgentMagas.Text = argent.ToString();
                    _FrmMain.argent = argent;
                    nudQuantiteProduit.Value = 0;
                }
            }
        }
        private void frmMagasin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  Mise a jout de l'argent sur la fenêtre principal lors de la fermeture
            _FrmMain.argent = argent;
            _FrmMain.lblArgent.Text = argent.ToString();
            _FrmMain.majInterface();
        }

        public void ResetMag()
        {
            totalPrixAnim = 0;

        }

        private void frmMagasin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblStock.Text) > 101)
            {
                nudQuantiteProduit.Value = 100;
            }
            else
            {
                nudQuantiteProduit.Value = Convert.ToDecimal((sender as Label).Text);
            }
        }

        private void cbxProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            produitSelect = cbxProduits.SelectedItem.ToString();

            lblStock.Text = (_FrmMain.entrepot[produitSelect]).ToString();
            lblPrixUnite.Text = prix[produitSelect].ToString();
            prixProduit = (int)nudQuantiteProduit.Value * prix[produitSelect];
            lblPrixProduit.Text = prixProduit.ToString();
        }

        private void btnAcheterAnimal_Click(object sender, EventArgs e)
        {

            _FrmMain.repertoryAnimaux["vache"].majPrix();
            _FrmMain.repertoryAnimaux["poule"].majPrix();
            _FrmMain.repertoryAnimaux["mouton"].majPrix();
            _FrmMain.repertoryAnimaux["cochon"].majPrix();

            argent -= Convert.ToInt32(lblPrixTotalAnimal.Text);

            //  Mise a jour du label
            lblArgentMagas.Text = argent.ToString();

            //  Mise a jour de l'argent sur frmMain
            _FrmMain.argent = argent;

            ResetMag();
        }

        private void cbxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            animalSelect = cbxAnimal.SelectedItem.ToString();

            lblStockAnimal.Text = (_FrmMain.repertoryAnimaux[animalSelect]).NbrAnimaux.ToString();
            lblPrixUniteAnimal.Text = prix[animalSelect].ToString();
            lblPrixTotalAnimal.Text = (Convert.ToInt32(lblPrixUniteAnimal.Text) * nudQteAnimal.Value).ToString();

        }
    }
}