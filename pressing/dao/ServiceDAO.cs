using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pressing.classes;
using MySql.Data.MySqlClient;

namespace pressing.dao
{
    public class ServiceDAO
    {
        public bool ajouter(Service service)
        {
            connection.command.CommandText = "INSERT INTO service(nom) VALUES (?nom)";
            connection.command.Parameters.AddWithValue("?nom", service.getNom());
            connection.command.ExecuteNonQuery();
            connection.command.Parameters.Clear();
            service.setId((int)connection.command.LastInsertedId);
            return true;
        }

        public bool modifier(Service service)
        {
            return true;
        }

        public bool supprimer(Service service)
        {
            return true;
        }

        public List<Service> getAll()
        {
            List<Service> list = new List<Service>();
            connection.command.CommandText = "SELECT * FROM service";
            MySqlDataReader reader = connection.command.ExecuteReader();
            while (reader.Read())
            {
                int id = Int32.Parse(reader["idserv"].ToString());
                Service service = new Service(id, reader["nom"].ToString());
                list.Add(service);
            }
            reader.Close();
            return list;
        }
    }
}
