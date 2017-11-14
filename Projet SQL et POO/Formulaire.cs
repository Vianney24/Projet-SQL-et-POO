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
    public partial class Formulaire : Form
    {
        public Formulaire()
        {
            InitializeComponent();
        }
        private void Formulaire_Load(object sender, EventArgs e)
        {
            
        }

        private int GetLastIdEmploye()
        {
            try
            {
                // 1: Connexion à la BDD
                MySqlConnection maConnexion;
                string chaineDeConnexion = Projet_SQL_et_POO.Properties.Settings.Default.chaineConnexionBDD;
                maConnexion = new MySqlConnection(chaineDeConnexion);
                maConnexion.Open();

                // 2: la commande
                string chaineSQL = @"SELECT MAX(IDEmploye) FROM `employe`";
                MessageBox.Show(chaineSQL);
                MySqlCommand maCommande = new MySqlCommand();
                maCommande.Connection = maConnexion;
                maCommande.CommandType = CommandType.Text;
                maCommande.CommandText = chaineSQL;

                // 3: Exécution de la commande DataReader
                MySqlDataReader monDataReader = maCommande.ExecuteReader();

                // 4: Parcours du DataReader
                monDataReader.Read();
                // Exploitation de la ligne lue
                int id = Convert.ToInt32(monDataReader["MAX(IDEmploye)"]);
                return id;

                
                // 5: fermetures
                monDataReader.Close();
                maConnexion.Close();
            }
            catch (Exception erreur)
            {
                return 0;
            }
        }

        #region Action des Bouttons

        public void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Connexion à la BDD
                MySqlConnection maConnexion;
                string chaineDeConnexion = Projet_SQL_et_POO.Properties.Settings.Default.chaineConnexionBDD;
                maConnexion = new MySqlConnection(chaineDeConnexion);
                maConnexion.Open();

                // Conversion du datetimepicker pour la requête
                Convert.ToString(dateTimePickerDDN.Text);
                string DateNaissance = dateTimePickerDDN.Value.ToString("yyyy-MM-dd");

                // incrémentation de l'ID de employe
                int LastID = GetLastIdEmploye();
                int NewID = LastID + 1;

                // Mise en place de la commande SQL
                string chaineSQL = @" INSERT INTO `employe`(`IDEmploye`, `NomEmploye`, `PrenomEmploye`, `DateNaissanceEmploye`, `AdresseL1Employe`, `AdresseL2Employe`, `CPEmploye`, `VilleEmploye`, `TelephoneEmploye`, `IDContrat`, `IDService`) 
                                      VALUES ("+ NewID +",'" + textBoxNom.Text + "', '" + textBoxPrenom.Text + "', '"+ DateNaissance + "', '" + textBoxAdresseL1.Text + "', '" + textBoxAdresseL2.Text + "', '" + textBoxCP.Text + "', '" + textBoxVille.Text + "', '" + textBoxTel.Text + "', 1, 1)";
                MessageBox.Show(chaineSQL);
                MySqlCommand maCommande = new MySqlCommand();
                maCommande.Connection = maConnexion;
                maCommande.CommandType = CommandType.Text;
                maCommande.CommandText = chaineSQL;

                // 3: Exécution de la commande DataReader
                MySqlDataReader monDataReader = maCommande.ExecuteReader();
                if (monDataReader == null)
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'employé ");
                }
                else
                {
                    MessageBox.Show("Employé ajouté");
                }

                // 4: fermetures
                monDataReader.Close();
                maConnexion.Close();
            }
            catch (Exception erreur)
            {
                
            }
            Close();
        }
        private void Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region TextBox
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxAdresseL1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxAdresseL2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxCP_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void dateTimePickerDDN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
