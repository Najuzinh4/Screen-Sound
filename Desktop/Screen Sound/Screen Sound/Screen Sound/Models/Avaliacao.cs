﻿namespace Screen_Sound.Models;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        //
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}

