using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPiTeste
{
    public partial class CadastroDependente : Form
    {
        private int codigoSocioLogado;
        public CadastroDependente()
        {
            InitializeComponent();
        }
        public CadastroDependente(int codigosocio)
        {
            codigoSocioLogado = codigosocio;
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexao db = new Conexao();
            db.Conectar();

            SocioDependente cadastroDependente = new SocioDependente();
            cadastroDependente.NomeDependente = textBox1.Text;
            cadastroDependente.EmailDependente = textBox3.Text;
            cadastroDependente.CpfDependente = textBox4.Text;
            cadastroDependente.DataNascimentoDependente = DateTime.ParseExact(textBox5.Text, "ddMMyyyy", CultureInfo.InvariantCulture);
            cadastroDependente.Telefone1Dependente = textBox6.Text;
            cadastroDependente.Telefone2Dependente = textBox7.Text;
            cadastroDependente.SenhaDependente = textBox9.Text;
            int codigoParentesco = int.Parse(textBox10.Text);


            db.CadastrarDependente(cadastroDependente.NomeDependente, cadastroDependente.EmailDependente, cadastroDependente.CpfDependente,
                    cadastroDependente.DataNascimentoDependente.ToString("ddMMyyyy"), cadastroDependente.Telefone1Dependente,
                    cadastroDependente.Telefone2Dependente, cadastroDependente.SenhaDependente, codigoSocioLogado, codigoParentesco);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            SocioDependente deletardependente = new SocioDependente();
            deletardependente.CpfDependente = textBox8.Text;
            db.RemoverDependente(deletardependente.CpfDependente);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
