//diz que a classe Usuario pertence ao pacote ConsoleApp1.Modules.CadastroUsuarios
namespace ConsoleApp1.Modules.CadastroUsuarios
{
    public class Usuario
    {
        private string _nome; 
        public string Nome 
        {
            get { return _nome; }

            set
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("Digite um nome válido!");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public string Email { get; set; }

        //utilizando o get set para controlar como os atributos das classes serao lidos e modificados de forma segura e organizada
        //temos que sempre criar um campo privado do atributo da vez, quando for personalizar o get ou set (olha no atributo de Nome)
        //"Olhando o molde (X) eu vou atribuir ao campo real (_x) apenas se passar por tal condição

        private int _idade;
        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Digite uma idade válida!");
                }
                else
                {
                    _idade = value;
                }
            }
        }

        //construtor
        public Usuario (string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }


    }
}

