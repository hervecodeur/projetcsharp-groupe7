using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pressing
{
    public partial class FormDefaultLayout : Form
    {
        protected String action = "";
        public FormDefaultLayout()
        {
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

        }

        public bool isDataSelected()
        {
            bool isSelected = false;
            if ((this.dgvDonnees.CurrentRow != null) && (this.dgvDonnees.CurrentRow.Cells[0].Value != null))
            {
                isSelected = false;
            }
            return isSelected;
        }

        public void remplirChamps()
        {
            
        }

        public void viderChamps()
        {

        }

        public bool validerChamps()
        {
            return true;
        }

        public bool suppimerInformation()
        {
            return true;
        }

        public bool insererInformation()
        {
            return true;
        }

        public bool modifierInformation()
        {
            return true;
        }

        private void panelEdition_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDonnees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
