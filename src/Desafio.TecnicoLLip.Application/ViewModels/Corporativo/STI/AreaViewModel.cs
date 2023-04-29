﻿using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.STI
{
    ///<summary>
    ///Objeto Area"/>
    ///</summary>
    [DataContract]
    public class AreaViewModel : TipoViewModel<string>
    {
        ///<summary>
        ///Código da área ocupacional informado pelo DN
        ///Ex.: 10
        ///</summary>
        [DataMember]
        public string CodigoDnaArea { get; set; }
        ///<summary>
        ///Data que indica o termino da area em questão
        ///</summary>
        [DataMember]
        public DateTime? Fim { get; set; }


    }
}