#region Includes
using Desafio.TecnicoLLip.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Desafio.TecnicoLLip.Application.ViewModels.Enums;
#endregion

namespace Desafio.TecnicoLLip.Application.ViewModels
{
    public class AtividadeViewModel : Base.BaseViewModel<int>
    {
        /////<summary>
        /////Título do cadastro de novas atividades.
        /////</summary>
        [Required]
        [StringLength(100)]
        [DataMember]
        public string Titulo { get; set; }

        /////<summary>
        /////Descricão do cadastro de novas atividades.
        /////</summary>
        [Required]
        [StringLength(600)]
        [DataMember]
        public string Descricao { get; set; }

        /////<summary>
        /////Data criação do cadastro de novas atividades.
        /////</summary>
        [Required]
        [DataMember]
        public DateTime DataCriacao { get; set; }

        /////<summary>
        /////Data conclusão do cadastro de novas atividades.
        /////</summary>
        [Required]
        [DataMember]
        public DateTime DataConclusao { get; set; }

        /////<summary>
        /////Responsável pela atividade.
        /////</summary>
        [Required]
        [DataMember]
        public Users Resposavel { get; set; }

        /////<summary>
        /////Status da atividade.
        /////</summary>
        [Required]
        [DataMember]
        public EnumStatusViewModel Status { get; set; } = EnumStatusViewModel.Pendente;
    }    
}
