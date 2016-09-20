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
            parent = (frmMain)this.Owner;
            _frmMagasinArgent = Convert.ToInt32(parent.lblArgent.Text);
            lblArgentMagas.Text = _frmMagasinArgent.ToString();
        }

        private void btnAcheterSemence_Click(object sender, EventArgs e)
        {
            _frmMagasinArgent -= 10;
            lblArgentMagas.Text = _frmMagasinArgent.ToString();
            parent.lblArgent.Text = _frmMagasinArgent.ToString();     
        }

        private void frmMagasin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
