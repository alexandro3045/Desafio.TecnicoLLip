﻿using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Validations.Corporativo;

namespace Desafio.TecnicoLLip.Domain.Services.Corporativo.Gestor
{
    public class UnidadeNegocioService : BaseService<UnidadeNegocio>, IUnidadeNegocioService
    {
        public UnidadeNegocioService(IUnidadeNegocioRepository repository, UnidadeNegocioValidator validator) : base(repository, validator) { }
    }
}
