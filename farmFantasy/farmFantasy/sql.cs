using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace farmFantasy
{
    static class Sql
    {
        static int idJoueur = 1;
        static string infoDB = "server=10.134.97.69;user=root;database=farmfantasy;password=;";
        static MySqlConnection connectionDB = new MySqlConnection(infoDB);
        static MySqlCommand cmd;

        const string UPDATECHAMPS = "UPDATE champs SET tempsRestant=@temps,idNomSemence=@idSemence WHERE idChamps=@pbxName AND idJoueur=@idJoueur";
        const string UPDATEENTRPOT = "UPDATE entrepots SET qteItem=@item WHERE idNomItem=@idItem AND idJoueur = @idJoueur";
        const string UPDATEANIMAUX = "UPDATE animaux SET nbrAnimaux=@nbrAnim, tempProdActu=@tempsProd WHERE idNomAnimal=@idAnimal AND idJoueur=@idJoueur";
        const string UPDATEARGENT = "UPDATE joueurs SET argent=@argent WHERE idJoueur=@idJoueur";
        const string SELECTCHAMPS = "SELECT * FROM champs WHERE idNomSemence != 'rien' AND idJoueur=@idJoueur";
        const string SELECTARGENT = "SELECT argent FROM joueurs WHERE idJoueur=@idJoueur";
        const string SELECTENTREPOT = "SELECT * FROM entrepots WHERE idJoueur=@idJoueur";
        const string SELECTANIMAUX = "SELECT * FROM animaux NATURAL JOIN produits WHERE idJoueur=@idJoueur";
        const string SELECTJOUEURMDP = "SELECT mdp FROM joueurs WHERE Pseudo = @Pseudo";
        const string SELECTJOUEURID = "SELECT idJoueur FROM joueurs WHERE Pseudo = @Pseudo";
        const string INSERTJOUEUR = "INSERT INTO joueurs(Pseudo, mdp) VALUES (@Pseudo,@Mdp)";

        //  Test si la connection a la base de donnés est ok
        static public bool conDB()
        {
            bool conOK = false;

            connectionDB.Open();
            if (connectionDB.State == System.Data.ConnectionState.Open)
            {
                conOK = true;
            }
            
            connectionDB.Close();
            return conOK;
        }

        //  Sauvegarde l'entrepôt du joueur
        static public void UpdateChamps(int temps, string idSemence, string pbxName)
        {
            cmd = new MySqlCommand(UPDATECHAMPS, connectionDB);

            cmd.Parameters.AddWithValue("@temps", temps);
            cmd.Parameters.AddWithValue("@idSemence", idSemence);
            cmd.Parameters.AddWithValue("@pbxName", pbxName);
            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

            try
            {
                connectionDB.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connectionDB.Close();
        }

        //  Sauvegarde l'entrepôt du joueur
        static public void UpdateEntrepot(string idItem, int qte)
        {
            cmd = new MySqlCommand(UPDATEENTRPOT, connectionDB);

            cmd.Parameters.AddWithValue("@item", qte);
            cmd.Parameters.AddWithValue("@idItem", idItem);
            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

            try
            {
                connectionDB.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            connectionDB.Close();
        }

        //  Sauvegarde les animaux du joueur
        static public void UpdateAnimaux(string nomAnimal, int nbrAnimaux, int TempsProdActu)
        {
            cmd = new MySqlCommand(UPDATEANIMAUX, connectionDB);

            cmd.Parameters.AddWithValue("@nbrAnim", nbrAnimaux);
            cmd.Parameters.AddWithValue("@tempsProd", TempsProdActu);
            cmd.Parameters.AddWithValue("@idAnimal", nomAnimal);
            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

            try
            {
                connectionDB.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connectionDB.Close();
        }

        //  Sauvegarde l'argent du joueur
        static public void UpdateArgent(int argent)
        {
            cmd = new MySqlCommand(UPDATEARGENT, connectionDB);

            cmd.Parameters.AddWithValue("@argent", argent);
            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

            try
            {
                connectionDB.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connectionDB.Close();
        }

        // Charge les champs du joueur dans l'état 
        // param FrmMain
        // return retourne le dictionnaire contanant chaque champ
        static public Dictionary<string, Champs> chargerChamps(frmMain FrmMain)
        {
            Dictionary<string, Champs> dico = new Dictionary<string, Champs>();
            cmd = new MySqlCommand(SELECTCHAMPS, connectionDB);
            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

            try
            {
                connectionDB.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PictureBox pbx = FrmMain.Controls.Find(reader[0].ToString(), true).FirstOrDefault() as PictureBox;

                    pbx.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(reader[2].ToString());

                    dico.Add(reader[0].ToString(), new Champs(pbx, reader[2].ToString()));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connectionDB.Close();
            return dico;
        }

        //  Charge les animaux du joueur
        static public void chargerAnimaux(frmMain FrmMain)
        {
            cmd = new MySqlCommand(SELECTANIMAUX, connectionDB);
            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

            try
            {
                connectionDB.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Animaux animal = new Animaux(Convert.ToDouble(reader.GetValue(7)), Convert.ToDouble(reader.GetValue(6)), reader.GetValue(1).ToString(), Convert.ToInt32(reader.GetValue(2)), Convert.ToInt32(reader.GetValue(4)));
                    FrmMain.repertoryAnimaux.Add(reader.GetValue(1).ToString(), animal);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connectionDB.Close();
        }

        //  Charge l'argent du joueur dans le jeu
        static public int chargerArgent()
        {
            int argent = 100;
            cmd = new MySqlCommand(SELECTARGENT, connectionDB);
            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    argent = Convert.ToInt32(reader.GetValue(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connectionDB.Close();
            return argent;
        }

        // Charge l'entrepôt du joueur dans le jeu
        static public void chargerEntrepot(frmMain FrmMain)
        {
            cmd = new MySqlCommand(SELECTENTREPOT, connectionDB);
            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FrmMain.entrepot.Add(reader[0].ToString(), (int)reader[1]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connectionDB.Close();
        }

        // Transforme un text en sha1
        // param text Texte à transformé en sha1
        // return retourne le texte transformer en sha1
        static public string getSha1(string text)
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

        // Logue le joueur au jeu
        // param Pseudo Pseudo du joueur
        // param Mdp Mot de passe du joueur
        // returns true si la connection est valide
        static public bool login(string Pseudo, string Mdp)
        {
            bool loginOK = false;
            cmd = new MySqlCommand(SELECTJOUEURMDP, connectionDB);

            cmd.Parameters.AddWithValue("@Pseudo", Pseudo);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader[0].ToString() == Mdp)
                    {
                        loginOK = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            connectionDB.Close();
            return loginOK;
        }

        // Inscrit le joueur au jeu
        // param Pseudo Pseudo du joueur pour l'inscription
        // param Mdp Mot de passe du joueur
        // return true si l'inscription s'est bien passée
        static public bool inscription(string Pseudo, string Mdp)
        {
            bool inscritOK = false;
            cmd = new MySqlCommand(INSERTJOUEUR, connectionDB);
            cmd.Parameters.AddWithValue("@Pseudo", Pseudo);
            cmd.Parameters.AddWithValue("@Mdp", Mdp);

            try
            {
                connectionDB.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Vous êtes bien inscrit", "Meuuuh !!!", MessageBoxButtons.OK);
                    inscritOK = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ce nom d'utilisateur existe déjà", "Mèèèèèè !!!", MessageBoxButtons.OK);
            }
            connectionDB.Close();

            return inscritOK;
        }

        // Récupération de l'id du joueur connecter
        // param pseudo -> pseudo du joueur connecter
        static public void idJoueurCo(string pseudo)
        {
            cmd = new MySqlCommand(SELECTJOUEURID,connectionDB);
            cmd.Parameters.AddWithValue("@Pseudo", pseudo);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    idJoueur = Convert.ToInt32(reader.GetString(0));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur id");
            }
        }
    }
}
