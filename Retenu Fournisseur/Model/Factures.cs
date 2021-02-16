using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retenu_Fournisseur.Model
{
  public  class Factures
    {
        public string TiersNo { get; set; }
        public string TiersNumero { get; set; }
         public string		TiersIntitule { get; set; }
        public decimal  Montant { get; set; }
        public int		Sens { get; set; }
        public string	Libelle { get; set; }
	 	 public DateTime Date { get; set; }
         public string 	Journal { get; set; }
         public string	SocieteNo { get; set; }
          public string	 TypeCode { get; set; }
           public string    Mode { get; set; }
          public string Numero { get; set; }
          public string	IsLettre { get; set; }
           public DateTime Echeance { get; set; }
           public decimal  Debit { get; set; }
           public decimal Credit { get; set; }
          public decimal Solde { get; set; }


    }
}
