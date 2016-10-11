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
using System.IO;
using System.Data.Sql;

namespace farmFantasy
{
    public partial class frmMain : Form
    {
        Dictionary<string, Champs> repertoryChamps = new Dictionary<string, Champs>();

        public Dictionary<string, int> entrepot = new Dictionary<string, int> { 
            {"ble", 10},
            {"colza", 0},
            {"carotte", 0},
            {"patate", 0},
            {"mais", 0},
            {"oeufs", 0},
            {"laine", 0},
            {"lait", 0},
            {"bacon", 0}
        };

        public Dictionary<string, Animaux> repertoryAnimaux = new Dictionary<string, Animaux>{
            {"poule", new Animaux(1, 100, "poule", 0, 5)},
            {"mouton", new Animaux(150, 7200, "mouton", 0, 25)},
            {"cochon", new Animaux(10, 1200, "cochon", 0, 4)},
            {"vache", new Animaux(2, 600, "vache", 0, 1)}
        };

        frmMagasin FrmMagasin = new frmMagasin();

        const int NBRCHAMPS = 10;
        public int FrmMainArgent = 100;

        public frmMain()
        {
            InitializeComponent();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            lblArgent.Text = FrmMainArgent.ToString();

            //  Initialisation de l'entrepot
            lblBleEntrepot.Text = entrepot["ble"].ToString();
            lblColzaEntrepot.Text = entrepot["colza"].ToString();
            lblCarotteEntrepot.Text = entrepot["carotte"].ToString();
            lblPatateEntrepot.Text = entrepot["patate"].ToString();
            lblMaisEntrepot.Text = entrepot["mais"].ToString();

            lblOeufEntrepot.Text = entrepot["oeufs"].ToString();
            lblLaineEntrepot.Text = entrepot["laine"].ToString();
            lblLaitEntrepot.Text = entrepot["lait"].ToString();
            lblBaconEntrepot.Text = entrepot["bacon"].ToString();

            lblNbrPoule.Text = repertoryAnimaux["poule"].NbrAnimaux.ToString();
            lblNbrMouton.Text = repertoryAnimaux["mouton"].NbrAnimaux.ToString();
            lblNbrVache.Text = repertoryAnimaux["vache"].NbrAnimaux.ToString();
            lblNbrCochon.Text = repertoryAnimaux["cochon"].NbrAnimaux.ToString();
        }

        private void pbxClickChamps_Click(object sender, EventArgs e)
        {
            //  Initialisation des variables
            PictureBox pbx = (sender as PictureBox);

            if (!rbnNothing.Checked)
            {
                string culture = string.Empty;

                //  Check quel semence va être plantée
                if (rbnBle.Checked)
                    culture = "ble";
                else if (rbnColza.Checked)
                    culture = "colza";
                else if (rbnCarotte.Checked)
                    culture = "carotte";
                else if (rbnPatate.Checked)
                    culture = "patate";
                else if (rbnMais.Checked)
                    culture = "mais";

                if (entrepot[culture] > 0)
                {
                    entrepot[culture] -= 1;
                    pbx.Enabled = false;

                    //  Récupération de la bonne image de culture

                    pbx.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(culture);

                    //  Mise a jour des labels
                    frmMain_Load(null, null);

                    if (!repertoryChamps.ContainsKey(pbx.Name))
                    {
                        //  Création du champs dans le tableau
                        repertoryChamps.Add(pbx.Name, new Champs(pbx, culture));
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (repertoryChamps.Count() > 0)
            {
                for (int i = 1; i <= NBRCHAMPS; i++)
                {
                    //  Si le champs existe dans le tableau
                    if (repertoryChamps.ContainsKey("pbxChamps" + i))
                    {
                        //  Récupération du champs
                        Champs nativChamps = (Champs)repertoryChamps["pbxChamps" + i];

                        //  Si le temps de pousse est finis
                        if (nativChamps.calculTemps())
                        {
                            //  Mise a jour de l'entrepot
                            entrepot[nativChamps.Culture] += 2;

                            //  Mise a jour des labels
                            frmMain_Load(null, null);

                            //  Supression de l'objet "lié" au champs
                            repertoryChamps.Remove("pbxChamps" + i);
                        }
                    }
                }
            }

            if (repertoryAnimaux["vache"].NbrAnimaux > 0)
                if (repertoryAnimaux["vache"].calculTempsProd())
                    entrepot["lait"] += (int)repertoryAnimaux["vache"].Quantite;
            if (repertoryAnimaux["poule"].NbrAnimaux > 0)
                if (repertoryAnimaux["poule"].calculTempsProd())
                    entrepot["oeufs"] += (int)repertoryAnimaux["poule"].Quantite; frmMain_Load(null, null);
            if (repertoryAnimaux["mouton"].NbrAnimaux > 0)
                if (repertoryAnimaux["mouton"].calculTempsProd())
                    entrepot["laine"] += (int)repertoryAnimaux["mouton"].Quantite;
            if (repertoryAnimaux["cochon"].NbrAnimaux > 0)
                if (repertoryAnimaux["cochon"].calculTempsProd())
                    entrepot["bacon"] += (int)repertoryAnimaux["cochon"].Quantite;
        }

        private void pbxClickAnimaux_Click(object sender, EventArgs e)
        {
            PictureBox pbx = (sender as PictureBox);
        }

        private void btnMagasin_Click(object sender, EventArgs e)
        {
            //  Ouverture de frmMagasin + envois des données
            FrmMagasin.ShowDialog(this);
        }

        private void pbxEntrepot_Click(object sender, EventArgs e)
        {
            frmEntrepot FrmEntrepot = new frmEntrepot();
            FrmEntrepot.ShowDialog(this);
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}