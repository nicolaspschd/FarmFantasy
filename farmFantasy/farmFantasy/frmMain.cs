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
        public string login = string.Empty;

        public Dictionary<string, int> entrepot = new Dictionary<string, int>();

        public Dictionary<string, Animaux> repertoryAnimaux = new Dictionary<string, Animaux>();

        Dictionary<string, Champs> repertoryChamps = new Dictionary<string, Champs>();

        frmMagasin FrmMagasin = new frmMagasin();

        const int NBRCHAMPS = 10;
        public int argent = 100;

        public frmMain()
        {
            InitializeComponent();
        }

        //  Chargement de l'interface
        public void frmMain_Load(object sender, EventArgs e)
        {
            if (login == string.Empty)
            {
                Sql.conDB();
                timer.Enabled = false;
                frmConnexion frmCo = new frmConnexion();
                frmCo.ShowDialog();
            }

            Sql.insertChampsInscrit();

            if (Sql.conDB())
            {
                repertoryChamps = Sql.chargerChamps(this);
                argent = Sql.chargerArgent();
                Sql.chargerEntrepot(this);
                Sql.chargerAnimaux(this);
            }

            timer.Enabled = true;

            majInterface();
        }

        //  Evénement clique sur n'importe quel champ
        private void pbxClickChamps_Click(object sender, EventArgs e)
        {
            //  Initialisation des variables
            PictureBox pbx = sender as PictureBox;

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
                    majInterface();

                    if (!repertoryChamps.ContainsKey(pbx.Name))
                    {
                        //  Création du champs dans le tableau
                        repertoryChamps.Add(pbx.Name, new Champs(pbx, culture));
                    }
                }
            }
        }

        //  Chaque tick = 1 seconde
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
                        Champs nativChamps = repertoryChamps["pbxChamps" + i] as Champs;

                        //  Si le temps de pousse est finis
                        if (nativChamps.calculTemps())
                        {
                            //  Mise a jour de l'entrepot
                            entrepot[nativChamps.Culture] += 2;

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
                    entrepot["oeufs"] += (int)repertoryAnimaux["poule"].Quantite;
            if (repertoryAnimaux["mouton"].NbrAnimaux > 0)
                if (repertoryAnimaux["mouton"].calculTempsProd())
                    entrepot["laine"] += (int)repertoryAnimaux["mouton"].Quantite;
            if (repertoryAnimaux["cochon"].NbrAnimaux > 0)
                if (repertoryAnimaux["cochon"].calculTempsProd())
                    entrepot["bacon"] += (int)repertoryAnimaux["cochon"].Quantite;

            //  Mise a jour des labels
            majInterface();
        }

        //  Ouverture de frmMagasin + envois des données
        private void btnMagasin_Click(object sender, EventArgs e)
        {
            FrmMagasin.ShowDialog(this);
        }

        //  Ouverture de l'entrepôt
        private void pbxEntrepot_Click(object sender, EventArgs e)
        {
            frmEntrepot FrmEntrepot = new frmEntrepot();
            FrmEntrepot.ShowDialog(this);
        }

        //  Sauvegarde le jeu
        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if (Sql.conDB())
            {
                sauvegarder();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  Si la connection a la base de donnée est possible
            if (Sql.conDB())
            {
                //  on sauvegarde
                sauvegarder();
            }
            else
            {
                //  Sinon on avertit le joueurs
                DialogResult dr = MessageBox.Show("La sauvegarde n'a pas pu être faites ! \n Voulez-vous vraiment quitter le jeu ?", "Danger", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //  Sauvegarde le jeu dans la base de données
        public void sauvegarder()
        {
            if (Sql.conDB())
            {
                for (int i = 0; i <= NBRCHAMPS; i++)
                {
                    if (repertoryChamps.ContainsKey("pbxChamps" + i))
                    {
                        Champs nativChamps = (Champs)repertoryChamps["pbxChamps" + i];
                        Sql.UpdateChamps(nativChamps.Temps, nativChamps.Culture, nativChamps.PbxChamps.Name);
                    }
                    else
                    {
                        Sql.UpdateChamps(0, "rien", "pbxChamps" + i);
                    }
                }

                for (int i = 0; i < entrepot.Count; i++)
                {
                    Sql.UpdateEntrepot(entrepot.ElementAt(i).Key, entrepot.ElementAt(i).Value);
                }

                for (int i = 0; i < repertoryAnimaux.Count; i++)
                {
                    string elementAt = repertoryAnimaux.ElementAt(i).Key;
                    Sql.UpdateAnimaux(repertoryAnimaux.ElementAt(i).Key, repertoryAnimaux[elementAt].NbrAnimaux, repertoryAnimaux[elementAt].Temps);
                }

                Sql.UpdateArgent(argent);
            }
            else
            {
                MessageBox.Show("La partie n'a pas pu être sauvegardée", "Pas de connection à la base de donnée", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Ouvre la fenêtre APropos lors du clique sur le label
        private void lblAPropos_Click(object sender, EventArgs e)
        {
            frmAbout FrmAbout = new frmAbout();
            FrmAbout.ShowDialog();
        }

        //  Met les valeurs à jour sur l'interface
        public void majInterface()
        {
            lblArgent.Text = argent.ToString();

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
    }
}