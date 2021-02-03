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
        private int matin;
        private int apresMidi;
        private int soir;

        private string nomUtilisateur = Environment.UserName;

        public Message(int unMatin, int unApresMidi, int unSoir)
        {
            this.matin = unMatin;
            this.apresMidi = unApresMidi;
            this.soir = unSoir;
        }



        private string messageDeSalutation()
        {
            DayOfWeek jourLocalActuel = DateTime.Now.DayOfWeek;
            int heureActuel = DateTime.Now.Hour;


            if (jourLocalActuel == DayOfWeek.Monday || jourLocalActuel == DayOfWeek.Tuesday || jourLocalActuel != DayOfWeek.Wednesday || jourLocalActuel == DayOfWeek.Thursday || jourLocalActuel == DayOfWeek.Friday)

            {
                Console.WriteLine(BONWEEKEND + " " + nomUtilisateur);
                return "";
            } else
            {
                if (heureActuel >= this.matin && heureActuel < this.apresMidi)
                {
                    Console.WriteLine(BONJOUR + " " + nomUtilisateur);
                    return "";
                }
                else if (heureActuel >= this.apresMidi && heureActuel < this.soir)
                {
                    Console.WriteLine(BONAPRESMIDI + " " + nomUtilisateur);
                    return "";
                } else
                {
                    Console.WriteLine(BONSOIR + " " + nomUtilisateur);
                    return "";
                }
            }
        }

        public string HelloMessage
        {
            get { return messageDeSalutation(); }
         
        }


    }
}
