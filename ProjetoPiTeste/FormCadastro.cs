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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            Socio cadastroSocio = new Socio();
            cadastroSocio.nomeCompleto = textBox1.Text;
            cadastroSocio.email = textBox2.Text;
            cadastroSocio.senha = textBox3.Text;
            cadastroSocio.cpf = textBox4.Text;
            cadastroSocio.dataNascimento = textBox5.Text;
            cadastroSocio.telefone1 = textBox6.Text;
            cadastroSocio.telefone2 = textBox7.Text;
            cadastroSocio.confirmarSenha = textBox8.Text;

            if (cadastroSocio.senha != cadastroSocio.confirmarSenha)
            {
                MessageBox.Show("Senhas não conferem, tente novamente!");

            }
            else
            {
                db.CadastrarSocio(cadastroSocio.nomeCompleto, cadastroSocio.email, cadastroSocio.senha, cadastroSocio.cpf, cadastroSocio.dataNascimento, cadastroSocio.telefone1, cadastroSocio.telefone2);

            }


        }
    }
}
