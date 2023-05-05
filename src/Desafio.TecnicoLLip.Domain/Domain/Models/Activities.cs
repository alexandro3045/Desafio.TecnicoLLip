using Desafio.TecnicoLLip.Domain.Models.Base;
using System;
#region Includes
using System.ComponentModel.DataAnnotations;
#endregion

namespace Desafio.TecnicoLLip.Domain.Models
{
    public class Activities : BaseModel<int>
    {
        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(600)]
        public string Description { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime ConclusionDate { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public Projects Projects { get; set; }

        [Required]
        public int UserId { get; set; }

        public Users Resposavel { get; set; }
    }
}
