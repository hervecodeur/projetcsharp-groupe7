using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pressing.formulaires
{
    public partial class FormPrincipale : Form
    {
        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormService form = new FormService();
            this.changeActiveForm(form);
        }

        private void changeActiveForm(Form form)
        {
            form.MdiParent = this;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fACTURE factures = new fACTURE();
            this.changeActiveForm(factures);

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormClient clients = new FormClient();
            this.changeActiveForm(clients);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            FormEmploye employes = new FormEmploye();
            this.changeActiveForm(employes);

        }
    }
}
