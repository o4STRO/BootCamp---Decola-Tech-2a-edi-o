namespace appCadastroDeSeries_desafioDecolaTech2aEdicao

{
    class Program
    {
        static serieRepositorio repositorio = new serieRepositorio();
        static void Main(string[] args){
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        listarSeries();
                        break;
                    case "2":
                        inserirSerie();
                        break;
                    case "3":
                        //atualizarSerie();
                        break;
                    case "4":
                        //excluirSerie();
                        break;
                    case "5":
                        //visualizarSerie();
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = obterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void listarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Ops!! Não há Séries em nosso catálogo, volte mais tarde");
                return;
            }

            foreach(var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }

        private static void inserirSerie(){
            Console.WriteLine("Inserir uma Nova Série");

            foreach (int i in Enum.GetValues(typeof(genero)))
            {
                Console.WriteLine("{0} - {1}:", i, Enum.GetName(typeof(genero),i));
            }

            Console.WriteLine("Digite o número do Genêro: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Lançamento da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            serie novaSerie = new serie(id: repositorio.proximoId(), 
                                        genero: (genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorio.insere(novaSerie);
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

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}