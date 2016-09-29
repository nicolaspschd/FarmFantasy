using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;

namespace farmFantasy
{
    public partial class frmMagasin : Form
    {
        int totalPrixSem = 0;
        int totalPrixAnim = 0;
        int prixTotBle = 0;
        int prixTotColza = 0;
        int prixTotCarotte = 0;
        int prixTotPatate = 0;
        int prixTotMais = 0;

        int prixTotPoule = 0;
        int prixTotMouton = 0;
        int prixTotCochon = 0;
        int prixTotVache = 0;

        const int PRIXPOULE = 25;
        const int PRIXMOUTON = 75;
        const int PRIXCOCHON = 150;
        const int PRIXVACHE = 300;

        const int PRIXBLE = 5;
        const int PRIXCOLZA = 15;
        const int PRIXCAROTTE = 30;
        const int PRIXPATATE = 50;
        const int PRIXMAIS = 75;

        public int _frmMagasinArgent;
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
            _frmMagasinArgent = (int)(_FrmMain.FrmMainArgent);

            //  Mise a jour du label avec l'argent actuel
            lblArgentMagas.Text = _frmMagasinArgent.ToString();
        }

        private void btnAcheterSemence_Click(object sender, EventArgs e)
        {
            if ((_frmMagasinArgent - totalPrixSem >= 0) && (_frmMagasinArgent - totalPrixAnim >= 0))
            {
                _frmMagasinArgent -= totalPrixSem + totalPrixAnim;

                _FrmMain.entrepot["ble"] += (int)nudBle.Value;
                _FrmMain.entrepot["colza"] += (int)nudColza.Value;
                _FrmMain.entrepot["carotte"] += (int)nudCarotte.Value;
                _FrmMain.entrepot["patate"] += (int)nudPatate.Value;
                _FrmMain.entrepot["mais"] += (int)nudMais.Value;

                _FrmMain.repertoryAnimaux["vache"].NbrAnimaux += (int)nudVache.Value;
                _FrmMain.repertoryAnimaux["poule"].NbrAnimaux += (int)nudPoule.Value;
                _FrmMain.repertoryAnimaux["mouton"].NbrAnimaux += (int)nudMouton.Value;
                _FrmMain.repertoryAnimaux["cochon"].NbrAnimaux += (int)nudCochon.Value;

                _FrmMain.repertoryAnimaux["vache"].majPrix();
                _FrmMain.repertoryAnimaux["poule"].majPrix();
                _FrmMain.repertoryAnimaux["mouton"].majPrix();
                _FrmMain.repertoryAnimaux["cochon"].majPrix();

                //  Mise a jour du label
                lblArgentMagas.Text = _frmMagasinArgent.ToString();

                //  Mise a jour de l'argent sur frmMain
                _FrmMain.FrmMainArgent = _frmMagasinArgent;

                totalPrixAnim = 0;
                totalPrixSem = 0;
            }
            else
            {
                MessageBox.Show("Vous n'avez pas assez d'argent pour payer", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmMagasin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  Mise a jout de l'argent sur la fenêtre principal lors de la fermeture
            _FrmMain.FrmMainArgent = _frmMagasinArgent;
            _FrmMain.lblArgent.Text = _frmMagasinArgent.ToString();
            _FrmMain.frmMain_Load(null, null);
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (sender as NumericUpDown);

            if (nud.Name == "nudBle")
            {
                prixTotBle = (int)(nud.Value * PRIXBLE);
                lblPrixBle.Text = prixTotBle.ToString();
            }
            
            if (nud.Name == "nudColza")
            {
                prixTotColza = (int)(nud.Value * PRIXCOLZA);
                lblPrixColza.Text = prixTotColza.ToString();
            }

            if (nud.Name == "nudCarotte")
            {
                prixTotCarotte = (int)(nud.Value * PRIXCAROTTE);
                lblPrixCarotte.Text = prixTotCarotte.ToString();
            }
            
            if (nud.Name == "nudPatate")
            {
                prixTotPatate = (int)(nud.Value * PRIXPATATE);
                lblPrixPatate.Text = prixTotPatate.ToString();
            }
            
            if (nud.Name == "nudMais")
            {
                prixTotMais = (int)(nud.Value * PRIXMAIS);
                lblPrixMais.Text = prixTotMais.ToString();
            }

            if (nud.Name == "nudPoule")
            {
                prixTotPoule = (int)(nud.Value * PRIXPOULE);
                lblPrixPoule.Text = prixTotPoule.ToString();
            }

            if (nud.Name == "nudMouton")
            {
                prixTotMouton = (int)(nud.Value * PRIXMOUTON);
                lblPrixMouton.Text = prixTotMouton.ToString();
            }
            
            if (nud.Name == "nudCochon")
            {
                prixTotCochon = (int)(nud.Value * PRIXCOCHON);
                lblPrixCochon.Text = prixTotCochon.ToString();
            }
            
            if (nud.Name == "nudVache")
            {
                prixTotVache = (int)(nud.Value * PRIXVACHE);
                lblPrixVache.Text = prixTotVache.ToString();
            }

            //  Affichage du prix total des animaux
            totalPrixAnim = prixTotVache + prixTotCochon + prixTotPoule + prixTotMouton;
            lblTotAnim.Text = totalPrixAnim.ToString();

            //  Affichage du prix total des semences
            totalPrixSem = prixTotBle + prixTotCarotte + prixTotColza + prixTotMais + prixTotPatate;
            lblTotalSem.Text = totalPrixSem.ToString();
        }

        private void btnVendreSemence_Click(object sender, EventArgs e)
        {
            int totVente = 0;
            if (_FrmMain.entrepot["ble"] >= (int)nudBle.Value)
            {
                totVente += prixTotBle;
                _FrmMain.entrepot["ble"] -= (int)nudBle.Value;
            }
            if (_FrmMain.entrepot["colza"] >= (int)nudColza.Value)
            {
                totVente += prixTotColza;
                _FrmMain.entrepot["colza"] -= (int)nudColza.Value;
            }
            if (_FrmMain.entrepot["carotte"] >= (int)nudCarotte.Value)
            {
                totVente += prixTotCarotte;
                _FrmMain.entrepot["carotte"] -= (int)nudCarotte.Value;
            }
            if (_FrmMain.entrepot["patate"] >= (int)nudPatate.Value)
            {
                totVente += prixTotPatate;
                _FrmMain.entrepot["patate"] -= (int)nudPatate.Value;
            }
            if (_FrmMain.entrepot["mais"] >= (int)nudMais.Value)
            {
                totVente += prixTotMais;
                _FrmMain.entrepot["mais"] -= (int)nudMais.Value;
            }

            //  Mise a jour de l'argent
            _frmMagasinArgent += totVente;

            //  Mise a jour du label
            lblArgentMagas.Text = _frmMagasinArgent.ToString();

            //  Mise a jour de l'argent sur frmMain
            _FrmMain.FrmMainArgent = _frmMagasinArgent;
        }
    }
}