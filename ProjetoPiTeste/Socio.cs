using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProjetoPiTeste
{
    public class Socio
    {
        public string nomeCompleto { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
        
        public int codigo { get; set; }
      
        public string  dataNascimento { get; set; }

        public bool ehAtivo { get; set; }

        public string novaSenha { get; set; }   

       public string confirmarSenha { get; set; }   

        public string telefone1 { get; set; }   
        public string telefone2 { get; set; }

     
    }
}
