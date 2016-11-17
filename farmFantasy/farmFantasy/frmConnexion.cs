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
    public partial class frmConnexion : Form
    {
        bool mdpConfirmation = false;

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            if (tbxConfMdp.Visible == true)
            {

                string Pseudo = tbxPseudo.Text;
                string Mdp = Sql.getSha1(tbxMdp.Text);

                if (mdpConfirmation)
                {
                    if (Sql.inscription(Pseudo, Mdp))
                    {
                        Sql.idJoueurCo(Pseudo);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas", "Groin !!!", MessageBoxButtons.OK);
                }
            }
            else
            {
                lblConfmdp.Visible = true;
                tbxConfMdp.Visible = true;
                btnLogin.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Pseudo;
            string Mdp;

            Pseudo = tbxPseudo.Text;
            Mdp = Sql.getSha1(tbxMdp.Text);

            if (Sql.login(Pseudo, Mdp))
            {
                Sql.idJoueurCo(Pseudo);
                this.Close();
            }
            else
            {
                lblAvert.Text = "Login incorrect, veuillez réessayer";
            }
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            string mdpConfirm = string.Empty;
            //  On récupère le contenu de la tbx
            //  On test si les 2 mots de passe sont ok
            if (tbxMdp.Text != tbxConfMdp.Text)
            {
                //  Si non, on affiche erreur
                lblAvert.Visible = true;
                lblAvert.Text = "Le mot de passe ne correspond pas";
                mdpConfirmation = false;
            }
            else
            {
                if (tbxMdp.Text != string.Empty)
                {
                    //  Sinon, on dit ok
                    lblAvert.Visible = true;

                    lblAvert.Text = "Pas de soucis";
                    mdpConfirmation = true;
                }
                else
                {
                    lblAvert.Text = string.Empty;
                    mdpConfirmation = false;
                }
            }
        }
    }
}
