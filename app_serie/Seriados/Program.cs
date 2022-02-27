using System;

namespace Seriados
{
    class Program
    {
        static CatalogoEstoque listagem = new CatalogoEstoque();
        static void Main(string[] args)
        {

           string selecao = LerTeclado();

			while (selecao.ToUpper() != "X")
			{
				switch (selecao)
				{
					case "1":
						ListarCatalogo();
						break;
					case "2":
						CadastrarCatalogo();
						break;
					case "3":
						AtualizarCatalogo();
						break;
					case "4":
						ExcluirItem();
						break;
					case "5":
						DetalharItem();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				selecao = LerTeclado();
			}

			Console.WriteLine("O sistema será encerrado. Pressione qualquer tecla.");
			Console.ReadLine();
        }

        private static void ListarCatalogo()
        {
            System.Console.WriteLine("Catalogo de Séries Cadastradas no Sistema:");

            var lista = listagem.Catalogo();

            if (lista.Count == 0)
            {
                System.Console.WriteLine("No momento não há série cadastrada em estoque. Favor iniciar cadastro.");
                return;
            }

            foreach (var seriado in lista)
            {
                System.Console.WriteLine("Item {0}: - {1}", seriado.devolveId(), seriado.devolveTitulo());
            }
        }

        private static void CadastrarCatalogo()
		{
			foreach (int i in Enum.GetValues(typeof(Decada)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Decada), i));
			}
			Console.Write("Indique a década de lançamento conforme listagem acima: ");
			int inseredecada = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string inseretitulo = Console.ReadLine();

			Console.Write("Digite o Ator(Atriz) Principal da Série: ");
			string insereator = (Console.ReadLine());

            Console.Write("Insira a quantidade de temporadas do seriado: ");
            int inseretemporadas = int.Parse(Console.ReadLine());

			Console.Write("Digite a Resenha da Série: ");
			string insereresenha = Console.ReadLine();

			Seriado novoitem = new Seriado(id: listagem.ProximoItem(),
										decada: (Decada)inseredecada,
										titulo: inseretitulo,
										ator: insereator,
										temporadas: inseretemporadas,
                                        resenha: insereresenha);

			listagem.Inserir(novoitem);
		}


        private static void AtualizarCatalogo()
		{
			Console.Write("Digite o número de item da série: ");
			int indicecatalogo = int.Parse(Console.ReadLine());


			foreach (int i in Enum.GetValues(typeof(Decada)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Decada), i));
			}
			Console.Write("Indique a década de lançamento conforme listagem acima: ");
			int inseredecada = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string inseretitulo = Console.ReadLine();

			Console.Write("Digite o Ator(Atriz) Principal da Série: ");
			string insereator = (Console.ReadLine());

            Console.Write("Insira a quantidade de temporadas do seriado: ");
            int inseretemporadas = int.Parse(Console.ReadLine());

			Console.Write("Digite a Resenha da Série: ");
			string insereresenha = Console.ReadLine();


			Seriado atualizaitem = new Seriado(id: indicecatalogo,
										decada: (Decada)inseredecada,
										titulo: inseretitulo,
										ator: insereator,
										temporadas: inseretemporadas,
                                        resenha: insereresenha);

			listagem.Atualizar(indicecatalogo, atualizaitem);
		}

        private static void ExcluirItem()
		{
			Console.Write("Digite o código de item da série: ");
			int excluiritem = int.Parse(Console.ReadLine());

			listagem.Excluir(excluiritem);
		}

        private static void DetalharItem()
		{
			Console.Write("Digite o código de item da série: ");
			int detalhaitem = int.Parse(Console.ReadLine());

			var serie = listagem.RetornaItem(detalhaitem);

			Console.WriteLine(serie);
		}



        private static string LerTeclado()
		{
			Console.WriteLine();
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar Catálogo");
			Console.WriteLine("2- Inserir novo item no catálogo");
			Console.WriteLine("3- Atualizar item do catálogo");
			Console.WriteLine("4- Excluir item do catálogo");
			Console.WriteLine("5- Visualizar detalhes do seriado");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair do Sistema");
			Console.WriteLine();

			string selecao = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return selecao;
		}
    }
}     