using System;

public class Comentario
{
    public string NomePessoa { get; set; }
    public string Texto { get; set; }
    
    public Comentario(string nomePessoa, string texto)
    {
        NomePessoa = nomePessoa;
        Texto = texto;
    }
}