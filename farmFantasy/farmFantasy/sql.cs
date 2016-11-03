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

namespace farmFantasy
{
    public partial class frmMain
    {
        static string infoDB = "server=127.0.0.1;user=root;database=farmfantasy;password=;";
        MySqlConnection connectionDB = new MySqlConnection(infoDB);
        MySqlCommand cmd;

        const string UPDATECHAMPS  = "UPDATE `champs` SET `tempsRestant`=@temps,`idNomSemence`=@idSemence WHERE idChamps=@pbxName";
        const string UPDATEENTRPOT = "UPDATE `entrepots` SET `qteItem`=@item WHERE idNomItem=@idItem";
        const string UPDATEANIMAUX = "UPDATE `animaux` SET `nbrAnimaux`=@nbrAnim, `tempProdActu`=@tempsProd WHERE idNomAnimal=@idAnimal";
        const string UPDATEARGENT  = "UPDATE `joueurs` SET `argent`=@argent WHERE idJoueur=1";
        const string SELECTCHAMPS  = "SELECT * FROM champs WHERE idNomSemence != 'rien'";
        const string SELECTANIMAUX = "SELECT * FROM animaux";
        const string SELECTARGENT  = "SELECT argent FROM joueurs";

        public bool conDB()
        {
            bool conOK = false;

            if (connectionDB.State == System.Data.ConnectionState.Open)
            {
                conOK = true;
            }

            return conOK;
        }

        public void UpdateChamps(int temps, string idSemence, string pbxName)
        {
            cmd = new MySqlCommand(UPDATECHAMPS, connectionDB);

            cmd.Parameters.AddWithValue("@temps", temps);
            cmd.Parameters.AddWithValue("@idSemence", idSemence);
            cmd.Parameters.AddWithValue("@pbxName", pbxName);

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

        public void UpdateEntrepot(string idItem, int qte)
        {
            cmd = new MySqlCommand(UPDATEENTRPOT, connectionDB);

            cmd.Parameters.AddWithValue("@item", qte);
            cmd.Parameters.AddWithValue("@idItem", idItem);

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

        public void UpdateAnimaux(string nomAnimal, int nbrAnimaux, int TempsProdActu)
        {
            cmd = new MySqlCommand(UPDATEANIMAUX, connectionDB);

            cmd.Parameters.AddWithValue("@nbrAnim", nbrAnimaux);
            cmd.Parameters.AddWithValue("@tempsProd", TempsProdActu);
            cmd.Parameters.AddWithValue("@idAnimal", nomAnimal);

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

        public void UpdateArgent(int argent)
        {
            cmd = new MySqlCommand(UPDATEARGENT, connectionDB);

            cmd.Parameters.AddWithValue("@argent", argent);

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

        public void chargerChamps()
        {
            cmd = new MySqlCommand(SELECTCHAMPS, connectionDB);
            
            try
            {
                connectionDB.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PictureBox pbx = this.Controls.Find(reader[0].ToString(), true).FirstOrDefault() as PictureBox;
                    
                    pbx.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(reader[2].ToString());
                    
                    repertoryChamps.Add(reader[0].ToString(), new Champs(pbx, reader[2].ToString()));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connectionDB.Close();
        }

        public void chargerAnimaux()
        {
            cmd = new MySqlCommand(SELECTANIMAUX, connectionDB);

            try
            {
                connectionDB.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                /*while (reader.Read())
                {
                    Label pbx = this.Controls.Find(reader[0].ToString(), true).FirstOrDefault() as Label;

                    pbx.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(reader[2].ToString());

                    repertoryAnimaux.Add(reader[0].ToString(), new Animaux());
                }*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connectionDB.Close();
        }

        public void chargerArgent()
        {
            cmd = new MySqlCommand(SELECTARGENT, connectionDB);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Console.WriteLine(reader.GetValue(0));
                    argent = Convert.ToInt32(reader.GetValue(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }

            connectionDB.Close();
        }
    }
}