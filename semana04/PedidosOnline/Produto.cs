using System;

public class Produto
{
    private string _nome;
    private string _idProduto;
    private decimal _preco;
    private int _quantidade;

    public Produto(string nome, string idProduto, decimal preco, int quantidade)
    {
        _nome = nome;
        _idProduto = idProduto;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string GetNome() => _nome;
    public string GetIdProduto() => _idProduto;
    public decimal GetPreco() => _preco;
    public int GetQuantidade() => _quantidade;

    public decimal CalcularCustoTotal()
    {
        return _preco * _quantidade;
    }
}