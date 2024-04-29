public class Livros
    {
    public string titulo;
    public string autor;
    public DateOnly lancamento;
    public string editora;
    public int edicao;
    public string isbn;
    public int qtd_paginas;

    public Livros()
    {
        
    }
    public void DefinirTitulo(string t)
    {
        this.titulo = t;    
    }
    public void DefinirAutor(string a)
    {
        this.autor = a;
    }
    public void DefinirLancamento(DateOnly l)
    {
        this.lancamento = l;
    }
    public void DefinirEditora(string e)
    {
        this.editora = e;
    }
    public void DefinirEdicao(int e)
    {
        this.edicao = e;
    }
    public void DefinirISBN(string i)
    {
        this.isbn = i;
    }
    public void DefinirPaginas(int p)
    {
        this.qtd_paginas = p;
    }
    public void ImprimirLivro()
    {
        Console.WriteLine("Titulo: " + this.titulo);
        Console.WriteLine("Autor: " + this.autor);
        Console.WriteLine("Lançamento: " + this.lancamento);
        Console.WriteLine("Editora: " + this.editora);
        Console.WriteLine("Edição: " + this.edicao);
        Console.WriteLine("ISBN: " + this.isbn);
        Console.WriteLine("Quantidade de Paginas: " + this.qtd_paginas);
    }
}

