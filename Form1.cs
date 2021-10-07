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

        public void marque()
        {
            for (int i = 0; i < controlleur.VModele.DT1[0].Rows.Count; i++)
            {
                cbMarque.Items.Add(controlleur.VModele.DT1[0].Rows[i]["NOMMARQUE"]);
            }
        }

        public void categorie()
        {
            for (int i = 0; i < controlleur.VModele.DT1[1].Rows.Count; i++)
            {
                cbCategorie.Items.Add(controlleur.VModele.DT1[1].Rows[i]["NOMLIBELLE"]);
            }
        }

        public void modele()
        {
            for (int i = 0; i < controlleur.VModele.DT1[2].Rows.Count; i++)
            {
                lbModele.Items.Add(controlleur.VModele.DT1[2].Rows[i]["CODEMODELE"]);
            }
        }

        private void Opticien_Load(object sender, EventArgs e)
        {
            controlleur.init();
            controlleur.VModele.seConnecter();
            controlleur.VModele.chargerMarque();
            controlleur.VModele.chargerCategorie();
            controlleur.VModele.chargerModele();
            categorie();
            marque();
            categorie();
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

        private void Button1_Click(object sender, EventArgs e)
        {
           if (controlleur.VModele.AjoutModele(tbModele.Text, cbCategorie.SelectedIndex, cbMarque.SelectedIndex, Convert.ToInt32(tbTaille.Text), Convert.ToInt32(tbPrix.Text), tbCouleur.Text))
           {
                MessageBox.Show("Modele entrer en base de données");
           }
           else
           {
                MessageBox.Show("Erreur");
           }
        }
    }
}
