using System;
using System.Collections.Generic;

public class Video
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int DuracaoSegundos { get; set; }
    public List<Comentario> Comentarios { get; set; }

    public Video(string titulo, string autor, int duracaoSegundos)
    {
        Titulo = titulo;
        Autor = autor;
        DuracaoSegundos = duracaoSegundos;
        Comentarios = new List<Comentario>();
    }

    public int ObterNumeroComentarios()
    {
        return Comentarios.Count;
    }

    public void AdicionarComentario(Comentario comentario)
    {
        Comentarios.Add(comentario);
    }
}