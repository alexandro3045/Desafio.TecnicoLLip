﻿using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Protheus;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services.Protheus;
using Desafio.TecnicoLLip.Domain.Models.Protheus;
using Desafio.TecnicoLLip.Domain.Services.Base;

namespace Desafio.TecnicoLLip.Domain.Services.Protheus
{
    public class ContaContabilService : BaseService<ContaContabil>, IContaContabilService
    {
        public ContaContabilService(IContaContabilRepository repository) : base(repository) { }
    }
}