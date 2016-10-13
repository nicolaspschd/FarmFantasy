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
        MySqlConnection connectionDB = new MySqlConnection();
        MySqlCommand cmd;
        public void Sauvegarder()
        {

        }
    }
}