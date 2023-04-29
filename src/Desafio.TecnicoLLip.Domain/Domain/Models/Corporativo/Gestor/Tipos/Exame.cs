﻿
using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Exame : Enums<char?>
    {
        public static readonly  Exame Sim = new Exame('S', "Sim");
        public static readonly  Exame Nao = new Exame('N', "Não");
        public Exame(char? key, string name) : base(key, name) { }
    }
}
