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
    public partial class RedefinirSenhaDependente : Form
    {
        public RedefinirSenhaDependente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                {
                    Conexao db = new Conexao();
                    db.Conectar();

                    SocioDependente dependentesenhabanco = new SocioDependente();
                    dependentesenhabanco.CpfDependente = textBox1.Text;
                    dependentesenhabanco.EmailDependente = textBox2.Text;
                    dependentesenhabanco.NovaSenhaDependente = textBox3.Text;
                    dependentesenhabanco.ConfirmarSenhaDependente = textBox4.Text;

                    if (dependentesenhabanco.NovaSenhaDependente != dependentesenhabanco.ConfirmarSenhaDependente)
                    {
                        MessageBox.Show("Senhas informadas não conferem, digite novamente!");
                    }
                    else
                    {
                        var retorno = db.RedefinirSenha(dependentesenhabanco.CpfDependente, dependentesenhabanco.EmailDependente, dependentesenhabanco.ConfirmarSenhaDependente);
                        if (retorno)
                        {
                            MessageBox.Show("Senha alterada!");
                        }

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
