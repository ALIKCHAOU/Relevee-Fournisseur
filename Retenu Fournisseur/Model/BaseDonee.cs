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
                string a = "Data Source=" + DBS.ServerName + "; Database=" + DBS.NameDataBase + ";User Id=" + DBS.UserName + ";Pwd=" + DBS.Password + ";Integrated Security=False;Connection Timeout=0";
                return a;
            }
            else
            {
                string a = "Data Source=" + DBS.ServerName + "; Database=" + DBS.NameDataBase + ";User Id=;Pwd=;Integrated Security = true;Connection Timeout=0";
                return a;
            }


        }
    }
}
