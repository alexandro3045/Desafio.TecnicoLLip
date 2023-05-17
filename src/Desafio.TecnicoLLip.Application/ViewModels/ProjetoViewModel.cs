#region Includes
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Desafio.TecnicoLLip.Application.ViewModels.Enums;
#endregion

namespace Desafio.TecnicoLLip.Application.ViewModels
{
    public class ProjetoViewModel : Base.Base
    {
        /////<summary>
        /////Id do cadastro de novos projetos.
        /////</summary>
        [Required]
        [DataMember]
        public int Id { get; set; }

        /////<summary>
        /////Título do cadastro de novos projetos.
        /////</summary>
        [Required]
        [StringLength(100)]
        [DataMember]
        public string Titulo { get; set; }

        /////<summary>
        /////Descricão do cadastro de novos projetos.
        /////</summary>
        [Required]
        [StringLength(600)]
        [DataMember]
        public string Descricao { get; set; }

        /////<summary>
        /////Descricão do cadastro de novos projetos.
        /////</summary>
        [Required]
        [DataMember]
        public DateTime DataCriacao { get; set; }

        /////<summary>
        /////Lista de atividades do projeto.
        /////</summary>
        [DataMember]
        public IList<AtividadeViewModel> Tarefas { get; set; }

        /////<summary>
        /////Status da atividade.
        /////</summary>
        [Required]
        [DataMember]
        public EnumStatusViewModel Status { get; set; } = EnumStatusViewModel.Pendente;

    }
}
