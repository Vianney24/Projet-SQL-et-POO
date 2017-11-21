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

namespace Projet_SQL_et_POO
{
    public partial class Application_Services : Form
    {
        public Application_Services()
        {
            InitializeComponent();
        }

        private void Application_Services_Load(object sender, EventArgs e)
        {
            try
            {
                // 1: Connexion à la BDD
                MySqlConnection maConnexion;
                string chaineDeConnexion = Projet_SQL_et_POO.Properties.Settings.Default.chaineConnexionBDD;
                maConnexion = new MySqlConnection(chaineDeConnexion);
                maConnexion.Open();

                // 2: la commande
                string chaineSQL = @"SELECT * FROM `employe` ORDER BY IDEmploye, NomEmploye";
                MySqlCommand maCommande = new MySqlCommand();
                maCommande.Connection = maConnexion;
                maCommande.CommandType = CommandType.Text;
                maCommande.CommandText = chaineSQL;

                // 3: Exécution de la commande DataReader
                MySqlDataReader monDataReader = maCommande.ExecuteReader();

                // 4: Parcours du DataReader
                while (monDataReader.Read())
                {
                    // Exploitation de la ligne lue
                    int IDEmploye = Convert.ToInt32(monDataReader["IDEmploye"]);
                    string NomEmploye = monDataReader["NomEmploye"].ToString();
                    string PrenomEmploye = monDataReader["PrenomEmploye"].ToString();
                    string DateNaissanceEmploye = monDataReader["DateNaissanceEmploye"].ToString();
                    string AdresseL1Employe = monDataReader["AdresseL1Employe"].ToString();
                    string AdresseL2Employe = monDataReader["AdresseL2Employe"].ToString();
                    string CPEmploye = monDataReader["CPEmploye"].ToString();
                    string VilleEmploye = monDataReader["VilleEmploye"].ToString();
                    string TelephoneEmploye = monDataReader["TelephoneEmploye"].ToString();

                    string[] tableLigneData = new string[] { Convert.ToString(IDEmploye), NomEmploye, PrenomEmploye, DateNaissanceEmploye, AdresseL1Employe, AdresseL2Employe, CPEmploye, VilleEmploye, TelephoneEmploye };
                    dataGridView.Rows.Add(tableLigneData);

                }

                // 5: fermetures
                monDataReader.Close();
                maConnexion.Close();
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }

        private void Ajouter_Personne_Click(object sender, EventArgs e)
        {
            Formulaire Form = new Formulaire();
            Form.Show();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Modifier Mod = new Modifier();
            Mod.Show();
        }

		private void Diplomes_Click_1(object sender, EventArgs e)
		{
			Diplomes Dip = new Diplomes();
			Dip.Show();
		}

		private void Services_Click(object sender, EventArgs e)
		{
			Services Ser = new Services();
			Ser.Show();
		}

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 9)
			{
				Modifier Mod = new Modifier();
				Mod.Show();
			}
		}
	}
}
