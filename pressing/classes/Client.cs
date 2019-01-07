using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pressing.classes
{
    public  class Client
    {
         private String nom;
        private String prenom;
        private String tel;
        private String adresse;
        private int idclient;
        
        public Client(int idclient,  String nom,String prenom,String tel,String adresse)
        {
            this.setIdClient(idclient);
            
            this.setNom(nom);
            this.setPrenom(prenom);
            this.setTel(tel);
            this.setAdresse(adresse);
        }
        public Client( String nom,String prenom,String tel,String adresse)
        {
            this.setNom(nom);
            this.setPrenom(prenom);
            this.setTel(tel);
            this.setAdresse(adresse);
        }

        public Client()
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

        public int getIdClient()
        {
            return this.idclient;
        }

        public void setIdClient(int idclient)
        {
            this.idclient = idclient;
        }
        public String getPrenom()
        {
            return this.prenom;
        }

        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }
        
        public String getTel()
        {
            return this.tel;
        }

        public void setTel(String tel)
        {
            this.tel = tel;
        }

        public String getAdresse()
        {
            return this.adresse;
        }

        public void setAdresse(String adresse)
        {
            this.adresse = adresse;
        }
    
    
    }
}
