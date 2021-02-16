using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retenu_Fournisseur.Model
{
  public  class ImpressionReleveeFournisseur
    {
        public string RaisonSociale { get; set; }
        public string Profession { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public List<Factures> Factures { get; set; }
    }
}
