﻿using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.STI;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.STI;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.STI
{
    public class PlataformaRepositorio : BaseRepositorio<Plataforma>, IPlataformaRepository
    {
        public PlataformaRepositorio(CorporativoContext context) : base(context) { }
    }
}