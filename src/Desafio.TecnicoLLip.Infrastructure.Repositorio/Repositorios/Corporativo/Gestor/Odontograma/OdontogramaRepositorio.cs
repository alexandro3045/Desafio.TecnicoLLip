using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor.Odontograma
{
    public class OdontogramaRepositorio : BaseRepositorio<Domain.Models.Corporativo.Gestor.Odontograma.Odontograma>, IOdontogramaRepository
    {
        private const string LOGONINTEGRACAO = "INTEGRACAODYNAMICS";
        public OdontogramaRepositorio(CorporativoContext context) : base(context) { }

        public override Task<Domain.Models.Corporativo.Gestor.Odontograma.Odontograma> Remover(Domain.Models.Corporativo.Gestor.Odontograma.Odontograma item)
        {
            RemoverHistorico(item);

            if (item.ValidationResult.Errors.Count > 0) return Task.FromResult(item);

            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("in_sq_pessoa", item.PessoaId.GetDBNullOrValue());
            AddParameters("ch_nr_atendOdont", item.AtendimentoId.GetDBNullOrValue());
            AddParameters("vc_ds_logon_sistema", LOGONINTEGRACAO);
            AddStroredProcedure("[dbo].[spOdontogramaExcluir] ");

            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }

            return Task.FromResult(item);
        }

        private void RemoverHistorico(Domain.Models.Corporativo.Gestor.Odontograma.Odontograma item)
        {
            ClearParameters();
            AddParameters(item, nameof(RemoverHistorico));
            AddParameters("ch_nr_atendOdont", item.AtendimentoId.GetDBNullOrValue());
            AddParameters("vc_ds_logon_sistema", LOGONINTEGRACAO);
            AddStroredProcedure("[dbo].[spHistOdontogramaExcluir] ");

            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }
        }

        public override Task<Domain.Models.Corporativo.Gestor.Odontograma.Odontograma> Adicionar(Domain.Models.Corporativo.Gestor.Odontograma.Odontograma item)
        {
            ClearParameters();
            AddParameters(item, nameof(Adicionar));
            AddParameters("in_sq_pessoa", item.PessoaId.GetDBNullOrValue());
            AddParameters("ch_nr_atendOdont", item.AtendimentoId.GetDBNullOrValue());
            AddParameters("in_sq_figuraodontograma", item.FiguraOdontogramaId.GetDBNullOrValue());
            AddParameters("ch_fg_operacao_odontograma", item.Operacao?.Id.GetDBNullOrValue());
            AddParameters("ti_nr_dente_odontograma", item.NumeroDente.GetDBNullOrValue());
            AddParameters("ch_nr_pto", DBNull.Value);
            AddParameters("ch_fg_radiografia_odontograma", item.Radiografia?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_raiz1_odontograma", item.Raiz1?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_raiz2_odontograma", item.Raiz2?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_raiz3_odontograma", item.Raiz3?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_face1_odontograma", item.Face1?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_face2_odontograma", item.Face2?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_face3_odontograma", item.Face3?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_face4_odontograma", item.Face4?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_face5_odontograma", item.Face5?.Id.GetDBNullOrValue());
            AddParameters("in_sq_classifservoficAtend", DBNull.Value);
            AddParameters("ch_nr_atendOdont_referencia", DBNull.Value);
            AddParameters("vc_ds_logon_sistema", LOGONINTEGRACAO);
            AddStroredProcedure("[dbo].[spOdontogramaIncluir] ");

            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }

            return Task.FromResult(item);
        }
    }
}