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
    public partial class FormService : Form
    {
        protected String action = "";
        protected ServiceDAO dao;
        protected bool modeSelection = false;
        protected Service serviceSelectionne;
        public FormService()
        {
            dao = new ServiceDAO();
            InitializeComponent();
            onInitForm();
            this.btnSelectionner.Visible = false;
        }
        public FormService(bool modeSelection)
        {
            dao = new ServiceDAO();
            InitializeComponent();
            onInitForm();
            this.modeSelection = modeSelection;
            this.btnSelectionner.Visible = true;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            onAjouterClick();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            onModifierClick();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            onOkClick();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            onAnnulerClick();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            onSupprimerClick();
        }

        private void onAjouterClick()
        {
            this.action = "add";
            this.panelEdition.Visible = true;
            this.panelListe.Visible = false;
            this.viderChamps();
        }

        private void onModifierClick()
        {
            if (this.isDataSelected())
            {
                this.action = "update";
                this.panelEdition.Visible = true;
                this.panelListe.Visible = false;
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
                this.panelListe.Visible = true;
                this.panelEdition.Visible = false;
            }
        }

        private void onAnnulerClick()
        {
            this.panelListe.Visible = true;
            this.panelEdition.Visible = false;
        }


        protected void onInitForm()
        {
            chargerDonnees();
            this.panelEdition.Visible = false;

        }

        protected void chargerDonnees()
        {
            List<Service> services = dao.getAll();
            foreach(Service service in services){
                Object[] tab = { service.getId(), service.getNom() };
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
            textNom.Text = dgvDonnees.CurrentRow.Cells[1].Value.ToString();
        }

        public void viderChamps()
        {
            textNom.Text = "";
        }

        public bool validerChamps()
        {
            bool resultat = true;
            if (textNom.Text == "")
            {
                resultat = false;
                MessageBox.Show("Veuillez entrer le nom");
            }
            return resultat;
        }

        public bool suppimerInformation()
        {
            return true;
        }

        public bool insererInformation()
        {
            Service objet = new Service(textNom.Text);
            bool resultat = dao.ajouter(objet);
            if (resultat)
            {
                Object[] tab = { objet.getId(), objet.getNom() };
                dgvDonnees.Rows.Add(tab);
            }
            return resultat;
        }

        public bool modifierInformation()
        {
            int id = Int32.Parse(dgvDonnees.CurrentRow.Cells[0].Value.ToString());
            Service objet = new Service(id, textNom.Text);
            bool resultat = dao.modifier(objet);
            if (resultat)
            {
                dgvDonnees.CurrentRow.Cells[1].Value = objet.getNom();
            }
            return resultat;
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (this.isDataSelected())
            {
                int id = Int32.Parse(dgvDonnees.CurrentRow.Cells[0].Value.ToString());
                serviceSelectionne = new Service(id, dgvDonnees.CurrentRow.Cells[1].Value.ToString());
                this.Close();
            }
        }

        public Service getServiceSelectionne()
        {
            return this.serviceSelectionne;
        }
    }
}
