using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Engenheiro de Softare";
        emprego1._empresa = "Microsoft";
        emprego1._anoInicio = 2019;
        emprego1._anotermino = 2022;

        //Console.WriteLine(emprego1._empresa);

        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Gerente";
        emprego2._empresa = "Apple";
        emprego2._anoInicio = 2022;
        emprego2._anotermino = 2023;

        //Console.WriteLine(emprego2._empresa);

        //emprego1.Exibir();
        //emprego2.Exibir();

        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._membro = "Vinicius Collaço";

        meuCurriculo._emprego.Add(emprego1);
        meuCurriculo._emprego.Add(emprego2);

        //Console.WriteLine(meuCurriculo._emprego[0]._cargo);

        meuCurriculo.Exibir();
    }
}