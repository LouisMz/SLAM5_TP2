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
            if (controlleur.VModele.Connopen)
            {
                MessageBox.Show("Vous êtes bien connecté");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
