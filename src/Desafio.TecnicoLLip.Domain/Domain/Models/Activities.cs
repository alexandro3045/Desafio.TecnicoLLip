#region Includes
using Desafio.TecnicoLLip.Domain.Models.Base;
using System;
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
        public int UserId { get; set; }

        [Required]
        public Users Resposavel { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public Project Project { get; set; }

        [Required]
        public EnumStatus Status { get; set; }
    }

}
