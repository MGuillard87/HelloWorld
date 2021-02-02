using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {

        private string BONJOUR = "Bonjour";
        private string BONAPRESMIDI = "Bon après-midi";
        private string BONSOIR = "Bonsoir";
        private string BONWEEKEND = "Bon week-end";

        private DateTime local = DateTime.Now;
        private DateTime heure = DateTime.Now;
        private string nomUtilisateur = Environment.UserName;



        private string messageDeSalutation()
        {
            int jourLocalActuel = this.local.Day;
            int heureActuel = this.heure.Hour;
       

            if (jourLocalActuel == 1 || jourLocalActuel == 2 || jourLocalActuel == 3 || jourLocalActuel == 4 || jourLocalActuel == 5)

            {
                if (heureActuel >= 9 && heureActuel < 13)
                {
                    Console.WriteLine(BONJOUR + " " + nomUtilisateur);
                    return "";
                }
                else if (heureActuel >= 13 && heureActuel < 18)
                {
                    Console.WriteLine(BONAPRESMIDI + " " + nomUtilisateur);
                    return "";
                }
                else if ((heureActuel > 18 && jourLocalActuel == 5) || (heureActuel <= 9 && jourLocalActuel == 1))
                {
                    Console.WriteLine(BONWEEKEND + " " + nomUtilisateur);
                    return "";
                }
                else if (heureActuel > 18)
                {
                    Console.WriteLine(BONSOIR + " " + nomUtilisateur);
                    return "";
                } else
                {
                    return "pas de résultat";
                }

            } else
            {
                return "pas de résultat";
            }


        }

        public string infoMessageSalutation
        {
            get { return messageDeSalutation(); }
         
        }


    }
}
