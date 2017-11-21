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
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }
        private void Modifier_Load(object sender, EventArgs e)
        {

        }

        #region Action des Bouttons

        public void btnValider_Click(object sender, EventArgs e)
        {
            /*try
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
                                      VALUES (" + NewID + ",'" + textBoxNom.Text + "', '" + textBoxPrenom.Text + "', '" + DateNaissance + "', '" + textBoxAdresseL1.Text + "', '" + textBoxAdresseL2.Text + "', '" + textBoxCP.Text + "', '" + textBoxVille.Text + "', '" + textBoxTel.Text + "', 1, 1)";
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

            }*/
            Close();
        }
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


    }
}
