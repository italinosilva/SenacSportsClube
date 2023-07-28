using System.Windows.Forms;
namespace ProjetoPiTeste;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        FormCadastro formCadastro = new FormCadastro();
        formCadastro.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Conexao db = new Conexao();

        db.Conectar();

        Socio socio = new Socio();
        socio.cpf = textBox1.Text;
        socio.senha = textBox2.Text;

        bool checkSocio = checkBox1.Checked;
        bool checkDependente = checkBox2.Checked;

        if (checkSocio && checkDependente)
        {
            MessageBox.Show("Selecione apenas uma opção: 'Sou sócio' ou 'Sou dependente'.");
        }
        else if (checkSocio)
        {
            var retornoSocio = db.LoginMenu(socio.cpf, socio.senha);

            if (!retornoSocio)
            {
                MessageBox.Show("CPF inválido ou senha incorreta, tente novamente!");
            }
            else
            {
                socio.codigo = db.BuscarCodigoSocio(socio);
                int codigoSocioLogado = socio.codigo;

                MessageBox.Show("Bem-vindo ao SenaC SporTs CluB");

                InformacaoPerfil informacaoPerfil = new InformacaoPerfil(codigoSocioLogado);
                informacaoPerfil.Show();
            }
        }
        else if (checkDependente)
        {
            SocioDependente dependente = new SocioDependente();
            dependente.CpfDependente = textBox1.Text;
            dependente.SenhaDependente = textBox2.Text;

            var retornoDependente = db.LoginDependente(dependente.CpfDependente, dependente.SenhaDependente);

            if (!retornoDependente)
            {
                MessageBox.Show("CPF inválido ou senha incorreta para dependente, tente novamente!");
            }
            else
            {
                MessageBox.Show("Bem-vindo ao SenaC SporTs CluB!");

                Evento evento = new Evento();
                evento.Show();
            }
        }
        else
        {
            MessageBox.Show("Selecione uma opção: 'Sou Sócio' ou 'Sou dependente'.");
        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        RedefinirSenha redefinirsenha = new RedefinirSenha();
        redefinirsenha.Show();
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }
}
