using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Saude;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.STI;
using Desafio.TecnicoLLip.Domain.Models.Protheus;
using Desafio.TecnicoLLip.Domain.Models.SGE;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Protheus;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.Saude;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.SRC;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps.Corporativo.STI;
using Desafio.TecnicoLLip.Infrastructure.Data.Maps.SGE;
using FluentValidation.Results;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo
{
    public class CorporativoContext : DbContext
    {
        public CorporativoContext(DbContextOptions<CorporativoContext> options, IHostingEnvironment env) : base(options)
        {
#if DEBUG
            this.ConfigureLogging(s => Console.Write(s), LoggingCategories.SQL);
#endif
            int? e = Database.GetCommandTimeout();

            Database.SetCommandTimeout(e.HasValue ? e + 12000 : 12000);
        }

        #region DbSets
        public DbSet<Domain.Models.Corporativo.STI.Area> Areas { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<TipoFicha> TiposFichas { get; set; }
        public DbSet<UnidadeNegocio> UnidadeNegocios { get; set; }
        public DbSet<UnidadeFederativa> UnidadesFederativas { get; set; }
        public DbSet<EmpresaSistemaCniCoordenadora> EmpresasSistemaCNI { get; set; }
        public DbSet<ItemContabil> ItensContabeis { get; set; }
        public DbSet<ClasseValor> ClassesValores { get; set; }
        public DbSet<ContaContabil> ContasContabeis { get; set; }
        public DbSet<LinhaServico> LinhasServicos { get; set; }
        public DbSet<ProdutoUnidadeNegocio> ProdutosUnidadeNegocios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<EnderecoUnidade> EnderecosUnidades { get; set; }
        public DbSet<TipoRegiao> TiposRegioes { get; set; }
        public DbSet<UF> UFs { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<RegiaoUnidadeNegocio> RegioesUnidadesNegocios { get; set; }
        public DbSet<CodigoMunicipal> CodigosMunicipais { get; set; }
        public DbSet<ClassificacaoServico> ClassificacoesServicos { get; set; }
        public DbSet<TipoEntidadeVinculo> TiposEntidadesVinculos { get; set; }
        public DbSet<Entidade> Entidades { get; set; }
        public DbSet<ProdutoTipoFicha> ProdutosTipoFichas { get; set; }
        public DbSet<CentroCusto> CentrosCustos { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<TipoUnidadeNegocioTipoEntidadeVinculo> TiposUnidadeNegociosTiposEntidadesVinculos { get; set; }
        public DbSet<TipoServico> TiposServicos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<GrupoClassificacao> GruposClassificacoes { get; set; }
        public DbSet<Tuss> TUSSES { get; set; }
        public DbSet<ItemContabilProduto> ItemsContabeisProdutos { get; set; }
        public DbSet<ContaContabilProduto> ContasContabeisProdutos { get; set; }
        public DbSet<ClasseValorProduto> ClassesValoresProdutos { get; set; }
        public DbSet<Domain.Models.Protheus.Empresa> EmpresasProtheus { get; set; }
        public DbSet<Domain.Models.Corporativo.Gestor.Empresa> Empresas { get; set; }
        public DbSet<EmpresaEntidadeVinculo> EmpresasEntidadesVinculos { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<TipoModalidade> TiposModalidades { get; set; }
        public DbSet<PortifolioEducacao> PortifolliosEducacoes { get; set; }
        public DbSet<Instrucao> Instrucoes { get; set; }
        public DbSet<ModuloVersao> ModulosVersoes { get; set; }
        public DbSet<NaturezaServico> NaturezasServicos { get; set; }
        public DbSet<TabelaServicoTipoEntidadeVinculo> TabelaServicosTipoEntidadesVinculos { get; set; }
        public DbSet<ClassificacaoExame> ClassificacoesExames { get; set; }
        public DbSet<TipoRisco> TipoRiscos { get; set; }
        public DbSet<Risco> Riscos { get; set; }
        public DbSet<Saude> Saudes { get; set; }
        public DbSet<Agente> Agentes { get; set; }
        public DbSet<FiguraOdontograma> FigurasOdontogramas { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<SaudeFiguraOdontograma> SaudesFigurasOdontogramas { get; set; }
        public DbSet<TipoCliente> TiposClientes { get; set; }
        public DbSet<TipoContrato> TiposContratos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Odontograma> Odontogramas { get; set; }
        public DbSet<Lazer> Lazeres { get; set; }
        public DbSet<AreaDN> AreasDNs { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Aply Configuration Mapper

            modelBuilder
                .Ignore<ValidationFailure>();

            modelBuilder
                .Ignore<ValidationResult>();

            modelBuilder
                .ApplyConfiguration(new RamoAtividadeMap());

            modelBuilder
                .ApplyConfiguration(new TipoRegimentoMap());

            modelBuilder.ApplyConfiguration(new GeneroMap());

            modelBuilder
                .ApplyConfiguration(new TipoEntidadeVinculoMap());

            modelBuilder
                .ApplyConfiguration(new EntidadeMap());

            modelBuilder
                .ApplyConfiguration(new FuncaoMap());

            modelBuilder
                .ApplyConfiguration(new AreaMap());

            modelBuilder
                .ApplyConfiguration(new PlataformaMap());

            modelBuilder
                .ApplyConfiguration(new TipoFichaMap());

            modelBuilder
                .ApplyConfiguration(new EmpresaSistemaCniCoordenadoraMap());

            modelBuilder
                .ApplyConfiguration(new UnidadeNegocioMap());

            modelBuilder
                .ApplyConfiguration(new UFMap());

            modelBuilder
                .ApplyConfiguration(new MunicipioMap());

            modelBuilder
                .ApplyConfiguration(new TipoServicoMap());

            modelBuilder
                .ApplyConfiguration(new NivelServicoMap());

            modelBuilder
                .ApplyConfiguration(new TabelaServicoMap());

            modelBuilder
                .ApplyConfiguration(new GrupoClassificacaoMap());

            modelBuilder
                .ApplyConfiguration(new TussMap());

            modelBuilder
                .ApplyConfiguration(new ProdutoMap());

            modelBuilder
                .ApplyConfiguration(new CodigoMunicipalMap());

            modelBuilder
                .ApplyConfiguration(new CodigoMunicipalServicoCorporativoMap());

            modelBuilder
                .ApplyConfiguration(new ItemContabilMap());

            modelBuilder
                .ApplyConfiguration(new ClasseValorMap());

            modelBuilder
                .ApplyConfiguration(new ContaContabilMap());

            modelBuilder
                .ApplyConfiguration(new LinhaServicoMap());

            modelBuilder
                .ApplyConfiguration(new ProdutoUnidadeNegocioMap());

            modelBuilder
                .ApplyConfiguration(new TipoRegiaoMap());

            modelBuilder
                .ApplyConfiguration(new MunicipioMap());

            modelBuilder
                .ApplyConfiguration(new BairroMap());

            modelBuilder
                .ApplyConfiguration(new EnderecoUnidadeMap());

            modelBuilder
                .ApplyConfiguration(new RegiaoMap());

            modelBuilder
                .ApplyConfiguration(new RegiaoUnidadeNegocioMap());

            modelBuilder
                .ApplyConfiguration(new ClassificacaoServicoMap());

            modelBuilder
                .ApplyConfiguration(new TipoUnidadeNegocioMap());

            modelBuilder
                .ApplyConfiguration(new TipoUnidadeNegocioTipoEntidadeVinculoMap());

            modelBuilder
                .ApplyConfiguration(new EntidadeMap());

            modelBuilder
                .ApplyConfiguration(new ProdutoTipoFichaMap());

            modelBuilder
                .ApplyConfiguration(new CentroCustoMap());

            modelBuilder
                .ApplyConfiguration(new FilialMap());

            modelBuilder
                .ApplyConfiguration(new ItemContabilProdutoMap());

            modelBuilder
                .ApplyConfiguration(new ContaContabilProdutoMap());

            modelBuilder
                .ApplyConfiguration(new ClasseValorProdutoMap());

            modelBuilder
                .ApplyConfiguration(new EmpresaMap());

            modelBuilder
                .ApplyConfiguration(new Maps.Protheus.EmpresaMap());

            modelBuilder
                .ApplyConfiguration(new ModalidadeMap());

            modelBuilder
                .ApplyConfiguration(new TipoModalidadeMap());

            modelBuilder
                .ApplyConfiguration(new PortifolioEducacaoMap());

            modelBuilder
                .ApplyConfiguration(new InstrucaoMap());

            modelBuilder
                .ApplyConfiguration(new NaturezaServicoMap());

            modelBuilder
                .ApplyConfiguration(new ModuloVersaoMap());

            modelBuilder
                .ApplyConfiguration(new TabelaServicoTipoEntidadeVinculoMap());

            modelBuilder
                .ApplyConfiguration(new ClassificacaoExameMap());

            modelBuilder
                .ApplyConfiguration(new TipoRiscoMap());

            modelBuilder
                .ApplyConfiguration(new RiscoMap());

            modelBuilder
                .ApplyConfiguration(new AgenteMap());

            modelBuilder
                .ApplyConfiguration(new SaudeMap());

            modelBuilder
                .ApplyConfiguration(new PessoaMap());

            modelBuilder
                .ApplyConfiguration(new TipoContratoMap());

            modelBuilder
                .ApplyConfiguration(new ContratoMap());

            modelBuilder
                .ApplyConfiguration(new TipoClienteMap());

            modelBuilder
                .ApplyConfiguration(new ServicoMap());

            modelBuilder
                .ApplyConfiguration(new LazerMap());

            modelBuilder
                .ApplyConfiguration(new AreaDNMap());

            modelBuilder
                .ApplyConfiguration(new EmpresaEntidadeVinculoMap());

            #endregion

            modelBuilder
                .Entity<Produto>()
                .HasQueryFilter(c => (c.Fim == null || c.Fim > DateTime.Now) && (c.Validade == null || c.Validade >= DateTime.Now));

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }

        public static readonly LoggerFactory LoggerFactory = new LoggerFactory(new[] { new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider() });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .ConfigureWarnings(bulder =>
                      bulder
                      .Default(WarningBehavior.Ignore)
               );

            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}