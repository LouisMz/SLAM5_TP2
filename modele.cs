using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Opticien
{
    public class modele
    {
        #region propriétés
        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool chargement = false;
        private List<DataTable> dT1 = new List<DataTable>();
        #endregion
        public modele()
        {
            for (int i = 0; i < 3; i++)
            {
                dT1.Add(new DataTable());
            }
        }

        #region accesseur
        public bool Connopen { get => connopen; set => connopen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }
        public List<DataTable> DT1 { get => dT1; set => dT1 = value; }
        public MySqlConnection MyConnection { get => myConnection; set => myConnection = value; }
        #endregion

        #region constructeur

        #endregion

        #region methode
        public void seConnecter()
        {
            string myConnectionString = "Database=bd_opticien; Data Source=localhost; User Id=root; Password= ; ";
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

        public void chargerMarque()
        {
            charger("SELECT NOMMARQUE FROM MARQUE", controlleur.VModele.DT1[0]);
        }

        public void chargerCategorie()
        {
            charger("SELECT NOMLIBELLE FROM CATEGORIE", controlleur.VModele.DT1[1]);
        }

        public void chargerModele()
        {
            charger("SELECT * FROM modele", controlleur.VModele.DT1[2]);
        }

        public bool AjoutModele(string tbModele, int cbCategorie, int cbMarque, int tbTaille, decimal tbPrix, string tbCouleur )
        {
            try
            {
                bool ok = false;
                // préparation de la requête avec des paramètres
                string requete = "insert into modele values (@CODEMODELE, @IDMARQUE, @IDCATEGORIE, @TAILLE, @PRIX, @DESCRIPTIONCOULEUR)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de
                command.Parameters.AddWithValue("CODEMODELE", tbModele);
                command.Parameters.AddWithValue("IDCATEGORIE", cbCategorie);
                command.Parameters.AddWithValue("IDMARQUE", cbMarque);
                command.Parameters.AddWithValue("TAILLE", tbTaille);
                command.Parameters.AddWithValue("PRIX", tbPrix);
                command.Parameters.AddWithValue("DESCRIPTIONCOULEUR", tbCouleur);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
    }
    #endregion
}


