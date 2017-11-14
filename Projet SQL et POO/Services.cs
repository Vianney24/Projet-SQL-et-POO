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
	public partial class Services : Form
	{
		public Services()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Services_Load(object sender, EventArgs e)
		{
			// TODO: cette ligne de code charge les données dans la table '_ProjetC_DataSet.Service'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.serviceTableAdapter.Fill(this._ProjetC_DataSet.Service);

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
