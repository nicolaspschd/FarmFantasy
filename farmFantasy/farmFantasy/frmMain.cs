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
namespace farmFantasy
{
    public partial class frmMain : Form
    {
        Dictionary<string, Champs> repertoryChamps = new Dictionary<string, Champs>();

        const int _NBRCHAMPS = 10;
        private int _FrmMainArgent = 100000;

        public int FrmMainArgent
        {
            get { return _FrmMainArgent; }
            set 
            {
                _FrmMainArgent = value;
                lblArgent.Text = value.ToString();
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblArgent.Text = _FrmMainArgent.ToString();
        }

        private void pbxClick_Click(object sender, EventArgs e)
        {
            string pbxNom = (sender as PictureBox).Name;

            if (!rbnNothing.Checked)
            {
                string culture = string.Empty;

                if (rbnBle.Checked)
                    culture = "ble";
                else if (rbnColza.Checked)
                    culture = "colza";
                else if (rbnCarotte.Checked)
                    culture = "carotte";
                else if (rbnPatate.Checked)
                    culture = "patate";

                PictureBox pbx = (sender as PictureBox);
                pbx.Enabled = false;

                string path = "images\\" + culture + ".png";
                pbx.ImageLocation = path;
                if (!repertoryChamps.ContainsKey(pbxNom))
                {
                    repertoryChamps.Add(pbxNom, new Champs(DateTime.Now, pbx, culture));
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(_FrmMainArgent);

            if (repertoryChamps.Count() > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (repertoryChamps.ContainsKey("pbxChamps" + i))
                    {
                        Champs nativChamps = (Champs)repertoryChamps["pbxChamps" + i];
                        if (nativChamps.calculTemps())
                        {
                            repertoryChamps.Remove("pbxChamps" + i);
                        }
                    }
                }
            }
        }

        private void btnMagasin_Click(object sender, EventArgs e)
        {
            frmMagasin FrmMagasin = new frmMagasin();
            FrmMagasin.ShowDialog();
            FrmMagasin._frmMagasinArgent = _FrmMainArgent;
        }

        //public void frmMainActuArgent(int argent)
        //{
        //    _FrmMainArgent = argent;
        //    lblArgent.Text = argent.ToString();
        //}
    }
}