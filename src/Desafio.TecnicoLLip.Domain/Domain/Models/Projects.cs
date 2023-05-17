#region Includes
using Desafio.TecnicoLLip.Domain.Models.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#endregion

namespace Desafio.TecnicoLLip.Domain.Models
{
    public class Project : BaseModel<int>
    {
      [Required(AllowEmptyStrings = true)]
      [StringLength(100)]
      public string Title { get; set; }

      [Required(AllowEmptyStrings = true)]
      [StringLength(600)]
      public string Description { get; set; }

      [Required]
      public DateTime CreationDate { get; set; }

      public IList<Activities> Activities { get; set; }
    }
}
