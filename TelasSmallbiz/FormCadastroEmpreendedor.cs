using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSmallbiz
{
    public partial class FormCadastroEmpreendedor : Form
    {
        public FormCadastroEmpreendedor()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {         
            FormPaginaInicialEmpreendedor fle = new FormPaginaInicialEmpreendedor();
            fle.Show();
            this.Close();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormLoginEmpreendedor fle = new FormLoginEmpreendedor();
            fle.Show();
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
