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

namespace pressing
{
    
    public partial class client : Form
    {
        private int idClient;
        private String nomClient;
        private String prenomClient;
        private bool selectionMode;
        string action = "";
        public client()
        {
            InitializeComponent();
            btnSelectionner.Visible = false;
        }

        public client(bool selectionMode)
        {
            InitializeComponent();
            this.selectionMode = selectionMode;
            if (this.selectionMode == true)
            {
                btnSelectionner.Visible = true;
            }
        }

        private void client_Load(object sender, EventArgs e)
        {
            connection.command.CommandText = "select * from personne";
            MySqlDataReader reader = connection.command.ExecuteReader();
            while (reader.Read())
            {
                Object[] tab = { reader["idpers"].ToString(), reader["nom"].ToString(), reader["prenom"],reader["tel"].ToString(),reader["adresse"].ToString(),reader["idserv"].ToString() };
                dtagridclient.Rows.Add(tab);
            }
            reader.Close();
        }
            

     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtagridclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            this.action = "add";
            nom.Enabled = true;
            prenom.Enabled = true;
            tel.Enabled = true;
            adresse.Enabled = true;
            btnok.Enabled = true;
            btnannuler.Enabled = true;
            btnajouter.Enabled = false;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (this.action == "add")
            {

                
               connection.command.CommandText = "INSERT INTO personne(nom,prenom,tel,adresse) VALUES(?nom,?prenom,?tel,?adresse)";
               connection.command.Parameters.AddWithValue("?nom", nom.Text);
                connection.command.Parameters.AddWithValue("?prenom", prenom.Text);
                connection.command.Parameters.AddWithValue("tel",tel.Text);
                connection.command.Parameters.AddWithValue("?adresse", adresse.Text);
                connection.command.ExecuteNonQuery();
                connection.command.Parameters.Clear();
                Object[] tab = { connection.command.LastInsertedId, nom.Text, prenom.Text, tel.Text, adresse.Text };
                dtagridclient.Rows.Add(tab);
                btnok.Enabled = false;
                
            }
            else if(this.action=="update")
            {
                
                int idpersonne;
                 idpersonne = Int32.Parse( dtagridclient.CurrentRow.Cells[0].Value.ToString());
                connection.command.CommandText = "update personne set nom=?nom where (idpers=?idpers)";
                connection.command.CommandText = "update personne set prenom=?prenom where (idpers=?idpers)";
                connection.command.CommandText = "update personne set tel=?tel where (idpers=?idpers)";
                connection.command.CommandText = "update personne set adresse=?adresse where (idpers=?idpers)";
                connection.command.Parameters.AddWithValue("?nom", nom.Text);
                connection.command.Parameters.AddWithValue("?idpers", idpersonne);
                connection.command.Parameters.AddWithValue("?prenom",prenom.Text );
                connection.command.Parameters.AddWithValue("?tel",tel.Text);
                connection.command.Parameters.AddWithValue("?adresse", adresse.Text);
                connection.command.ExecuteNonQuery();
                connection.command.Parameters.Clear();
                dtagridclient.CurrentRow.Cells[1].Value = nom.Text;
                dtagridclient.CurrentRow.Cells[2].Value = prenom.Text;
                dtagridclient.CurrentRow.Cells[3].Value = tel.Text;
                dtagridclient.CurrentRow.Cells[4].Value = adresse.Text;
                btnok.Enabled = false;
                btnannuler.Enabled = false;
                btnmodifier.Enabled = true;
                
                
                }
        
            }
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if ((dtagridclient.CurrentRow != null) && (dtagridclient.CurrentRow.Cells[0].Value != null))
            {
                nom.Text = dtagridclient.CurrentRow.Cells[1].Value.ToString();
                prenom.Text = dtagridclient.CurrentRow.Cells[2].Value.ToString();
                tel.Text = dtagridclient.CurrentRow.Cells[3].Value.ToString();
                adresse.Text = dtagridclient.CurrentRow.Cells[4].Value.ToString();
                this.action = "update";
                nom.Enabled = true;
                 prenom.Enabled = true;
                 tel.Enabled = true;
                 adresse.Enabled = true;
                btnok.Enabled = true;
                btnannuler.Enabled = true;
                btnmodifier.Enabled = false;
            }

        }

        private void btnsuprimer_Click(object sender, EventArgs e)
        {
            int id;
            if ((dtagridclient.CurrentRow != null) && (dtagridclient.CurrentRow.Cells[0].Value != null))
            {
                id = Int32.Parse(dtagridclient.CurrentRow.Cells[0].Value.ToString());
                connection.command.CommandText = "Delete from personne where(idpers=?idpers)";
                connection.command.Parameters.AddWithValue("?idpers", id);
                connection.command.ExecuteNonQuery();
                connection.command.Parameters.Clear();
                dtagridclient.Rows.RemoveAt(dtagridclient.CurrentRow.Index);
            }

        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            prenom.Text ="";
            tel.Text ="";
            adresse.Text ="";
            btnok.Enabled = false;
            btnannuler.Enabled = false;
            btnajouter.Enabled = true;
            nom.Enabled = false;
            prenom.Enabled = false;
            tel.Enabled = false;
            adresse.Enabled = false;
            btnmodifier.Enabled = true;

        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if ((dtagridclient.CurrentRow != null) && (dtagridclient.CurrentRow.Cells[0].Value != null))
            {
                this.idClient = Int32.Parse(dtagridclient.CurrentRow.Cells[0].Value.ToString());
                this.nomClient = dtagridclient.CurrentRow.Cells[1].Value.ToString();
                this.prenomClient = dtagridclient.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
        }

        public int getIdClient()
        {
            return this.idClient;
        }

        public String getNomClient()
        {
            return this.nomClient;
        }

        public String getPrenomClient()
        {
            return this.prenomClient;
        }
    }
}
