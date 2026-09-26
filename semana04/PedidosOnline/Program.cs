using System;

class Program
{
    static void Main(string[] args)
    {
        Endereco endereco1 = new Endereco("123 Main Street", "New York", "NY", "USA");
        Cliente cliente1 = new Cliente("John Smith", endereco1);
        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(new Produto("Teclado Mecânico", "P101", 49.99m, 1));
        pedido1.AdicionarProduto(new Produto("Mouse Gamer", "P102", 25.00m, 2));

        Endereco endereco2 = new Endereco("Av. Paulista, 1000", "São Paulo", "SP", "Brasil");
        Cliente cliente2 = new Cliente("Maria Oliveira", endereco2);
        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(new Produto("Monitor 27 Polegadas", "P201", 200.00m, 1));
        pedido2.AdicionarProduto(new Produto("Cabo HDMI 2m", "P202", 10.00m, 3));
        pedido2.AdicionarProduto(new Produto("Suporte para Monitor", "P203", 30.00m, 1));

        ExibirDetalhesPedido("PEDIDO #1 (Nacional - EUA)", pedido1);
        Console.WriteLine("\n==================================================\n");
        
        ExibirDetalhesPedido("PEDIDO #2 (Internacional - Brasil)", pedido2);
    }

    static void ExibirDetalhesPedido(string titulo, Pedido pedido)
    {
        Console.WriteLine($"=================== {titulo} ===================");
        Console.WriteLine(pedido.ObterEtiquetaEmbalagem());
        Console.WriteLine(pedido.ObterEtiquetaEnvio());
        Console.WriteLine($"\nPreço Total (com frete): ${pedido.CalcularCustoTotal():F2}");
    }
}