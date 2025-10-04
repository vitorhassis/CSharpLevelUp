namespace ConsoleApp1.Modules.FormasGeometricas
{
    public class Usuario2
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine("Digite um nome válido e tente novamente!");
                }
            }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _senha = value;
                }
                else
                {
                    Console.WriteLine("Digite um email válido e tente novamente!");
                }
            }
        }

        public Usuario2 (string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        
    }
}

