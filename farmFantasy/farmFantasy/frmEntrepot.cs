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
    public partial class frmEntrepot : Form
    {
        public frmEntrepot()
        {
            InitializeComponent();
        }

        frmMain _FrmMain;

        private void frmEntrepot_Load(object sender, EventArgs e)
        {
            _FrmMain = (frmMain)this.Owner;
            tbxEntrepot.Text = "Produit - Quantité" + Environment.NewLine;
            for (int i = 0; i < _FrmMain.entrepot.Count(); i++)
            {
                tbxEntrepot.Text += Environment.NewLine + _FrmMain.entrepot.ElementAt(i).Key + " -- " + _FrmMain.entrepot.ElementAt(i).Value;
            }
        }

        private void frmEntrepot_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
