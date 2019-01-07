namespace pressing.formulaires
{
    partial class FormService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelListe = new System.Windows.Forms.Panel();
            this.dgvDonnees = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panelEdition = new System.Windows.Forms.Panel();
            this.panelBoutonConfirmation = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelChamps = new System.Windows.Forms.Panel();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).BeginInit();
            this.panelOptions.SuspendLayout();
            this.panelEdition.SuspendLayout();
            this.panelBoutonConfirmation.SuspendLayout();
            this.panelChamps.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelListe);
            this.panelPrincipal.Controls.Add(this.panelEdition);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(935, 452);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelListe
            // 
            this.panelListe.Controls.Add(this.dgvDonnees);
            this.panelListe.Controls.Add(this.panelOptions);
            this.panelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListe.Location = new System.Drawing.Point(0, 251);
            this.panelListe.Name = "panelListe";
            this.panelListe.Size = new System.Drawing.Size(935, 201);
            this.panelListe.TabIndex = 1;
            // 
            // dgvDonnees
            // 
            this.dgvDonnees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonnees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonnees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.NomCol});
            this.dgvDonnees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonnees.Location = new System.Drawing.Point(0, 86);
            this.dgvDonnees.MultiSelect = false;
            this.dgvDonnees.Name = "dgvDonnees";
            this.dgvDonnees.RowHeadersVisible = false;
            this.dgvDonnees.RowTemplate.Height = 24;
            this.dgvDonnees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonnees.Size = new System.Drawing.Size(935, 115);
            this.dgvDonnees.TabIndex = 1;
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "Id";
            this.IdCol.Name = "IdCol";
            // 
            // NomCol
            // 
            this.NomCol.HeaderText = "Nom";
            this.NomCol.Name = "NomCol";
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.btnSelectionner);
            this.panelOptions.Controls.Add(this.btnSupprimer);
            this.panelOptions.Controls.Add(this.btnModifier);
            this.panelOptions.Controls.Add(this.btnAjouter);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(935, 86);
            this.panelOptions.TabIndex = 0;
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
            // panelEdition
            // 
            this.panelEdition.Controls.Add(this.panelBoutonConfirmation);
            this.panelEdition.Controls.Add(this.panelChamps);
            this.panelEdition.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEdition.Location = new System.Drawing.Point(0, 0);
            this.panelEdition.Name = "panelEdition";
            this.panelEdition.Size = new System.Drawing.Size(935, 251);
            this.panelEdition.TabIndex = 0;
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
            // panelChamps
            // 
            this.panelChamps.Controls.Add(this.textNom);
            this.panelChamps.Controls.Add(this.label1);
            this.panelChamps.Location = new System.Drawing.Point(405, 21);
            this.panelChamps.Name = "panelChamps";
            this.panelChamps.Size = new System.Drawing.Size(381, 138);
            this.panelChamps.TabIndex = 0;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(151, 20);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(196, 22);
            this.textNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(6, 14);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(160, 54);
            this.btnSelectionner.TabIndex = 3;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 452);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FormService";
            this.Text = "FormService";
            this.panelPrincipal.ResumeLayout(false);
            this.panelListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.panelEdition.ResumeLayout(false);
            this.panelBoutonConfirmation.ResumeLayout(false);
            this.panelChamps.ResumeLayout(false);
            this.panelChamps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelListe;
        private System.Windows.Forms.DataGridView dgvDonnees;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel panelEdition;
        private System.Windows.Forms.Panel panelBoutonConfirmation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panelChamps;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCol;
        private System.Windows.Forms.Button btnSelectionner;
    }
}