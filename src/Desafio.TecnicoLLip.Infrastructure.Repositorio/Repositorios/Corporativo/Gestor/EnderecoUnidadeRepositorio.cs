﻿using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class EnderecoUnidadeRepositorio : BaseRepositorio<EnderecoUnidade>, IEnderecoUnidadeRepository
    {
        public EnderecoUnidadeRepositorio(CorporativoContext context) : base(context) { }
    }
}