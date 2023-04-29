﻿using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Odontograma
{
    public class Sentido : Enums<char?>
    {
        public static readonly  Sentido Sul = new Sentido('S', "Sul");
        public static readonly  Sentido Norte = new Sentido('N', "Norte");
        public Sentido(char? key, string name) : base(key, name) { }
    }
}
