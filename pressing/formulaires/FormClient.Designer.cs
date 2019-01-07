namespace pressing.formulaires
{
    partial class FormClient
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
            this.panelEdition = new System.Windows.Forms.Panel();
            this.panelBoutonConfirmation = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelChamps = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.dgvDonnees = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEdition.SuspendLayout();
            this.panelBoutonConfirmation.SuspendLayout();
            this.panelChamps.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdition
            // 
            this.panelEdition.Controls.Add(this.panelBoutonConfirmation);
            this.panelEdition.Controls.Add(this.panelChamps);
            this.panelEdition.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEdition.Location = new System.Drawing.Point(0, 0);
            this.panelEdition.Name = "panelEdition";
            this.panelEdition.Size = new System.Drawing.Size(1341, 251);
            this.panelEdition.TabIndex = 1;
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
            this.panelChamps.Controls.Add(this.label4);
            this.panelChamps.Controls.Add(this.label3);
            this.panelChamps.Controls.Add(this.label2);
            this.panelChamps.Controls.Add(this.label1);
            this.panelChamps.Controls.Add(this.adresse);
            this.panelChamps.Controls.Add(this.tel);
            this.panelChamps.Controls.Add(this.prenom);
            this.panelChamps.Controls.Add(this.nom);
            this.panelChamps.Location = new System.Drawing.Point(223, 12);
            this.panelChamps.Name = "panelChamps";
            this.panelChamps.Size = new System.Drawing.Size(840, 161);
            this.panelChamps.TabIndex = 0;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.btnSupprimer);
            this.panelOptions.Controls.Add(this.btnModifier);
            this.panelOptions.Controls.Add(this.btnAjouter);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 251);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(1341, 86);
            this.panelOptions.TabIndex = 2;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "ADRESSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "TEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "PRENOM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "NOM";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(550, 132);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(100, 22);
            this.adresse.TabIndex = 11;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(237, 132);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(100, 22);
            this.tel.TabIndex = 10;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(550, 16);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 22);
            this.prenom.TabIndex = 9;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(237, 16);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 22);
            this.nom.TabIndex = 8;
            // 
            // dgvDonnees
            // 
            this.dgvDonnees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonnees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonnees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDonnees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonnees.Location = new System.Drawing.Point(0, 337);
            this.dgvDonnees.MultiSelect = false;
            this.dgvDonnees.Name = "dgvDonnees";
            this.dgvDonnees.RowHeadersVisible = false;
            this.dgvDonnees.RowTemplate.Height = 24;
            this.dgvDonnees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonnees.Size = new System.Drawing.Size(1341, 196);
            this.dgvDonnees.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identifiant_Client";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Numero_Telephone";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adresse";
            this.Column5.Name = "Column5";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 533);
            this.Controls.Add(this.dgvDonnees);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.panelEdition);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.panelEdition.ResumeLayout(false);
            this.panelBoutonConfirmation.ResumeLayout(false);
            this.panelChamps.ResumeLayout(false);
            this.panelChamps.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEdition;
        private System.Windows.Forms.Panel panelBoutonConfirmation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panelChamps;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.DataGridView dgvDonnees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}