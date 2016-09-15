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

        frmMain FrmMain = new frmMain();

        public frmMagasin()
        {
            InitializeComponent();
        }

        private void frmMagasin_Load(object sender, EventArgs e)
        {
            _frmMagasinArgent = FrmMain.FrmMainArgent;
            lblArgentMagas.Text = _frmMagasinArgent.ToString();
        }

        private void btnAcheterSemence_Click(object sender, EventArgs e)
        {
            _frmMagasinArgent -= 10;
            lblArgentMagas.Text = _frmMagasinArgent.ToString();
        }

        private void frmMagasin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.FrmMainArgent = _frmMagasinArgent;
        }
    }
}
