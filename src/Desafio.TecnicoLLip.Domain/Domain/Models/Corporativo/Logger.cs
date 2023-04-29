using Desafio.TecnicoLLip.Domain.Models.Utility;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo
{
    public class Logger : EntityTracking
    {
        public Logger() => EventDate = Inserted;
        public int Id { get; set; }
        public string Mesage { get; set; }
        public string Type { get; set; }
        public string Json { get; set; }
        public string Source { get; set; }
        public DateTime EventDate { get; set; }
    }
}
