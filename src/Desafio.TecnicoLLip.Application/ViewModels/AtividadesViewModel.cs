#region Includes
using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
#endregion

namespace Desafio.TecnicoLLip.Application.ViewModels
{
    public class AtividadesViewModel : Base.Base
    {
        /////<summary>
        /////Id do cadastro de novas atividades.
        /////</summary>
        [Required]
        [DataMember]
        public int Id { get; set; }

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

    }
}
