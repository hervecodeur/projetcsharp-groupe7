using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace pressing
{
    class connection
    {
        public static MySqlConnection connexion;
        public static MySqlCommand command;
        public static bool ouvrirConnection()
        {
            try
            {
                string chaineConnexion = "Database=pressing; data source=localhost;user id=root;password=; port=3306";
                connexion = new MySqlConnection (chaineConnexion);
                connexion.Open();
                command = connexion.CreateCommand();
                return true;
            }
            catch
            {
             
                
                fermerConnexion();
                MessageBox.Show("probleme de connection a la base de donnees", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static void fermerConnexion()
        {
            if (command != null)
            {
                command.Dispose();
                connexion.Close();
            
            }
        }
    }
}
