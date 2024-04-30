int qtd_livros;
do
{
    Console.WriteLine("Quantos livros deseja adicionar a estante: ");
    qtd_livros = int.Parse(Console.ReadLine());
    if (qtd_livros < 1)
    {
        Console.WriteLine("A estante precisa ter pelo menos 1 livro");
    }
} while (qtd_livros <= 0);
Livros [] estante = new Livros[qtd_livros];
int op;
Livros Criar_livro()
{
    Livros l = new Livros();
    Console.WriteLine("Digite o Titulo do Livro: ");
    l.DefinirTitulo(Console.ReadLine());
    Console.WriteLine("Digite o autor do Livro: ");
    l.DefinirAutor(Console.ReadLine());
    Console.WriteLine("Digite a data de lançamento do Livro: ");
    l.DefinirLancamento(DateOnly.Parse(Console.ReadLine()));
    Console.WriteLine("Digite a editora do Livro: ");
    l.DefinirEditora(Console.ReadLine());
    Console.WriteLine("Digite o numero da edição do Livro: ");
    l.DefinirEdicao(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite o numero de isbn do Livro: ");
    l.DefinirISBN(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de paginas do Livro: ");
    l.DefinirPaginas(int.Parse(Console.ReadLine()));
    return l;
}

for (int i = 0; i < estante.Length; i++)
{
    estante[i] = Criar_livro();
}

do
{
    Console.WriteLine("============= OPÇÕES =============");
    Console.WriteLine("[1] - Mostrar Livros\n[2] - Mostrar Detalhes Livro\n[3] - Mostrar Todos os Livros\n[4] - SAIR");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("=============== LIVROS ==================");
            for (int i = 0; i < estante.Length; i++)
            {
                Console.WriteLine($"[{i}]" + estante[i].titulo);
            }
            break;
        case 2:
            Console.WriteLine("Digite o indice do livro na estante: ");
            int indice_livro = int.Parse(Console.ReadLine());
            Console.WriteLine($"Livro {indice_livro}");
            Console.WriteLine("========================");
            estante[indice_livro].ImprimirLivro();
            Console.WriteLine("========================");
            break;
        case 3:
            for (int i = 0; i < estante.Length; i++)
            {
                Console.WriteLine($"Livro {i}");
                Console.WriteLine("========================");
                estante[i].ImprimirLivro();
                Console.WriteLine("========================");
            }
                break;
        case 4:
            break;

        default:
            Console.WriteLine("Numero invalido");
            break;
    }

    
} while (op != 4);





