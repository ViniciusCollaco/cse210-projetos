using System;
using System.Collections.Generic;

public class Video
{
    private string _titulo;
    private string _autor;
    private int _duracaoSegundos;
    private List<Comentario> _comentarios;

    public Video(string titulo, string autor, int duracaoSegundos)
    {
        _titulo = titulo;
        _autor = autor;
        _duracaoSegundos = duracaoSegundos;
        _comentarios = new List<Comentario>();
    }

    public string GetTitulo()
    {
        return _titulo;
    }

    public string GetAutor()
    {
        return _autor;
    }

    public int GetDuracaoSegundos()
    {
        return _duracaoSegundos;
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterNumeroComentarios()
    {
        return _comentarios.Count;
    }

    public List<Comentario> GetComentarios()
    {
        return _comentarios;
    }
}