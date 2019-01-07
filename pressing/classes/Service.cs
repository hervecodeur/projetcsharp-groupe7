using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pressing.classes
{
    public class Service
    {
        private String nom;
        private int id;
        public Service(int id, String nom)
        {
            this.setId(id);
            this.setNom(nom);
        }
        public Service(String nom)
        {
            this.setNom(nom);
        }

        public Service()
        {
            
        }

        

        public String getNom()
        {
            return this.nom;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return this.nom;
        }
    }
}
