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
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            lblConfmdp.Visible = true;
            tbxConfMdp.Visible = true;
            string Pseudo = tbxPseudo.Text;
            string Mdp = tbxMdp.Text;
            string ConfMdp = tbxConfMdp.Text;

            if (ConfMdp == Mdp)
            {
                //enregister le user dans la bd
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
    }
}
