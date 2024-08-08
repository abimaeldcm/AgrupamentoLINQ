using System;
using System.Collections.Generic;
using System.Linq;



public class Program
{
    public static void Main()
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Televisão", Categoria = "Eletrônicos", Preco = 1900 },
            new Produto { Nome = "Sofá", Categoria = "Móveis", Preco = 1200 },
            new Produto { Nome = "Mesa de Jantar", Categoria = "Móveis", Preco = 900 },
            new Produto { Nome = "Notebook", Categoria = "Eletrônicos", Preco = 2500 },
            new Produto { Nome = "Mangueira", Categoria = "Jardinagem", Preco = 35}
        };

        var agrupamentPorCategoria = produtos.GroupBy(p => p.Categoria);

        foreach (var grupo in agrupamentPorCategoria)
        {
            Console.WriteLine($"Categoria: {grupo.Key}");
            foreach (var produto in grupo)
            {
                Console.WriteLine($"-{produto.Nome}: {produto.Preco:C}");
            }
        }

    }

    public class Produto
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
    }

}