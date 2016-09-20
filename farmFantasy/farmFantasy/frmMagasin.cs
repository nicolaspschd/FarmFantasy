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
        const int PRIXBLE = 5;
        const int PRIXCOLZA = 15;
        const int PRIXCAROTTE = 30;
        const int PRIXPATATE = 50;

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
            _frmMagasinArgent = Convert.ToInt32(parent.FrmMainArgent);

            //  Mise a jour du label avec l'argent actuel
            lblArgentMagas.Text = _frmMagasinArgent.ToString();
        }

        private void btnAcheterSemence_Click(object sender, EventArgs e)
        {
            //  Decrement de l'argent
            _frmMagasinArgent -= 10;

            //  Mise a jour du label
            lblArgentMagas.Text = _frmMagasinArgent.ToString();

            //  Mise a jour de l'argent sur frmMain
            parent.FrmMainArgent = _frmMagasinArgent;
        }

        private void frmMagasin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  Mise a jout de l'argent sur la fenêtre principal lors de la fermeture
            parent.FrmMainArgent = _frmMagasinArgent;
            parent.lblArgent.Text = _frmMagasinArgent.ToString();
        }
    }
}
