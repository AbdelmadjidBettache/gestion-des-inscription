using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class ListeProgrammes : Form
    {
        private List<Programme> programmes;
        public ListeProgrammes(List<Programme> programmes)
        {
            InitializeComponent();
            this.programmes = programmes;
            RemplirDataGridView();
        }
        private void RemplirDataGridView()
        {
            // Effacer toutes les lignes existantes dans le DataGridView
            dataGridViewProgrammes.Rows.Clear();
            foreach (Programme programme in programmes)
            {
                dataGridViewProgrammes.Rows.Add(programme.CodeProgramme, programme.Domaine, programme.Nom, programme.NbrHeures);
            }
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
