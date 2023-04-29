using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class ContemDisciplinaView : Enums<char?>
    {
        [DataMember]
        public static readonly ContemDisciplinaView Sim = new ContemDisciplinaView('S', "Sim");
        [DataMember]
        public static readonly ContemDisciplinaView nao = new ContemDisciplinaView('N', "Não");
        public ContemDisciplinaView(char? key, string name) : base(key, name) { }
    }
}
