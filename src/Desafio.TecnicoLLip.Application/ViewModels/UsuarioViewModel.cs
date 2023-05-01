#region Includes
using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
#endregion

namespace Desafio.TecnicoLLip.Application.ViewModels
{
    public class UsuarioViewModel : TipoViewModel<int>
    {

        /////<summary>
        /////Email do usuário no cadastro de novos usuários.
        /////</summary>
        [Required]
        [StringLength(200)]
        [DataMember]
        public string Email { get; set; }

        /////<summary>
        /////Senha do usuário no cadastro de novos usuários.
        /////</summary>
        [Required]
        [StringLength(400)]
        [DataMember]
        public string Password { get; set; }

    }
}