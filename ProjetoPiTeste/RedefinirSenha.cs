using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPiTeste
{
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            Socio sociobanco = new Socio();
            sociobanco.cpf = textBox1.Text;
            sociobanco.email = textBox2.Text;
            sociobanco.novaSenha = textBox3.Text;
            sociobanco.confirmarSenha = textBox4.Text;

            if (sociobanco.novaSenha != sociobanco.confirmarSenha)
            {
                MessageBox.Show("Senhas informadas não conferem, digite novamente!");
            }
            else
            {
                var retorno = db.RedefinirSenha(sociobanco.cpf, sociobanco.email, sociobanco.novaSenha);
                if (retorno)
                {
                    MessageBox.Show("Senha alterada!");
                }

            }
        }
    }
}