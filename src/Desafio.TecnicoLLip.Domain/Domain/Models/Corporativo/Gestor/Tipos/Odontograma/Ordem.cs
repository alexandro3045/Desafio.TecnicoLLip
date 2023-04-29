using Desafio.TecnicoLLip.Domain.Models.Utility;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class Ordem : Enums<Byte?>
    {
        public static readonly  Ordem Pulpotomia = new Ordem(1, "Pulpotomia");
        public static readonly  Ordem Restauracao = new Ordem(2, "Restauração");
        public Ordem(Byte? key, string name) : base(key, name) { }
    }
}
