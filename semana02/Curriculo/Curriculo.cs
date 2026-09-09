using System;
using System.Collections.Generic;

public class Curriculo
{
    public string _membro;
    public List<Emprego> _emprego = new List<Emprego>();

    public void Exibir()
    {
        Console.WriteLine($"Nome: {_membro}");
        Console.WriteLine("Emprego: ");

        foreach (Emprego empregos in _emprego)
        {
            empregos.Exibir();
        }
    }
}