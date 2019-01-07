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
    public partial class fACTURE : Form
    {
        private int idClient;
        private String nomClient;
        private String prenomClient;

        string action = "" ;
        public fACTURE()
        {
            InitializeComponent();
        }

        private void fACTURE_Load(object sender, EventArgs e)
        {
            connection.command.CommandText = "select facture.*, personne.nom AS nomClient,  personne.prenom AS prenomClient from facture LEFT JOIN personne ON facture.idpers=personne.idpers";
            MySqlDataReader reader = connection.command.ExecuteReader();
            while (reader.Read())
            {
                String infoClient = reader["nomClient"].ToString() + " " + reader["prenomClient"].ToString();
                Object[] tab = { reader["idfacture"].ToString(), infoClient, reader["numeroamoire"].ToString(), reader["datedepot"].ToString(), reader["dateretrait"].ToString(), reader["datedispo"].ToString(), reader["montantpaye"].ToString() };
                tab1.Rows.Add(tab);
            }
            reader.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            
            this.action = "add";
            dtedepot.Enabled = true;
            dtedisponible.Enabled = true;
            dteretrait.Enabled = true;
            numeroarmoire.Enabled = true;
            montantpayer.Enabled = true;
            btnok.Enabled = true;
            btnannuler.Enabled = true;
            btnajouter.Enabled = false;
          
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (this.action == "add") 
            {


                connection.command.CommandText = "INSERT INTO facture( numeroamoire, datedepot,datedispo , montantpaye, dateretrait, idpers) VALUES(?numeroamoire, ?datedepot, ?datedisponibilite,?montantpayer,?dateretrait,?idClient)";
               connection.command.Parameters.AddWithValue("?numeroamoire", Int32.Parse(numeroarmoire.Text));
                connection.command.Parameters.AddWithValue("?datedepot", dtedepot.Value);
                connection.command.Parameters.AddWithValue("?datedisponibilite", dtedisponible.Value);
                connection.command.Parameters.AddWithValue("?montantpayer", Int32.Parse(montantpayer.Text));
                connection.command.Parameters.AddWithValue("?dateretrait", dteretrait.Value);
                connection.command.Parameters.AddWithValue("?idClient", this.idClient);
                connection.command.ExecuteNonQuery();
                connection.command.Parameters.Clear();
                String infoClient = this.nomClient + " " + this.prenomClient;
                Object[] tab = { connection.command.LastInsertedId, infoClient, numeroarmoire.Text, dtedepot.Text, dtedisponible.Text, montantpayer.Text, dteretrait.Text, connection.command.LastInsertedId };
                tab1.Rows.Add(tab);
                btnok.Enabled = false;
                
            }
            else if(this.action=="update")
            {
                
                int idfact;
                 idfact = Int32.Parse( tab1.CurrentRow.Cells[0].Value.ToString());
                connection.command.CommandText = "update facture set numeroamoire=?numeroamoire where (idfacture=?idfacture)";
                connection.command.CommandText = "update facture set datedepot=?datedepot where (idfacture=?idfacture)";
                connection.command.CommandText = "update facture set dateretrait=?dateretrait where (idfacture=?idfacture)";
                connection.command.CommandText = "update facture set datedispo=?datedispo where (idfacture=?idfacture)";
                connection.command.CommandText = "update facture set montantpaye=?montantpaye where (idfacture=?idfacture)";
                connection.command.CommandText = "update facture set idclient=?idclient where (idfacture=?idfacture)";
                connection.command.Parameters.AddWithValue("?numeroamoire", Int32.Parse(numeroarmoire.Text));
                connection.command.Parameters.AddWithValue("?idfacture",idfact);
                connection.command.Parameters.AddWithValue("?datedepot", dtedepot.Value);
                connection.command.Parameters.AddWithValue("?dateretrait", dteretrait.Value);
                connection.command.Parameters.AddWithValue("?datedispo", dtedisponible.Value);
                connection.command.Parameters.AddWithValue("?montantpaye", Int32.Parse(montantpayer.Text));
                
                connection.command.ExecuteNonQuery();
                connection.command.Parameters.Clear();
               
                tab1.CurrentRow.Cells[2].Value = Int32.Parse(numeroarmoire.Text);
                tab1.CurrentRow.Cells[3].Value = dtedepot .Value;
                tab1.CurrentRow.Cells[4].Value = dteretrait.Value;
                tab1.CurrentRow.Cells[5].Value = dtedisponible.Value;
                tab1.CurrentRow.Cells[6].Value = Int32.Parse(montantpayer.Text);
                btnok.Enabled = false;
                btnannuler.Enabled = false;
                btnmodifier.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client form = new client(true);
            form.ShowDialog(this);
            this.idClient = form.getIdClient();
            this.nomClient = form.getNomClient();
            this.prenomClient = form.getPrenomClient();
            if (this.idClient != 0)
            {
                textInfoClient.Text = this.nomClient + " " + this.prenomClient;
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if ((tab1.CurrentRow != null) && (tab1.CurrentRow.Cells[0].Value != null))

            {            
                
                numeroarmoire.Text = tab1.CurrentRow.Cells[2].Value.ToString();
                dtedepot.Text = tab1.CurrentRow.Cells[3].Value.ToString();
                dteretrait.Text = tab1.CurrentRow.Cells[4].Value.ToString();
                dtedisponible.Text = tab1.CurrentRow.Cells[5].Value.ToString();
                montantpayer.Text = tab1.CurrentRow.Cells[6].Value.ToString();
                this.action = "update";
                numeroarmoire.Enabled = true;
               dtedepot.Enabled = true;
                dteretrait.Enabled = true;
                dtedisponible.Enabled = true;
                montantpayer.Enabled = true;
                btnok.Enabled = true;
                btnannuler.Enabled = true;
                btnmodifier.Enabled = false;
            
            }

        }

        private void btnsuprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnannuler_Click(object sender, EventArgs e)
        {

        }

        
    }
}
