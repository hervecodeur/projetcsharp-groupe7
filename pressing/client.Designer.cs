namespace pressing
{
    partial class client
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
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.dtagridclient = new System.Windows.Forms.DataGridView();
            this.idpers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectionner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridclient)).BeginInit();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(93, 73);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 22);
            this.nom.TabIndex = 0;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(406, 73);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 22);
            this.prenom.TabIndex = 1;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(93, 189);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(100, 22);
            this.tel.TabIndex = 2;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(406, 189);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(100, 22);
            this.adresse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRENOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "TEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ADRESSE";
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(852, 71);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(92, 24);
            this.btnajouter.TabIndex = 8;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(852, 159);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(92, 27);
            this.btnmodifier.TabIndex = 9;
            this.btnmodifier.Text = "MODIFIER";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.Location = new System.Drawing.Point(852, 206);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(92, 43);
            this.btnsuprimer.TabIndex = 10;
            this.btnsuprimer.Text = "SUPRIMER";
            this.btnsuprimer.UseVisualStyleBackColor = true;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // btnok
            // 
            this.btnok.Enabled = false;
            this.btnok.Location = new System.Drawing.Point(93, 293);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 35);
            this.btnok.TabIndex = 11;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.Enabled = false;
            this.btnannuler.Location = new System.Drawing.Point(406, 293);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(100, 35);
            this.btnannuler.TabIndex = 12;
            this.btnannuler.Text = "ANNULER";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // dtagridclient
            // 
            this.dtagridclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtagridclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagridclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpers,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtagridclient.Location = new System.Drawing.Point(93, 348);
            this.dtagridclient.Name = "dtagridclient";
            this.dtagridclient.RowHeadersVisible = false;
            this.dtagridclient.RowTemplate.Height = 24;
            this.dtagridclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtagridclient.Size = new System.Drawing.Size(851, 228);
            this.dtagridclient.TabIndex = 13;
            // 
            // idpers
            // 
            this.idpers.HeaderText = "IdentifiantPersonne";
            this.idpers.Name = "idpers";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "nom";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "prenom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "tel";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "adresse";
            this.Column4.Name = "Column4";
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(845, 285);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(108, 42);
            this.btnSelectionner.TabIndex = 14;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 590);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.dtagridclient);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnsuprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Name = "client";
            this.Text = "client";
            this.Load += new System.EventHandler(this.client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagridclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.DataGridView dtagridclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnSelectionner;
    }
}