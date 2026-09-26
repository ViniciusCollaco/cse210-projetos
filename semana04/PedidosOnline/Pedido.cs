using System;
using System.Collections.Generic;
using System.Text;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public decimal CalcularCustoTotal()
    {
        decimal totalProdutos = 0;
        foreach (var produto in _produtos)
        {
            totalProdutos += produto.CalcularCustoTotal();
        }

        decimal frete = _cliente.MoraNosEUA() ? 5.00m : 35.00m;
        return totalProdutos + frete;
    }

    public string ObterEtiquetaEmbalagem()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("--- ETIQUETA DE EMBALAGEM ---");
        foreach (var produto in _produtos)
        {
            sb.AppendLine($"Produto: {produto.GetNome()} | ID: {produto.GetIdProduto()}");
        }
        return sb.ToString();
    }

    public string ObterEtiquetaEnvio()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("--- ETIQUETA DE ENVIO ---");
        sb.AppendLine($"Cliente: {_cliente.GetNome()}");
        sb.AppendLine(_cliente.ObterEnderecoCompleto());
        return sb.ToString();
    }
}