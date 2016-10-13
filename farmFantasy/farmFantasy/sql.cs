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
    public partial class frmMain : Form
    {
        static string infoDB = "server=127.0.0.1;user=root;database=farmfantasy;password=;";
        MySqlConnection connectionDB = new MySqlConnection(infoDB);
        MySqlCommand cmd;

        public void Sauvegarder()
        {

        }

        public void UpdateChamps(int temps, string idSemence, string pbxName)
        {
            string requette = "UPDATE `champs` SET `tempsRestant`=@temps,`idNomSemence`=@idSemence WHERE idChamps=@pbxName";

            cmd = new MySqlCommand(requette, connectionDB);

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
                throw;
            }
            connectionDB.Close();
        }

        public void UpdateEntrepot(string idItem, int qte)
        {
            string requette = "UPDATE `entrepots` SET `qteItem`=@item WHERE idNomItem=@idItem";

            cmd = new MySqlCommand(requette, connectionDB);

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
            string requette = "UPDATE `animaux` SET `nbrAnimaux`=@nbrAnim, `tempProdActu`=@tempsProd WHERE idNomAnimal=@idAnimal";

            cmd = new MySqlCommand(requette, connectionDB);

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
    }
}