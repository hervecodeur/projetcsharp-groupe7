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
    public class DefaultLayout : Form
    {

        public void InitializeFormData()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelEdition = new System.Windows.Forms.Panel();
            this.panelListe = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.dgvDonnees = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.panelChamps = new System.Windows.Forms.Panel();
            this.panelBoutonConfirmation = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelEdition.SuspendLayout();
            this.panelListe.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).BeginInit();
            this.panelBoutonConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelListe);
            this.panelPrincipal.Controls.Add(this.panelEdition);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1286, 525);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelEdition
            // 
            this.panelEdition.Controls.Add(this.panelBoutonConfirmation);
            this.panelEdition.Controls.Add(this.panelChamps);
            this.panelEdition.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEdition.Location = new System.Drawing.Point(0, 0);
            this.panelEdition.Name = "panelEdition";
            this.panelEdition.Size = new System.Drawing.Size(1286, 251);
            this.panelEdition.TabIndex = 0;
            // 
            // panelListe
            // 
            this.panelListe.Controls.Add(this.dgvDonnees);
            this.panelListe.Controls.Add(this.panelOptions);
            this.panelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListe.Location = new System.Drawing.Point(0, 251);
            this.panelListe.Name = "panelListe";
            this.panelListe.Size = new System.Drawing.Size(1286, 274);
            this.panelListe.TabIndex = 1;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.btnSupprimer);
            this.panelOptions.Controls.Add(this.btnModifier);
            this.panelOptions.Controls.Add(this.btnAjouter);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(1286, 86);
            this.panelOptions.TabIndex = 0;
            // 
            // dgvDonnees
            // 
            this.dgvDonnees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonnees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonnees.Location = new System.Drawing.Point(0, 86);
            this.dgvDonnees.Name = "dgvDonnees";
            this.dgvDonnees.RowTemplate.Height = 24;
            this.dgvDonnees.Size = new System.Drawing.Size(1286, 188);
            this.dgvDonnees.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(194, 22);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(174, 47);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(406, 22);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(177, 46);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(610, 23);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(177, 46);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // panelChamps
            // 
            this.panelChamps.Location = new System.Drawing.Point(405, 21);
            this.panelChamps.Name = "panelChamps";
            this.panelChamps.Size = new System.Drawing.Size(381, 138);
            this.panelChamps.TabIndex = 0;
            // 
            // panelBoutonConfirmation
            // 
            this.panelBoutonConfirmation.Controls.Add(this.btnAnnuler);
            this.panelBoutonConfirmation.Controls.Add(this.btnOk);
            this.panelBoutonConfirmation.Location = new System.Drawing.Point(398, 179);
            this.panelBoutonConfirmation.Name = "panelBoutonConfirmation";
            this.panelBoutonConfirmation.Size = new System.Drawing.Size(389, 66);
            this.panelBoutonConfirmation.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(21, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 42);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(198, 12);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(157, 41);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormDefaultLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 525);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FormDefaultLayout";
            this.Text = "FormDefaultLayout";
            this.panelPrincipal.ResumeLayout(false);
            this.panelEdition.ResumeLayout(false);
            this.panelListe.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).EndInit();
            this.panelBoutonConfirmation.ResumeLayout(false);

        }

        protected System.Windows.Forms.Panel panelPrincipal;
        protected System.Windows.Forms.Panel panelListe;
        protected System.Windows.Forms.DataGridView dgvDonnees;
        protected System.Windows.Forms.Panel panelOptions;
        protected System.Windows.Forms.Panel panelEdition;
        protected System.Windows.Forms.Button btnSupprimer;
        protected System.Windows.Forms.Button btnModifier;
        protected System.Windows.Forms.Button btnAjouter;
        protected System.Windows.Forms.Panel panelBoutonConfirmation;
        protected System.Windows.Forms.Button btnAnnuler;
        protected System.Windows.Forms.Button btnOk;
        protected System.Windows.Forms.Panel panelChamps;








        public DefaultLayout()
        {
            onInitForm();
        }

        protected void onInitForm()
        {
            InitializeFormData();
            this.panelEdition.Visible = false;

        }

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            this.panelEdition.Visible = true;
            this.panelListe.Visible = false;
            this.viderChamps();
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            if (this.isDataSelected())
            {
                this.panelEdition.Visible = true;
                this.panelListe.Visible = false;
                this.remplirChamps();
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            this.panelListe.Visible = true;
            this.panelEdition.Visible = false;
        }

        protected void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.panelListe.Visible = true;
            this.panelEdition.Visible = false;
        }

        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (this.isDataSelected())
            {
                if (this.suppimerInformation())
                {
                    dgvDonnees.Rows.RemoveAt(dgvDonnees.CurrentRow.Index);
                }
            }
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

        public bool suppimerInformation()
        {
            return true;
        }
    }







}
