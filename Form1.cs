using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opticien
{
    public partial class Opticien : Form
    {
        public Opticien()
        {
            InitializeComponent();
        }

        private void Opticien_Load(object sender, EventArgs e)
        {
            controlleur.init();
            controlleur.VModele.seConnecter();
            controlleur.VModele.chargerMarque();
            marque();
            if (controlleur.VModele.Connopen)
            {
                MessageBox.Show("Vous êtes bien connecté");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Opticien_FormClosed(object sender, FormClosedEventArgs e)
        {
            controlleur.VModele.sedeconnecter();
        }

        public void marque()
        {
            for (int i = 0; i < controlleur.VModele.DT1[0].Rows.Count; i++)
            {
                cbMarque.Items.Add(controlleur.VModele.DT1[0].Rows[i]["NOMMARQUE"]);
            }
        }
        public void categori()
        {

        }

    }
}
