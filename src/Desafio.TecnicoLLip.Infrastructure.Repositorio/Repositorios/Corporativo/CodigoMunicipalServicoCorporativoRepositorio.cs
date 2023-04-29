using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo
{
    public class CodigoMunicipalServicoCorporativoRepositorio : BaseRepositorio<CodigoMunicipalServicoCorporativo>, ICodigoMunicipalServicoCorporativoRepository
    {
        public CodigoMunicipalServicoCorporativoRepositorio(CorporativoContext context) : base(context) { }

        private void AddcParameters(CodigoMunicipalServicoCorporativo item, string Method)
        {
            AddParameters(item, Method);
            AddParameters("in_sq_classifservOfic", item.CodigoServicoOficial);
            AddParameters("sd_dt_ini_classiftabservgoverno", item.Inicio);
            AddParameters("cod_serv_mun", item.CodigoMunicipalId);
            AddParameters("cod_municipio", item.CodigoMunicipio);
            AddParameters("sd_dt_fim_classiftabservgoverno", item.Fim);
        }

        public override Task<CodigoMunicipalServicoCorporativo> Adicionar(CodigoMunicipalServicoCorporativo item)
        {
            ClearParameters();
            AddParameters(item, nameof(Adicionar));
            AddParameters("in_sq_classifservOfic", item.CodigoServicoOficial);
            AddParameters("sd_dt_ini_classiftabservgoverno", item.Inicio);
            AddParameters("cod_serv_mun", item.CodigoMunicipalId);
            AddParameters("cod_municipio", item.CodigoMunicipio);
            AddParameters("in_sq_municipio", item.SeqMunicipio);
            AddStroredProcedure("[dbo].[spClassifTabServicoGovernoIncluir]");

            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }

            return Task.FromResult(item);
        }

        public override Task<CodigoMunicipalServicoCorporativo> Atualizar(CodigoMunicipalServicoCorporativo item)
        {
            ClearParameters();
            AddcParameters(item, nameof(Atualizar));
            AddStroredProcedure("[dbo].[spClassifTabServicoGovernoAlterar]");
            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }

            return Task.FromResult(item);
        }

        public override Task<CodigoMunicipalServicoCorporativo> Remover(CodigoMunicipalServicoCorporativo item)
        {
            AddcParameters(item, nameof(Remover));
            AddStroredProcedure("[dbo].[spClassifTabServicoGovernoExcluir]");
            var ret = ExecuteStoredProcedure(nameof(Remover));
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }
            return Task.FromResult(item);
        }
    }
}