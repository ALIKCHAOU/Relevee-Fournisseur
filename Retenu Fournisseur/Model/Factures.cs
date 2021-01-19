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
        public int TiersNumero { get; set; }
         public string		TiersIntitule { get; set; }
        public string  Montant { get; set; }
        public string		Sens { get; set; }
        public string	Libelle { get; set; }
	 	 public string	 Date { get; set; }
         public string 	Journal { get; set; }
         public string			SocieteNo { get; set; }
          public string	 TypeCode { get; set; }
           public string    Mode { get; set; }
          public string Numero { get; set; }
          public string	IsLettre { get; set; }
           public string  Echeance { get; set; }
           public string  Piece { get; set; }
    }
}
