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
        static int idJoueur;
        static string infoDB = "server=127.0.0.1;user=Thierry;password=ferme;database=farmfantasy;";
        static MySqlConnection connectionDB = new MySqlConnection(infoDB);
        static MySqlCommand cmd;

        #region Requete SQL
        const string UPDATECHAMPS       = "UPDATE champs SET tempsRestant=@temps,idNomSemence=@idSemence WHERE nomChamps=@pbxName AND idJoueur=@idJoueur";
        const string UPDATEENTRPOT      = "UPDATE entrepots SET qteItem=@item WHERE idNomItem=@idItem AND idJoueur = @idJoueur";
        const string UPDATEANIMAUX      = "UPDATE animaux SET nbrAnimaux=@nbrAnim, tempProdActu=@tempsProd WHERE nomAnimal=@idAnimal AND idJoueur=@idJoueur";
        const string UPDATEARGENT       = "UPDATE joueurs SET argent=@argent WHERE idJoueur=@idJoueur";
        const string SELECTCHAMPS       = "SELECT * FROM champs WHERE idNomSemence != 'rien' AND idJoueur=@idJoueur";
        const string SELECTARGENT       = "SELECT argent FROM joueurs WHERE idJoueur=@idJoueur";
        const string SELECTENTREPOT     = "SELECT * FROM entrepots WHERE idJoueur=@idJoueur AND idNomItem != 'rien'";
        const string SELECTANIMAUX      = "SELECT * FROM animaux NATURAL JOIN produits WHERE idJoueur=@idJoueur";
        const string SELECTJOUEURMDP    = "SELECT mdp FROM joueurs WHERE Pseudo = @Pseudo";
        const string SELECTJOUEURID     = "SELECT idJoueur FROM joueurs WHERE Pseudo = @Pseudo";
        const string INSERTJOUEUR       = "INSERT INTO joueurs(Pseudo, mdp) VALUES (@Pseudo,@Mdp)";
        const string INSERTANIMAUX      = "INSERT INTO animaux (nomAnimal, nbrAnimaux, tempProdActu, qteProd, idNomProduit, idJoueur) VALUES ('poule', '0', '0', '5', 'oeufs', @idJoueur), ('mouton', '0', '0', '25', 'laine', @idJoueur), ('cochon', '0', '0', '4', 'bacon', @idJoueur), ('vache', '0', '0', '1', 'lait', @idJoueur);";
        const string INSERTCHAMPS       = "INSERT INTO champs (nomChamps, tempsRestant, idNomSemence, idJoueur) VALUES (@idChamps, 0, 'rien', @idJoueur)";
        const string INSERTENTREPOT     = "INSERT INTO entrepots (idNomItem, qteItem, idJoueur) VALUES ('ble', 10, @idJoueur), ('colza', 0, @idJoueur), ('carotte', 0, @idJoueur), ('patate', 0, @idJoueur), ('mais', 0, @idJoueur), ('oeufs', 0, @idJoueur), ('laine', 0, @idJoueur), ('lait', 0, @idJoueur), ('bacon', 0, @idJoueur);";
        #endregion

        //  Test si la connection a la base de donnés est ok
        static public bool conDB()
        {
            bool conOK = false;
            try
            {
                connectionDB.Open();
                if (connectionDB.State == System.Data.ConnectionState.Open)
                {
                    conOK = true;
                }
            }
            catch (Exception)
            {
                conOK = false;
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
                    PictureBox pbx = FrmMain.Controls.Find(reader[1].ToString(), true).FirstOrDefault() as PictureBox;

                    pbx.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(reader[3].ToString());

                    dico.Add(reader[1].ToString(), new Champs(pbx, reader[3].ToString(), Convert.ToInt32(reader[2])));
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
                    Animaux animal = new Animaux(Convert.ToDouble(reader.GetValue(8)), Convert.ToDouble(reader.GetValue(7)), reader.GetValue(2).ToString(), Convert.ToInt32(reader.GetValue(3)), Convert.ToInt32(reader.GetValue(5)));
                    FrmMain.repertoryAnimaux.Add(reader.GetValue(2).ToString(), animal);
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

                if (reader.HasRows)
                {
                    reader.Read();
                    argent = Convert.ToInt32(reader.GetString(0));
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
                    FrmMain.entrepot.Add(reader[1].ToString(), (int)reader[2]);
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
            cmd = new MySqlCommand(SELECTJOUEURID, connectionDB);
            cmd.Parameters.AddWithValue("@Pseudo", pseudo);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    idJoueur = Convert.ToInt32(reader.GetString(0));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur id");
            }
            connectionDB.Close();
        }

        //  Insert un nouvel enregistrement dans la base pour le nouveau joueur
        static public void insertChampsInscrit()
        {
            MySqlTransaction transac;
            string idChamps = "pbxChamps";
            connectionDB.Open();

            transac = connectionDB.BeginTransaction();

            for (int i = 1; i < 11; i++)
            {
                cmd = new MySqlCommand(INSERTCHAMPS, connectionDB);

                cmd.Parameters.AddWithValue("@idChamps", idChamps + i.ToString());
                cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    transac.Rollback();
                    MessageBox.Show("Erreur lors de l'inscription !\\n InsertChamps", "Groin !", MessageBoxButtons.OK);
                }
            }

            transac.Commit();

            connectionDB.Close();
        }

        //  Insert un nouvel enregistrement dans la base pour le nouveau joueur
        static public void insertAnimauxInscrit()
        {
            MySqlTransaction transac;
            connectionDB.Open();

            transac = connectionDB.BeginTransaction();

            cmd = new MySqlCommand(INSERTANIMAUX, connectionDB);

            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);

            try
            {
                cmd.ExecuteNonQuery();
                transac.Commit();
            }
            catch (Exception)
            {
                transac.Rollback();
                MessageBox.Show("Erreur lors de l'inscription ! \\n insertAnimaux", "Groin !", MessageBoxButtons.OK);
            }

            connectionDB.Close();
        }

        //  Insert un nouvel enregistrement dans la base pour le nouveau joueur
        static public void insertEntrepot()
        {
            MySqlTransaction transac;
            connectionDB.Open();

            transac = connectionDB.BeginTransaction();

            cmd = new MySqlCommand(INSERTENTREPOT,connectionDB);
            cmd.Parameters.AddWithValue("@idJoueur", idJoueur);
            
            try
            {
                cmd.ExecuteNonQuery();
                transac.Commit();
            }
            catch (Exception ex)
            {
                transac.Rollback();
                MessageBox.Show(ex.Message,"Groin !",MessageBoxButtons.OK);
            }
            connectionDB.Close();
        }
    }
}
