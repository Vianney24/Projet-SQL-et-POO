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
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void Nouveau_service_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
