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
    public partial class Form1 : Form
    {
        string action="";
        public Form1()
        {
            InitializeComponent();

        }

        private void Datagridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        
            
        private void Form1_Load(object sender, EventArgs e)
        {
            connection.command.CommandText = "SELECT * FROM service";
            MySqlDataReader reader =connection.command.ExecuteReader();
            while (reader.Read())
            {
                Object[] tab = { reader["idserv"].ToString(), reader["nom"].ToString()};
                dataGridView1.Rows.Add(tab);
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.action == "add")
            {
                connection.command.CommandText = "INSERT INTO service(nom) VALUES (?nom)";
                connection.command.Parameters.AddWithValue("?nom", nomservice.Text);
                connection.command.ExecuteNonQuery();
                connection.command.Parameters.Clear();
                Object[] tab = { connection.command.LastInsertedId, nomservice.Text };
                dataGridView1.Rows.Add(tab);
                btnok.Enabled = false;
                btnCancel.Enabled = false;
                btnajouter.Enabled = true;
                nomservice.Enabled = false;
            }
            else if(this.action=="update")

            {
                int idservice;
                 idservice = Int32.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
                connection.command.CommandText = "update service set nom=?nom where (idserv=?idserv)";
                connection.command.Parameters.AddWithValue("?nom", nomservice.Text);
                connection.command.Parameters.AddWithValue("?idserv", idservice);
                connection.command.ExecuteNonQuery();
                connection.command.Parameters.Clear();
                dataGridView1.CurrentRow.Cells[1].Value = nomservice.Text;

                btnok.Enabled = false;
                btnCancel.Enabled = false;
                btnModifier.Enabled = true;
                nomservice.Enabled = false;
                
            }
            nomservice.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            nomservice.Text = "";
            btnok.Enabled = false;
            btnCancel.Enabled = false;
            btnajouter.Enabled = true;
            nomservice.Enabled = false;
            btnModifier.Enabled = true;
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            this.action = "add";
            nomservice.Enabled = true;
            btnok.Enabled = true;
            btnCancel.Enabled = true;
            btnajouter.Enabled = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.CurrentRow.Cells[0].Value != null))
            {
                nomservice.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.action = "update";
                btnok.Enabled = true;

                nomservice.Enabled = true;
                btnok.Enabled = true;
                btnCancel.Enabled = true;
                btnModifier.Enabled = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int id;
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.CurrentRow.Cells[0].Value != null))
            {
                id = Int32.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
                connection.command.CommandText = "Delete from service where(idserv=?idserv)";
                connection.command.Parameters.AddWithValue("?idserv", id);
                connection.command.ExecuteNonQuery();
                connection.command.Parameters.Clear();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
