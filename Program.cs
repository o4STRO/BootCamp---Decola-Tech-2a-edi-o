namespace appCadastroDeSeries_desafioDecolaTech2aEdicao

{
    class Program
    {
        static void Main(string[] args){
          Console.WriteLine("Hello World");  
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Desafio Series");
            Console.WriteLine("Informe a opção desejada:");
            
            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir uma Nova Série");
            Console.WriteLine("3 - Atualizar uma Série");
            Console.WriteLine("4 - Excluir uma Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            
            Console.WriteLine();
        }
    }
}