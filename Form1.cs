using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApInfo_Eduardo
{
    public partial class Menu : Form
    {
        Cadastro cadastro = new Cadastro();
        Consulta consulta = new Consulta();
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            consulta.ShowDialog();
        }
    }
}
