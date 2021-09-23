using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace tp1
{
    class modele
    {
        #region propriétés
        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool chargement = false;
        private DataTable dT1 = new DataTable();
        #endregion

        #region accesseur
        public bool Connopen { get => connopen; set => connopen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }
        public DataTable DT1 { get => dT1; set => dT1 = value; }
        #endregion

        #region constructeur
        #endregion

        #region methode
        public void seConnecter()
        {
            string myConnectionString = "Database=opticien_tl; Data Source=localhost; User Id=root; Password= ; ";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
            }
        }

        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void charger(string requete, DataTable DT)
        {
            MySqlCommand command = myConnection.CreateCommand();
            MySqlDataReader reader;
            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT.Load(reader);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }
        }
        #endregion
    }
}

