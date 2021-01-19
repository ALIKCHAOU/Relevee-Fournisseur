using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retenu_Fournisseur.Model
{
   public class BaseDonee
    {
        [Key]
        public string Name { get; set; }
        public string NameDataBase { get; set; }
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool autentificationWindows { get; set; }
        public string StringConnection(BaseDonee DBS)
        {
            if (!autentificationWindows)
            {
                string a = "Server=" + DBS.ServerName + "; Database=" + DBS.NameDataBase + ";User ID=" + DBS.UserName + ";Password=" + DBS.Password + ";";
                return a;
            }
            else
            {
                string a = "Server=" + DBS.ServerName + "; Database=" + DBS.NameDataBase + ";User ID=;Password=;Integrated Security = true";
                return a;
            }


        }
    }
}
