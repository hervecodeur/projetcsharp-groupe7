using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pressing.classes
{
   public class Employe
    {
       
         private String nom;
        private String prenom;
        private String tel;
        private String adresse;
        private int idemploye;
        private String nomservice;
       private int idservice;
        
        public Employe (int idemploye,  String nom,String prenom,String tel,String adresse,int idservice)
        {
            this.setIdEmploye(idemploye);
            
            this.setNom(nom);
            this.setNomservice(nomservice);
            this.setPrenom(prenom);
            this.setTel(tel);
            this.setAdresse(adresse);
             this.setIdService(idservice);
        }
        public Employe( String nom,String prenom,String tel,String adresse)
        {
            this.setNom(nom);
            this.setPrenom(prenom);
            this.setTel(tel);
            this.setAdresse(adresse);
        }

        public Employe()
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

        public String getNomservice()
        {
            return this.nomservice;
        }

        public void setNomservice(String nomservice)
        {
            this.nomservice = nomservice;
        }

        public int getIdEmploye()
        {
            return this.idemploye;
        }

        public void setIdEmploye(int idemploye)
        {
            this.idemploye =idemploye;
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
       
        public int getIdService()
        {
            return this.idservice;
        }

        public void setIdService(int idservice)
        {
            this.idservice =idservice;
        }
    
    
    }
}

    

