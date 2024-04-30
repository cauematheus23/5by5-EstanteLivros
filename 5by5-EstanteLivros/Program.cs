﻿using EstanteLivro;

//Livro l = new("Senhor dos Anéis", "J. R. R. Tolkien", DateOnly.Parse("03/11/2001"), "Saraiva", 1, "1234567", 500);

Livro[] estante = new Livro[10];
int indice = 0, op = 0;

int Menu()
{
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Imprimir Estante");
    Console.WriteLine("3 - Imprimir Livro Especifico");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("Escolha sua opção: ");
    return int.Parse(Console.ReadLine());
}


Livro CadastrarLivro()
{
    string titulo, autor, editora, isbn;
    int edicao, paginas;
    DateOnly lancamento;

    Console.WriteLine("Informe o titulo do livro: ");
    titulo = Console.ReadLine();
    Console.WriteLine("Informe o autor do livro: ");
    autor = Console.ReadLine();
    Console.WriteLine("Informe a data de lançamento: ");
    lancamento = DateOnly.Parse(Console.ReadLine());
    Console.WriteLine("Informe a editora: ");
    editora = Console.ReadLine();
    Console.WriteLine("Informe a edição: ");
    edicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o ISBN: ");
    isbn = Console.ReadLine();
    Console.WriteLine("Informe a quantidade de páginas: ");
    paginas = int.Parse(Console.ReadLine());

    return new(titulo, autor, lancamento, editora, edicao, isbn, paginas);

}
void AdicionarLivroNaEstante()
{
    do
    {
        Livro l = CadastrarLivro();
        estante[indice] = l;
        Console.WriteLine($"{indice + 1}/10 livros na estante");
        indice++;
        Console.WriteLine("Deseja cadastrar um novo livro?\n[1]SIM\n[2]NÃO");
        op = int.Parse(Console.ReadLine());
    } while (op != 0 && indice < 10);
}
void ImprimirEstante()
{
    for (int i = 0; i < indice; i++)
        estante[i].ImprimirLivro();
}
void MostrarTitulos()
{
    for (int i = 0; i < indice; i++)
    {
        Console.Write($"{i + 1}° Livro -> ");
        estante[i].ImprimiLivros();

    }
}
void BuscarLivro(int i)
{
    while (i >= indice)
    {
        Console.WriteLine("O indice não existe na estante, digite um novo: ");
        i = int.Parse(Console.ReadLine());
    }
    estante[i].ImprimirLivro();
}

do
{
    switch (Menu())
    {
        case 1:
            AdicionarLivroNaEstante();
            break;
        case 2:
            ImprimirEstante();
            break;
        case 3:
            Console.WriteLine("==================== TITULOS NA ESTANTE ====================");
            MostrarTitulos();
            Console.Write("Informe o indice do livro: ");
            BuscarLivro(int.Parse(Console.ReadLine()) - 1);
            break;
        case 4:
            Console.WriteLine("Hasta la vista, baby!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
} while (true);





Console.ReadLine();