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
using MySql;

namespace farmFantasy
{
    public partial class frmMain : Form
    {
        Dictionary<string, Champs> repertoryChamps = new Dictionary<string, Champs>();
        Dictionary<string, Animaux> repertoryAnimaux = new Dictionary<string, Animaux>{
            {"vache", new Animaux(1.25, 10 * 60, "vache", 0)},
            {"poule", new Animaux(0.20, 5 * 60, "poule", 0)},
            {"mouton", new Animaux(150, 120 * 60, "mouton", 0)},
            {"cochon", new Animaux(10, 20 * 60, "cochon", 0)}
        };

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
                    pbx.ImageLocation = "images\\" + culture + ".png";

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

            if (repertoryAnimaux["vache"].calculTempsProd())
            {
                FrmMainArgent += (int)repertoryAnimaux["vache"].PrixVenteProduit;
                Console.WriteLine(repertoryAnimaux["vache"]);
            }

            if (repertoryAnimaux["poule"].calculTempsProd())
            {
                FrmMainArgent += (int)repertoryAnimaux["poule"].PrixVenteProduit;
            }

            if (repertoryAnimaux["mouton"].calculTempsProd())
            {
                FrmMainArgent += (int)repertoryAnimaux["mouton"].PrixVenteProduit;
            }
            
            if (repertoryAnimaux["cochon"].calculTempsProd())
            {
                FrmMainArgent += (int)repertoryAnimaux["cochon"].PrixVenteProduit;
            }
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
    }
}