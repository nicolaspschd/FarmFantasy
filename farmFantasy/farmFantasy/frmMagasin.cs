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
        int total = 0;
        int prixTotBle = 0;
        int prixTotColza = 0;
        int prixTotCarotte = 0;
        int prixTotPatate = 0;
        int prixTotMais = 0;

        const int PRIXBLE = 5;
        const int PRIXCOLZA = 15;
        const int PRIXCAROTTE = 30;
        const int PRIXPATATE = 50;
        const int PRIXMAIS = 75;

        public int _frmMagasinArgent;
        frmMain parent;

        public frmMagasin()
        {
            InitializeComponent();
        }

        private void frmMagasin_Load(object sender, EventArgs e)
        {
            //  Récupération de frmMain
            parent = (frmMain)this.Owner;

            //  Récupération de l'argent de frmMain
            _frmMagasinArgent = (int)(parent.FrmMainArgent);

            //  Mise a jour du label avec l'argent actuel
            lblArgentMagas.Text = _frmMagasinArgent.ToString();
        }

        private void btnAcheterSemence_Click(object sender, EventArgs e)
        {
            //  Decrement de l'argent
            if (_frmMagasinArgent - total >= 0)
            {
                _frmMagasinArgent -= total;

                parent.entrepot["ble"] += (int)nudBle.Value;
                parent.entrepot["colza"] += (int)nudColza.Value;
                parent.entrepot["carotte"] += (int)nudCarotte.Value;
                parent.entrepot["patate"] += (int)nudPatate.Value;
                parent.entrepot["mais"] += (int)nudMais.Value;

                //  Mise a jour du label
                lblArgentMagas.Text = _frmMagasinArgent.ToString();

                //  Mise a jour de l'argent sur frmMain
                parent.FrmMainArgent = _frmMagasinArgent;
            }
            else
            {
                MessageBox.Show("Vous n'avez pas assez d'argent pour payer", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmMagasin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  Mise a jout de l'argent sur la fenêtre principal lors de la fermeture
            parent.FrmMainArgent = _frmMagasinArgent;
            parent.lblArgent.Text = _frmMagasinArgent.ToString();
            parent.frmMain_Load(null, null);
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

            total = prixTotBle + prixTotCarotte + prixTotColza + prixTotMais + prixTotPatate;
            lblTotalSem.Text = total.ToString();
        }

        private void btnVendreSemence_Click(object sender, EventArgs e)
        {
            int totVente = 0;
            if (parent.entrepot["ble"] >= (int)nudBle.Value)
            {
                totVente += prixTotBle;
                parent.entrepot["ble"] -= (int)nudBle.Value;
            }
            if (parent.entrepot["colza"] >= (int)nudColza.Value)
            {
                totVente += prixTotColza;
                parent.entrepot["colza"] -= (int)nudColza.Value;
            }
            if (parent.entrepot["carotte"] >= (int)nudCarotte.Value)
            {
                totVente += prixTotCarotte;
                parent.entrepot["carotte"] -= (int)nudCarotte.Value;
            }
            if (parent.entrepot["patate"] >= (int)nudPatate.Value)
            {
                totVente += prixTotPatate;
                parent.entrepot["patate"] -= (int)nudPatate.Value;
            }
            if (parent.entrepot["mais"] >= (int)nudMais.Value)
            {
                totVente += prixTotMais;
                parent.entrepot["mais"] -= (int)nudMais.Value;
            }

            //  Mise a jour de l'argent
            _frmMagasinArgent += totVente;

            //  Mise a jour du label
            lblArgentMagas.Text = _frmMagasinArgent.ToString();

            //  Mise a jour de l'argent sur frmMain
            parent.FrmMainArgent = _frmMagasinArgent;
        }
    }
}
