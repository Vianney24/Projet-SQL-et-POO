using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SQL_et_POO
{
	public partial class Diplomes : Form
	{
		public Diplomes()
		{
			InitializeComponent();
		}

		private void Diplomes_Load(object sender, EventArgs e)
		{
            // TODO: cette ligne de code charge les données dans la table '_ProjetC_DataSet.Diplome'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.diplomeTableAdapter.Fill(this._ProjetC_DataSet.Diplome);

        }

        private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
