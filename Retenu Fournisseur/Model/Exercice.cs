using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retenu_Fournisseur.Model
{
  public  class Exercice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ExerciceId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Annee { get; set; }
        [Required]
        public bool IsArchive { get; set; }
        [Required]
        public bool IsCloturer { get; set; }
    }
}
