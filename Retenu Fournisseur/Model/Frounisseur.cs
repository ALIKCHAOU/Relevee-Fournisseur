using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retenu_Fournisseur.Model
{
  public  class Frounisseur
    {
        [Key]
        public string CT_Num { get; set; }
        public string CT_Intitule { get; set; }
        public string CT_Identifiant { get; set; }
        public string CT_Contact { get; set; }
        public string CT_Adresse { get; set; }
        public string CT_Complement { get; set; }
        public string CT_CodePostal { get; set; }
        public string CT_Ville { get; set; }
        public string CT_Pays { get; set; }
        public string CT_Telephone { get; set; }
        public string CT_Telecopie { get; set; }
        
    }
}
