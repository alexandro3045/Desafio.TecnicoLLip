﻿#region Includes
using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
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
        public IList<AtividadesViewModel> Activities { get; set; }

    }
}
