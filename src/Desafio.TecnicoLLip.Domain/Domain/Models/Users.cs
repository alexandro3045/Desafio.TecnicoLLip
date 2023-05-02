#region Includes
using Desafio.TecnicoLLip.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;
#endregion

namespace Desafio.TecnicoLLip.Domain.Models
{
    public class Users : BaseModel<int>
    {
        [Required(AllowEmptyStrings = true)]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(200)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(400)]
        public string Password { get; set; }
    }
}
