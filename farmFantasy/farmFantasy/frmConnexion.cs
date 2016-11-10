using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace farmFantasy
{
    public partial class frmConnexion : Form
    {
        MySqlConnection connectionDB = new MySqlConnection("server=127.0.0.1;user=root;database=farmfantasy;password=;");
        MySqlCommand cmd;
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
                string Mdp = getSha1(tbxMdp.Text);

                if (mdpConfirmation)
                {
                    cmd = new MySqlCommand("INSERT INTO `joueurs`(`Pseudo`, `mdp`) VALUES (@Pseudo,@Mdp)", connectionDB);
                    cmd.Parameters.AddWithValue("@Pseudo", Pseudo);
                    cmd.Parameters.AddWithValue("@Mdp", Mdp);

                    try
                    {
                        connectionDB.Open();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Vous êtes bien inscrit", "Meuuuh !!!", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ce nom d'utilisateur existe déjà", "Mèèèèèè !!!", MessageBoxButtons.OK);
                    }
                    connectionDB.Close();
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
            Mdp = getSha1(tbxMdp.Text);

            cmd = new MySqlCommand("SELECT mdp from joueurs where Pseudo =@Pseudo", connectionDB);

            cmd.Parameters.AddWithValue("@Pseudo", Pseudo);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader[0].ToString() == Mdp)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connectionDB.Close();

        }

        public string getSha1(string text)
        {
            byte[] resultat;
            StringBuilder stringBuild = new StringBuilder();
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            resultat = sha1.Hash;

            foreach (var carac in resultat)
            {
                stringBuild.Append(carac.ToString("x2"));
            }

            return stringBuild.ToString();
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
