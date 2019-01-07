using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using pressing.dao;
using pressing.classes;


namespace pressing.formulaires
{
    public partial class FormEmploye : Form
    {
        protected String action = "";
        protected EmployeDAO dao;
        protected Service service;
       
        public FormEmploye()
        {
            dao = new EmployeDAO();
            InitializeComponent();
            onInitForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            onAjouterClick();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            onModifierClick();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            onSupprimerClick();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            onOkClick();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            onAnnulerClick();
        }
        
        private void onAjouterClick()
        {
            this.action = "add";
            this.panelEdition.Visible = true;
            
            this.viderChamps();
        }

        private void onModifierClick()
        {
            if (this.isDataSelected())
            {
                this.action = "update";
                this.panelEdition.Visible = true;
                
                this.remplirChamps();
            }
        }

        private void onSupprimerClick()
        {
            if (this.isDataSelected())
            {
                if (this.suppimerInformation())
                {
                    dgvDonnees.Rows.RemoveAt(dgvDonnees.CurrentRow.Index);
                }
            }
        }

        private void onOkClick()
        {
            if (validerChamps())
            {
                if (this.action == "add")
                {
                    this.insererInformation();
                }
                else if (this.action == "update")
                {
                    this.modifierInformation();
                }
                
                this.panelEdition.Visible = false;
            }
        }

        private void onAnnulerClick()
        {
            
            this.panelEdition.Visible = false;
        }


        protected void onInitForm()
        {
            chargerDonnees();
            this.panelEdition.Visible = false;

        }

        protected void chargerDonnees()
        {
            List<Employe> employes = dao.getAll();
            foreach (Employe employe in employes)
            {
                Object[] tab = { employe.getIdEmploye(), employe.getNom(), employe.getPrenom(), employe.getTel(), employe.getAdresse(), employe.getIdService() };
                dgvDonnees.Rows.Add(tab);
            }
        }

        public bool isDataSelected()
        {
            bool isSelected = false;
            if ((this.dgvDonnees.CurrentRow != null) && (this.dgvDonnees.CurrentRow.Cells[0].Value != null))
            {
                isSelected = true;
            }
            return isSelected;
        }

        public void remplirChamps()
        {
            nom.Text = dgvDonnees.CurrentRow.Cells[1].Value.ToString();
            prenom.Text = dgvDonnees.CurrentRow.Cells[2].Value.ToString();
            tel.Text = dgvDonnees.CurrentRow.Cells[3].Value.ToString();
            adresse.Text = dgvDonnees.CurrentRow.Cells[4].Value.ToString();
            
        }
        public void viderChamps()
        {
            nom.Text = "";
            prenom.Text = "";
            tel.Text = "";
            adresse.Text = "";

        }

        public bool validerChamps()
        {
            bool resultat1 = true;
            
            
            if (nom.Text == "")
            {
                resultat1 = false;
                MessageBox.Show("Veuillez entrer le nom");
            }

            if (prenom.Text == "")
            
            {
                resultat1 = false;
                MessageBox.Show("Veuillez entrer le prenom");
            }
            

            if (tel.Text == "")
            {
                resultat1 = false;
                MessageBox.Show("Veuillez entrer le numero de telephone ");
            }
            
            if (adresse.Text == "")
            {
                resultat1 = false;
                MessageBox.Show("Veuillez entrer l'Adresse");
            }

            if (this.service == null)
            {
                resultat1 = false;
                MessageBox.Show("Veuillez selectionner un service");
            }
            return resultat1;
        }

        public bool suppimerInformation()
        {
            return true;
        }

        public bool insererInformation()
        {
            Employe objet = new Employe(nom.Text, prenom.Text, tel.Text, adresse.Text);
            objet.setIdService(this.service.getId());
            bool resultat = dao.ajouter(objet);
            if (resultat)
            {
                Object[] tab = { objet.getIdEmploye(), objet.getNom(), objet.getPrenom(), objet.getTel(), objet.getAdresse(), objet.getIdService(), service.getNom() };
                dgvDonnees.Rows.Add(tab);
            }
            return resultat;
        }
        
        public bool modifierInformation()
        {
            int idemploye = Int32.Parse(dgvDonnees.CurrentRow.Cells[0].Value.ToString());
            int idservice = Int32.Parse(dgvDonnees.CurrentRow.Cells[5].Value.ToString());
            Employe objet = new Employe(idemploye, nom.Text, prenom.Text, tel.Text, adresse.Text,idservice);
            bool resultat = dao.modifier(objet);
            if (resultat)
            {
                dgvDonnees.CurrentRow.Cells[1].Value = objet.getNom();
                dgvDonnees.CurrentRow.Cells[2].Value = objet.getPrenom();
                dgvDonnees.CurrentRow.Cells[3].Value = objet.getTel();
                dgvDonnees.CurrentRow.Cells[4].Value = objet.getAdresse();
                
            }
            return resultat;


       }

    



        private void panelChamps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEdition_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelOptions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDonnees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormService form = new FormService(true);
            form.ShowDialog(this);
            service = form.getServiceSelectionne();
            Infoservice.Text = service.ToString();
        }

        
    }
}
