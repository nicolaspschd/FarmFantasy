using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace farmFantasy
{
    static class Sql
    {
        static string infoDB = "server=127.0.0.1;user=root;database=farmfantasy;password=;";
        static MySqlConnection connectionDB = new MySqlConnection(infoDB);
        static MySqlCommand cmd;

        const string UPDATECHAMPS = "UPDATE `champs` SET `tempsRestant`=@temps,`idNomSemence`=@idSemence WHERE idChamps=@pbxName";
        const string UPDATEENTRPOT = "UPDATE `entrepots` SET `qteItem`=@item WHERE idNomItem=@idItem";
        const string UPDATEANIMAUX = "UPDATE `animaux` SET `nbrAnimaux`=@nbrAnim, `tempProdActu`=@tempsProd WHERE idNomAnimal=@idAnimal";
        const string UPDATEARGENT = "UPDATE `joueurs` SET `argent`=@argent WHERE idJoueur=1";
        const string SELECTCHAMPS = "SELECT * FROM champs WHERE idNomSemence != 'rien'";
        const string SELECTARGENT = "SELECT argent FROM joueurs";
        const string SELECTENTREPOT = "SELECT * FROM entrepots";
        const string SELECTANIMAUX = "SELECT * FROM animaux NATURAL JOIN produits";

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

        static public void UpdateChamps(int temps, string idSemence, string pbxName)
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

        static public void UpdateEntrepot(string idItem, int qte)
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

        static public void UpdateAnimaux(string nomAnimal, int nbrAnimaux, int TempsProdActu)
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

        static public void UpdateArgent(int argent)
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

        static public Dictionary<string, Champs> chargerChamps(frmMain FrmMain)
        {
            Dictionary<string, Champs> dico = new Dictionary<string, Champs>();
            cmd = new MySqlCommand(SELECTCHAMPS, connectionDB);

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

        static public void chargerAnimaux(frmMain FrmMain)
        {
            cmd = new MySqlCommand(SELECTANIMAUX, connectionDB);

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

        static public void chargerArgent()
        {
            int argent = 0;
            cmd = new MySqlCommand(SELECTARGENT, connectionDB);

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
        }

        static public void chargerEntrepot(frmMain FrmMain)
        {
            cmd = new MySqlCommand(SELECTENTREPOT, connectionDB);

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
    }
}
