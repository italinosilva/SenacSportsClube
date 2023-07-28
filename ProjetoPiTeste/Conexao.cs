
using System.Data.SqlClient;
using System.Globalization;

namespace ProjetoPiTeste
{
    public class Conexao
    {
        enum Dados
        {
            NomeSocio,
            EmailSocio,
            Telefone1Socio,
            Telefone2Socio,
            DataNascimentoSocio,
            NomeDependente,
            EmailDependente,
            DataNascimentoDependente,
            Telefone1Dependente,
            Telefone2Dependende,
            Parentesco,
            CpfDependente,
            SenhaDependente

        }
        enum DadosEventos
        {
            ConfirmacaoEvento1,

        }

        public SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Teste;Data Source=DESKTOP-8C9MJD7\\SQLEXPRESS");

        public void Conectar()
        {
            conn.Open();
        }
        public void Desconectar()
        {
            conn.Close();
        }

        public bool LoginMenu(string cpf, string senha)
        {
            string sql = $"SELECT cpf FROM Socio WHERE cpf = '{cpf}' AND Senha = '{senha}'";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();
            if (retorno.Read())
                return true;
            return false;
        }
        public bool RedefinirSenha(string cpf, string email, string novaSenha)
        {
            string sql = $"UPDATE Socio SET Senha = '{novaSenha}' WHERE cpf = '{cpf}' AND email = '{email}'";
            SqlCommand comando = new SqlCommand(sql, conn);
            int linhasAfetadas = comando.ExecuteNonQuery();

            if (linhasAfetadas > 0)
            {
                return true;
            }
            return false;

        }
        public bool RedefinirSenhaDependente(string cpf, string email, string novaSenha)
        {
            string sql = $"UPDATE Dependente SET Senha = '{novaSenha}' WHERE cpf = '{cpf}' AND email = '{email}'";
            SqlCommand comando = new SqlCommand(sql, conn);
            int linhasAfetadas = comando.ExecuteNonQuery();

            if (linhasAfetadas > 0)
            {
                return true;
            }
            return false;

        }
        public string CadastrarSocio(string nomeCompleto, string email, string senha, string cpf, string dataNascimento, string telefone1, string telefone2)
        {
            string insert = "INSERT INTO Socio (nomeCompleto,email,senha,cpf,dataNascimento,telefone1,telefone2,ehAtivo) VALUES (@nomeCompleto,@email,@senha,@cpf,@dataNascimento,@telefone1,@telefone2,1)";
            SqlCommand comando = new SqlCommand(insert, conn);

            comando.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@dataNascimento", DateTime.ParseExact(dataNascimento, "ddMMyyyy", CultureInfo.InvariantCulture));
            comando.Parameters.AddWithValue("@telefone1", telefone1);
            comando.Parameters.AddWithValue("@telefone2", telefone2);

            comando.ExecuteNonQuery();

            MessageBox.Show("Cadastro efetuado com sucesso");

            return insert;
        }

        public string CadastrarDependente(string nomeCompleto, string email, string cpf, string dataNascimento, string telefone1, string telefone2, string senha, int codigosociologado, string Parentesco)
        {
            string insert = "INSERT INTO Dependente (parentesco,codigoSocio, nomeCompleto, email, cpf, dataNascimento, telefone1, telefone2, senha) VALUES (@Parentesco,@codigoSocio, @nomeCompleto, @email, @cpf, @dataNascimento, @telefone1, @telefone2, @senha)";
            SqlCommand comando = new SqlCommand(insert, conn);

            comando.Parameters.AddWithValue("@Parentesco", Parentesco);
            comando.Parameters.AddWithValue("@codigoSocio", codigosociologado);
            comando.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@dataNascimento", DateTime.ParseExact(dataNascimento, "ddMMyyyy", CultureInfo.InvariantCulture));
            comando.Parameters.AddWithValue("@telefone1", telefone1);
            comando.Parameters.AddWithValue("@telefone2", telefone2);
            comando.Parameters.AddWithValue("@senha", senha);

            comando.ExecuteNonQuery();

            MessageBox.Show("Cadastro efetuado com sucesso");
            Application.Exit();
            return insert;
        }

        public List<SocioDependente> BuscarPerfilSocio(int codigoSocio)
        {
            string sql = $"select s.nomeCompleto as nomeSocio, s.email as emailSocio, s.telefone1, s.telefone2, s.dataNascimento as dataNascimentoSocio,  d.nomeCompleto as nomeDependente, d.email as emailDependente, d.dataNascimento as dataNascimentoDependente, d.telefone1 as telefone1Dependente, d.telefone2 as telefone2Dependente,  p.relacao as parentescoDependente,d.cpf as cpfDependente, d.senha as senhaDependente from socio s left join Dependente d on d.codigoSocio = s.codigo left join ParentescoDependente p on p.codigo = d.codigoParentescoDependente where codigoSocio = '{codigoSocio}'";

            SqlCommand comando = new SqlCommand(sql, conn);

            List<SocioDependente> dependentes = new List<SocioDependente>();

            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nomeCompletoDb = reader.GetString((short)Dados.NomeSocio);
                    var emailDb = reader.GetString((short)Dados.EmailSocio);
                    var telefoneSocio1Db = reader.GetString((short)Dados.Telefone1Socio);
                    var telefoneSocio2Db = reader.IsDBNull((short)Dados.Telefone2Socio) ? string.Empty : reader.GetString((short)Dados.Telefone2Socio);
                    DateTime dataNascimentoSocioDb = reader.GetDateTime((short)Dados.DataNascimentoSocio);
                    var nomeDepentendeDb = reader.GetString((short)Dados.NomeDependente);
                    var emailDependenteDb = reader.GetString((short)Dados.EmailDependente);
                    DateTime dataNascimentoDependenteDb = reader.GetDateTime((short)Dados.DataNascimentoDependente);
                    var telefoneDependente1Db = reader.GetString((short)Dados.Telefone1Dependente);
                    var telefoneDependente2Db = reader.IsDBNull((short)Dados.Telefone2Dependende) ? string.Empty : reader.GetString((short)Dados.Telefone2Dependende);
                    var ParentescoDb = reader.GetString((short)Dados.Parentesco);
                    var cpfdependenteDb = reader.GetString((short)Dados.CpfDependente);
                    var senhadependenteDb = reader.GetString((short)Dados.SenhaDependente);
                    
                    dependentes.Add(new SocioDependente()
                    {
                        NomeSocio = nomeCompletoDb,
                        EmailSocio = emailDb,
                        Telefone1Socio = telefoneSocio1Db,
                        Telefone2Socio = telefoneSocio2Db,
                        DataNascimentoSocio = dataNascimentoSocioDb,
                        NomeDependente = nomeDepentendeDb,
                        EmailDependente = emailDependenteDb,
                        DataNascimentoDependente = dataNascimentoDependenteDb,
                        Telefone1Dependente = telefoneDependente1Db,
                        Telefone2Dependente = telefoneDependente2Db,
                        Parentesco = ParentescoDb,
                        CpfDependente = cpfdependenteDb,
                        SenhaDependente = senhadependenteDb

                    });

                }
            }
            return dependentes;
        }
        public int BuscarCodigoSocio(Socio socio)
        {
            string sql = $"select codigo from Socio where cpf = '{socio.cpf}'";
            SqlCommand ordem = new SqlCommand(sql, conn);
            using (SqlDataReader reader = ordem.ExecuteReader())
            {
                if (reader.Read())
                {
                    socio.codigo = reader.GetInt32(0);
                }
            }

            return socio.codigo;
        }


        public bool LoginDependente(string cpf, string senha)
        {
            string sql = $"SELECT cpf FROM Dependente WHERE cpf = '{cpf}' AND Senha = '{senha}'";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();
            if (retorno.Read())
                return true;
            return false;
        }
        public string RemoverDependente(string cpf)
        {
            {
                string sql = $"DELETE FROM Dependente WHERE cpf = '{cpf}'";
                SqlCommand ordem = new SqlCommand(sql, conn);

                int rowsAfetadas = ordem.ExecuteNonQuery();
                if (rowsAfetadas > 0)
                {
                    MessageBox.Show("Dependente deletado com sucesso");

                    return cpf;
                }
                else
                {
                    return null;
                }
            }

        }
        public bool ConfirmarPresençaEvento1(string codigoSocio)
        {
            string sql = $"insert into PresencaEvento(codigoEvento, codigoSocio, confirmou) values('1, {codigoSocio}', 1)";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return true;

        }
        public bool CancelarPresençaEvento1(string codigoSocio, string cpf, int idade, string curso, string telefone)
        {
            string sql = $"update PresencaEvento set confirmou = 0 where codigoEvento = 1 and codigoSocio = {codigoSocio}";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return true;

        }
        public bool ConfirmarPresençaEvento2(string codigoSocio)
        {
            string sql = $"insert into PresencaEvento(codigoEvento, codigoSocio, confirmou) values('2, {codigoSocio}', 1)";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return true;

        }
        public bool CancelarPresençaEvento2(string codigoSocio, string cpf, int idade, string curso, string telefone)
        {
            string sql = $"update PresencaEvento set confirmou = 0 where codigoEvento = 2 and codigoSocio = {codigoSocio}";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return true;

        }
        public bool ConfirmarPresençaEvento1D(string codigoSocio)
        {
            string sql = $"insert into PresencaEvento(codigoEvento, codigoSocio, confirmou) values('1, {codigoSocio}', 1)";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return true;

        }
        public bool CancelarPresençaEvento1D(string codigoSocio, string cpf, int idade, string curso, string telefone)
        {
            string sql = $"update PresencaEvento set confirmou = 0 where codigoEvento = 1 and codigoSocio = {codigoSocio}";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return true;

        }
        public bool ConfirmarPresençaEvento2D(string codigoSocio)
        {
            string sql = $"insert into PresencaEvento(codigoEvento, codigoSocio, confirmou) values('2, {codigoSocio}', 1)";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return true;

        }
        public bool CancelarPresençaEvento2D(string codigoSocio, string cpf, int idade, string curso, string telefone)
        {
            string sql = $"update PresencaEvento set confirmou = 0 where codigoEvento = 2 and codigoSocio = {codigoSocio}";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return true;

        }

    }

}
 