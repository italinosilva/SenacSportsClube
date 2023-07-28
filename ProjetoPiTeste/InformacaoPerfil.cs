using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPiTeste
{
    public partial class InformacaoPerfil : Form
    {
        private int codigoSocioLogado;

        public InformacaoPerfil(int codigoSocio)
        {
            InitializeComponent();
            codigoSocioLogado = codigoSocio;
            Load += new EventHandler(InformacaoPerfil_load);

            Conexao db = new Conexao();
            db.Conectar();

            var usuario = db.BuscarPerfilSocio(codigoSocio);
            dataGridView1.DataSource = usuario;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDependente cadastrodependente = new CadastroDependente(codigoSocioLogado);
            cadastrodependente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        public void InformacaoPerfil_load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
