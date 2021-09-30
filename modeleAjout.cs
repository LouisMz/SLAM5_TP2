using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opticien
{
    public class modeleAjout
    {
       

        public void charger(string requete, DataTable DT)
        {
            MySqlCommand command = controlleur.VModele.MyConnection.CreateCommand();
            MySqlDataReader reader;
            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT.Load(reader);
                controlleur.VModele.Chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controlleur.VModele.Chargement = false;
            }
        }

        public void charger_donnees(string table)
        {
            if (table == "bien") charger("select * from bien;", controlleur.VModele.DT1);
        }
    }
}
