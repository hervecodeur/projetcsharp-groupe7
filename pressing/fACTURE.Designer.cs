namespace pressing
{
    partial class fACTURE
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
            this.montantpayer = new System.Windows.Forms.TextBox();
            this.numeroarmoire = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.tab1 = new System.Windows.Forms.DataGridView();
            this.idfacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroamoire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columm3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalapayer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtedepot = new System.Windows.Forms.DateTimePicker();
            this.dteretrait = new System.Windows.Forms.DateTimePicker();
            this.dtedisponible = new System.Windows.Forms.DateTimePicker();
            this.textInfoClient = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bntdelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnokay = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tab1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // montantpayer
            // 
            this.montantpayer.Location = new System.Drawing.Point(380, 193);
            this.montantpayer.Name = "montantpayer";
            this.montantpayer.Size = new System.Drawing.Size(100, 22);
            this.montantpayer.TabIndex = 3;
            // 
            // numeroarmoire
            // 
            this.numeroarmoire.Location = new System.Drawing.Point(150, 191);
            this.numeroarmoire.Name = "numeroarmoire";
            this.numeroarmoire.Size = new System.Drawing.Size(100, 22);
            this.numeroarmoire.TabIndex = 5;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(251, 256);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 6;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.Location = new System.Drawing.Point(368, 256);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(75, 23);
            this.btnsuprimer.TabIndex = 7;
            this.btnsuprimer.Text = "Suprimer";
            this.btnsuprimer.UseVisualStyleBackColor = true;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(480, 256);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(75, 23);
            this.btnmodifier.TabIndex = 8;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(45, 256);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(47, 23);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.ok_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(119, 256);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(75, 23);
            this.btnannuler.TabIndex = 10;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // tab1
            // 
            this.tab1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfacture,
            this.numeroamoire,
            this.datedepot,
            this.Column1,
            this.Column2,
            this.Columm3,
            this.Column3});
            this.tab1.Location = new System.Drawing.Point(22, 343);
            this.tab1.Name = "tab1";
            this.tab1.RowTemplate.Height = 24;
            this.tab1.Size = new System.Drawing.Size(850, 265);
            this.tab1.TabIndex = 11;
            this.tab1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idfacture
            // 
            this.idfacture.HeaderText = "IdentifiantFacture";
            this.idfacture.Name = "idfacture";
            // 
            // numeroamoire
            // 
            this.numeroamoire.HeaderText = "Client";
            this.numeroamoire.Name = "numeroamoire";
            // 
            // datedepot
            // 
            this.datedepot.HeaderText = "numeroAmoire";
            this.datedepot.Name = "datedepot";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "dateDepot";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "dateRetrait";
            this.Column2.Name = "Column2";
            // 
            // Columm3
            // 
            this.Columm3.HeaderText = "dateDisponibilite";
            this.Columm3.Name = "Columm3";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "montantPayer";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "DateRetrait";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "DateDepot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "NumeroAmoire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "MontantPayer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "dateDisponibilite";
            // 
            // totalapayer
            // 
            this.totalapayer.Location = new System.Drawing.Point(673, 114);
            this.totalapayer.Name = "totalapayer";
            this.totalapayer.Size = new System.Drawing.Size(100, 22);
            this.totalapayer.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "TotalAPayer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "Chosir...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtedepot
            // 
            this.dtedepot.Location = new System.Drawing.Point(150, 27);
            this.dtedepot.Name = "dtedepot";
            this.dtedepot.Size = new System.Drawing.Size(200, 22);
            this.dtedepot.TabIndex = 24;
            // 
            // dteretrait
            // 
            this.dteretrait.Location = new System.Drawing.Point(480, 30);
            this.dteretrait.Name = "dteretrait";
            this.dteretrait.Size = new System.Drawing.Size(200, 22);
            this.dteretrait.TabIndex = 25;
            // 
            // dtedisponible
            // 
            this.dtedisponible.Location = new System.Drawing.Point(630, 198);
            this.dtedisponible.Name = "dtedisponible";
            this.dtedisponible.Size = new System.Drawing.Size(200, 22);
            this.dtedisponible.TabIndex = 26;
            // 
            // textInfoClient
            // 
            this.textInfoClient.Enabled = false;
            this.textInfoClient.Location = new System.Drawing.Point(308, 106);
            this.textInfoClient.Name = "textInfoClient";
            this.textInfoClient.Size = new System.Drawing.Size(200, 22);
            this.textInfoClient.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.bntdelete);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnokay);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(878, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 608);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VETEMENTS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 12;
            // 
            // bntdelete
            // 
            this.bntdelete.Location = new System.Drawing.Point(549, 21);
            this.bntdelete.Name = "bntdelete";
            this.bntdelete.Size = new System.Drawing.Size(75, 23);
            this.bntdelete.TabIndex = 11;
            this.bntdelete.Text = "DELETE";
            this.bntdelete.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(418, 19);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(79, 23);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(281, 17);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(281, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 413);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "id";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "type";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PrixUnitaire";
            this.Column6.Name = "Column6";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(118, 380);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 32);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnokay
            // 
            this.btnokay.Location = new System.Drawing.Point(7, 377);
            this.btnokay.Name = "btnokay";
            this.btnokay.Size = new System.Drawing.Size(75, 23);
            this.btnokay.TabIndex = 6;
            this.btnokay.Text = "OKAY";
            this.btnokay.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "DESCRIPTION";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "PRIX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "TYPE";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 276);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // fACTURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textInfoClient);
            this.Controls.Add(this.dtedisponible);
            this.Controls.Add(this.dteretrait);
            this.Controls.Add(this.dtedepot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalapayer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsuprimer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.numeroarmoire);
            this.Controls.Add(this.montantpayer);
            this.Name = "fACTURE";
            this.Text = "fACTURE";
            this.Load += new System.EventHandler(this.fACTURE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox montantpayer;
        private System.Windows.Forms.TextBox numeroarmoire;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.DataGridView tab1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalapayer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtedepot;
        private System.Windows.Forms.DateTimePicker dteretrait;
        private System.Windows.Forms.DateTimePicker dtedisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroamoire;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedepot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columm3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textInfoClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bntdelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnokay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}