using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pressing.classes;
using MySql.Data.MySqlClient;

namespace pressing.dao
{
    public class ClientDao
    {
        public bool ajouter(Client client)
        {
            connection.command.CommandText = "INSERT INTO personne(nom,prenom,tel,adresse) VALUES (?nom,?prenom,?tel,?adresse)";
            connection.command.Parameters.AddWithValue("?nom", client.getNom());
            connection.command.Parameters.AddWithValue("?prenom", client.getPrenom());
            connection.command.Parameters.AddWithValue("?tel", client.getTel());
            connection.command.Parameters.AddWithValue("?adresse", client.getAdresse());
            connection.command.ExecuteNonQuery();
            connection.command.Parameters.Clear();
            client.setIdClient((int)connection.command.LastInsertedId);
            return true;
        }

        public bool modifier(Client client)
        {
            return true;
        }

        public bool supprimer(Client client)
        {
            return true;
        }

        public List<Client> getAll()
        {
            List<Client> list = new List<Client>();
            connection.command.CommandText = "SELECT * FROM personne";
            MySqlDataReader reader = connection.command.ExecuteReader();
            while (reader.Read())
            {
                int idclient = Int32.Parse(reader["idpers"].ToString());
               
                Client client = new Client(idclient, reader["nom"].ToString(), reader["prenom"].ToString(), reader["tel"].ToString(), reader["adresse"].ToString());
                list.Add(client);
            }
            reader.Close();
            return list;
        }
    }
}
