﻿using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.SGE
{
    public class ModalidadeCurso : TipoModel<string>
    {
        public Int16 ColigadaId { get; set; }
        public Coligada Coligada { get; set; }
    }
}