using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pressing.classes;
using MySql.Data.MySqlClient;

namespace pressing.dao
{
   public class EmployeDAO
    {
         public bool ajouter(Employe employe)
        {
            connection.command.CommandText = "INSERT INTO personne(nom,prenom,tel,adresse,idserv) VALUES (?nom,?prenom,?tel,?adresse,?idserv)";
            connection.command.Parameters.AddWithValue("?nom", employe.getNom());
            connection.command.Parameters.AddWithValue("?prenom", employe.getPrenom());
            connection.command.Parameters.AddWithValue("?tel", employe.getTel());
            connection.command.Parameters.AddWithValue("?adresse", employe.getAdresse());
             connection.command.Parameters.AddWithValue("?idserv", employe.getIdService());

            connection.command.ExecuteNonQuery();
            connection.command.Parameters.Clear();
            employe.setIdEmploye((int)connection.command.LastInsertedId);
            return true;
        }

        public bool modifier(Employe employe)
        {
            return true;
        }

        public bool supprimer(Employe employe)
        {
            return true;
        }

        public List<Employe> getAll()
        {
            List<Employe> list = new List<Employe>();
            connection.command.CommandText = "SELECT * FROM personne";
            MySqlDataReader reader = connection.command.ExecuteReader();
            while (reader.Read())
            {
                int idemploye = Int32.Parse(reader["idpers"].ToString());
                int idservice = 0;
                if (reader["idserv"] != System.DBNull.Value)
                {
                    idservice = Int32.Parse(reader["idserv"].ToString());
                }
               
                Employe employe = new Employe(idemploye, reader["nom"].ToString(), reader["prenom"].ToString(), reader["tel"].ToString(), reader["adresse"].ToString(),idservice);
                list.Add(employe);
            }
            reader.Close();
            return list;
        }
    }
}

    

