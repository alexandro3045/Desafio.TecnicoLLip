using AutoMapper;
using Desafio.TecnicoLLip.Application.ViewModels;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos.Base;
using Desafio.TecnicoLLip.Application.ViewModels.Protheus;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Saude;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.SRC;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.STI;
using Desafio.TecnicoLLip.Application.ViewModels.SGE;
using Desafio.TecnicoLLip.Application.ViewModels.SMAIS;
using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Base;
using Desafio.TecnicoLLip.Domain.Models.Protheus;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Saude;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.STI;
using Desafio.TecnicoLLip.Domain.Models.SGE;

namespace Desafio.TecnicoLLip.Application.AutoMapperConfigs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Models.Base.Base, ViewModels.Base.Base>()
                .ReverseMap();

            CreateMap<Domain.Models.Base.BaseModel<object>, ViewModels.Base.BaseViewModel<object>>()
                .ReverseMap();

            CreateMap<Tuss, TussViewModel>()
                .ReverseMap();

            CreateMap<LinhaServico, LinhaServicoViewModel>()
                .ForMember(dest => dest.FuncaoViewModel, opt => opt.MapFrom(src => src.Funcao))
                .ReverseMap();

            CreateMap<ClassificacaoServico, ClassificacaoServicoViewModel>()
                .ForMember(dest => dest.LinhaServicoId, opt => opt.MapFrom(src => src.LinhaServicoId))
                .ForMember(dest => dest.LinhaServico, opt => opt.MapFrom(src => src.LinhaServico))
                .ReverseMap();

            CreateMap<Especialidade, EspecialidadeView>()
                .ConstructUsing(s => new EspecialidadeView(s.Id, s.Name));

            CreateMap<Domain.Models.Corporativo.Gestor.Tipos.TipoServico, TipoServicoView>()
                .ConstructUsing(s => new TipoServicoView(s.Id, s.Name));

            CreateMap<GrupoClassificacao, GrupoClassificacaoViewModel>()
                .ReverseMap();

            CreateMap<TabelaServico, TabelaServicoViewModel>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                 .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao))
                 .ReverseMap();

            CreateMap<NivelServico, NivelServicoViewlModel>()
                .ReverseMap();

            CreateMap<Domain.Models.Corporativo.Gestor.TipoServico, TipoServicoViewModel>()
                .ReverseMap();

            CreateMap<Domain.Models.Corporativo.Gestor.TipoEntidadeVinculo, TipoEntidadeVinculoViewModel>()
                .ReverseMap();

            CreateMap<Domain.Models.Corporativo.STI.Area, AreaViewModel>()
                .ReverseMap();

            CreateMap<Coligada, ColigadaViewModel>();

            CreateMap<ModalidadeCurso, ModalidadeCursoViewModel>()
                .ReverseMap();

            CreateMap<UF, UFViewModel>()
                .ReverseMap();

            CreateMap<Filial, FilialViewModel>();

            CreateMap<Municipio, MunicipioViewModel>()
               .ReverseMap();

            CreateMap<Bairro, BairroViewModel>()
                .ForMember(dest => dest.CodigoMunicipio, opt => opt.MapFrom(src => src.MunicipioId))
                .ReverseMap();

            CreateMap<EnderecoUnidade, EnderecoUnidadeViewModel>()
                .ReverseMap();

            CreateMap<TipoRegiao, TipoRegiaoViewModel>()
                .ReverseMap();

            CreateMap<Regiao, RegiaoViewModel>()
                .ReverseMap();

            CreateMap<Genero, GeneroViewModel>()
                .ReverseMap();

            CreateMap<RamoAtividade, RamoAtividadeViewModel>()
                .ReverseMap();

            CreateMap<UnidadeVinculada, UnidadeVinculadaView>()
                .ConstructUsing(s => new UnidadeVinculadaView(s.Id, s.Name));

            CreateMap<TipoUnidadeNegocio, TipoUnidadeNegocioViewModel>()
                .ReverseMap();

            CreateMap<TipoUnidadeNegocioTipoEntidadeVinculo, TipoUnidadeNegocioTipoEntidadeVinculoViewModel>()
                .ForMember(dest => dest.TipoEntidadeVinculoId, opt => opt.MapFrom(src => src.TipoEntidadeVinculoId))
                .ForMember(dest => dest.TipoEntidadeVinculo, opt => opt.MapFrom(src => src.TipoEntidadeVinculo))
                .ForMember(dest => dest.TipoUnidadeNegocioId, opt => opt.MapFrom(src => src.TipoUnidadeNegocioId))
                .ForMember(dest => dest.TipoUnidadeNegocio, opt => opt.MapFrom(src => src.TipoUnidadeNegocio))
                .ReverseMap();

            CreateMap<Domain.Models.Corporativo.Gestor.TipoRegimento, TipoRegimentoViewModel>()
                .ReverseMap();

            CreateMap<Domain.Models.Protheus.Empresa, ViewModels.Protheus.EmpresaViewModel>()
                .ReverseMap();

            CreateMap<Domain.Models.Corporativo.Gestor.Empresa, ViewModels.Corporativo.Gestor.EmpresaViewModel>()
                .ReverseMap();

            CreateMap<GrupoClassificacao, GrupoClassificacaoViewModel>()
                .ReverseMap();

            CreateMap<Entidade, ViewModels.Corporativo.SRC.EntidadeViewModel>()
                .ForMember(dest => dest.TipoEntidadeVinculoId, opt => opt.MapFrom(src => src.TipoEntidadeVinculoId))
                .ForMember(dest => dest.TipoEntidadeVinculo, opt => opt.MapFrom(src => src.TipoEntidadeVinculo))
                .ReverseMap();

            CreateMap<Funcao, FuncaoViewModel>()
                .ReverseMap();

            CreateMap<Plataforma, PlataformaViewModel>()
                 .ForMember(dest => dest.Area, opt => opt.MapFrom(src => src.Area))
                 .ReverseMap(); 

            CreateMap<CentroCusto, CentroCustoViewModel>()
                .ReverseMap(); 

            CreateMap<Estabelecimento, EstabelecimentoViewModel>()
                .ReverseMap();

            CreateMap<Caixas, CaixasViewModel>()
                .ReverseMap();

            CreateMap<UnidadeNegocio, UnidadeNegocioViewModel>()
                .ReverseMap();

            CreateMap<EmpresaSistemaCniCoordenadora, EmpresaSistemaCniCoordenadoraViewModel>()
                .ReverseMap();

            CreateMap<CodigoMunicipalProduto, CodigoMunicipalProdutoViewModel>()
                .ReverseMap();

            CreateMap<CodigoMunicipalServicoCorporativo, CodigoMunicipalServicoCorporativoViewModel>()
                .IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();

            CreateMap<TipoFicha, TipoFichaViewModel>()
                .ReverseMap();

            CreateMap<Domain.Models.SGE.Area, AreaSgeViewModel>()
                .ReverseMap();

            CreateMap<ItemContabil, ItemContabilViewModel>()
                .ReverseMap();

            CreateMap<ClasseValor, ClasseValorViewModel>()
                .ReverseMap();

            CreateMap<ContaContabil, ContaContabilViewModel>()
                .ReverseMap();

            CreateMap<ProdutoUnidadeNegocio, ProdutoUnidadeNegocioViewModel>()
                .ReverseMap();

            CreateMap<RegiaoUnidadeNegocio, RegiaoUnidadeNegocioViewModel>()
                .IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ReverseMap();

            CreateMap<CodigoMunicipal, CodigoMunicipalViewModel>()
                .ReverseMap();

            CreateMap<Divulgado, DivulgadoView>();

            CreateMap<ValeCultura, ValeCulturaView>()
                .ConstructUsing(s => new ValeCulturaView(s.Id, s.Name));

            CreateMap<Domain.Models.Corporativo.Gestor.Tipos.Atendimento, AtendimentoView>()
                .ConstructUsing(s => new AtendimentoView(s.Id, s.Name));

            CreateMap<ClassificacaoExame, ClassificacaoExameViewModel>()
                .ReverseMap();

            CreateMap<Domain.Models.Corporativo.Gestor.Tipos.TipoServico, TipoServicoView>()
                .ConstructUsing(s => new TipoServicoView(s.Id, s.Name));

            CreateMap<ItemContabilProduto, ItemContabilProdutoViewModel>()
                .ReverseMap();

            CreateMap<ContaContabilProduto, ContaContabilProdutoViewModel>()
                .ReverseMap();

            CreateMap<ClasseValorProduto, ClasseValorProdutoViewModel>()
                .ReverseMap();

            CreateMap<Acao, AcaoView>()
                .ConstructUsing(s => new AcaoView(s.Id, s.Name));

            CreateMap<Modalidade, ModalidadeViewModel>()
                .ReverseMap();

            CreateMap<TipoModalidade, TipoModalidadeViewModel>()
                .ReverseMap();

            CreateMap<Instrucao, InstrucaoViewModel>()
                .ReverseMap();

            CreateMap<TipoModulo, TipoModuloView>()
                .ReverseMap();

            CreateMap<PortifolioEducacao, PortifolioEducacaoViewModel>()
                .ReverseMap();

            CreateMap<TipoResultado, TipoResultadoView>()
                .ConstructUsing(s => new TipoResultadoView(s.Id, s.Name));

            CreateMap<TipoEntidade, TipoEntidadeView>()
                .ReverseMap();

            CreateMap<Flag, FlagView>()
               .ConstructUsing(s => new FlagView(s.Id, s.Name));

            CreateMap<ContemDisciplina, ContemDisciplinaView>()
               .ReverseMap();

            CreateMap<TipoProcedimento, TipoProcedimentoView>()
                .ConstructUsing(s => new TipoProcedimentoView(s.Id, s.Name));

            CreateMap<GeraNumeroCertificado, GeraNumeroCertificadoView>()
               .ReverseMap();

            CreateMap<RefazCurso, RefazCursoView>()
               .ReverseMap();

            CreateMap<Divulgado, DivulgadoView>()
              .ConstructUsing(s => new DivulgadoView(s.Id, s.Name))
              .ReverseMap();

            CreateMap<Especialidade, EspecialidadeView>()
                .ConstructUsing(s => new EspecialidadeView(s.Id, s.Name))
                .ReverseMap();

            CreateMap<CustoSistema, CustoSistemaView>()
               .ConstructUsing(s => new CustoSistemaView(s.Id, s.Name))
               .ReverseMap();

            CreateMap<ObrigaArea, ObrigaAreaView>()
                .ConstructUsing(s => new ObrigaAreaView(s.Id, s.Name))
                .ReverseMap();

            CreateMap<ObrigaCusto, ObrigaCustoView>()
                .ConstructUsing(s => new ObrigaCustoView(s.Id, s.Name))
                .ReverseMap();

            CreateMap<TabelaServicoTipoEntidadeVinculo, TabelaServicoTipoEntidadeVinculoViewModel>()
                .IgnoreMap();

            CreateMap<TipoOrigemServico, TipoOrigemServicoView>()
                .ConstructUsing(s => new TipoOrigemServicoView(s.Id, s.Name))
                .ReverseMap();

            CreateMap<TipoServicoOdontologico, TipoServicoOdontologicoView>()
                .ConstructUsing(s => new TipoServicoOdontologicoView(s.Id, s.Name));

            CreateMap<TipoServicoOdontologicoView, TipoServicoOdontologico>()
                .ConstructUsing(s => new TipoServicoOdontologico(s.Id, s.Name));

            CreateMap<Saude, SaudeViewModel>()
                .ReverseMap();

            CreateMap<FiguraOdontograma, FiguraOdontogramaViewModel>()
                .ReverseMap();

            CreateMap<SaudeFiguraOdontograma, SaudeFiguraOdontogramaViewModel>()
                .ReverseMap();

            CreateMap<Odontograma, OdontogramaViewModel>()
                .ReverseMap();

            CreateMap<TipoRisco, TipoRiscoViewModel>()
                .ReverseMap();

            CreateMap<Risco, ViewModels.Corporativo.Gestor.RiscoViewModel>()
                .ReverseMap();

            CreateMap<Agente, AgenteViewModel>()
                .ReverseMap();

            CreateMap<AreaDN, AreaDNViewModel>()
                .ReverseMap();

            CreateMap<Lazer, LazerViewModel>()
               .ReverseMap();

            CreateMap<Categoria, CategoriaProdutoView>()
                .ConstructUsing(s => new CategoriaProdutoView(s.Id, s.Name));

            CreateMap<CategoriaProdutoView, Categoria>()
                .ConstructUsing(s => new Categoria(s.Id, s.Name));

            CreateMap<Produto, ProdutoViewModel>()
                .ReverseMap();

            CreateMap<ModuloVersao, ModuloVersaoViewModel>()
                .ForMember(dest => dest.Produto, opt => opt.MapFrom(src => src.Produto))
                .ReverseMap();

            CreateMap<AreaNegocio, AreaNegocioViewModel>()
                .ReverseMap();

            CreateMap<NaturezaServico, NaturezaServicoViewModel>()
                .ReverseMap();

            CreateMap<Servico, ServicoViewModel>()
                .ReverseMap();

            CreateMap<ProdutoTipoFicha, ProdutoTipoFichaViewModel>()
                .ReverseMap();


            CreateMap<Domain.Models.SMAIS.Exame, ExameViewModel>()
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(t => t.ATIVO))
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(t => t.COD))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(t => t.DESCRICAO))
                .ReverseMap();

            CreateMap<Domain.Models.SMAIS.Risco, ViewModels.SMAIS.RiscoViewModel>()
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(t => t.COD))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(t => t.NOME))
                .ForMember(dest => dest.CodigoAgenteESocial, opt => opt.MapFrom(t => t.CD_AGENTE_ESOCIAL))
                .ReverseMap();
        }
    }
}

