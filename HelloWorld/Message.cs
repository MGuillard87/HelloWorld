using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {

        private const string BONJOUR = "Bonjour";
        private const string BONAPRESMIDI = "Bon après-midi";
        private const string BONSOIR = "Bonsoir";
        private const string BONWEEKEND = "Bon week-end";
        private int matin;
        private int apresMidi;
        private int soir;

        private string nomUtilisateur = Environment.UserName;
        /* la classe message doit pouvoir avoir une instance de DataProvider 
         * (de type IDataProvider pour l'utilisation des tests) pour s'en servir 
         == en quelque sorte un objet hybride
        Message utilisera toujours IDataprovider pour une utilisation normale du programme
        (assure un contrat d'utilisation)
        */
        private IDataProvider dataProvider;

        public Message(int unMatin, int unApresMidi, int unSoir)
            // Ce constructeur va être appelé par le main()
            // instanciation dans le constructeur de DataProvider de type IDataProvider pour pouvoir l'utiliser
            /*': this' permet d'appeler le ou les autres constructeur de la classe, on va lui passer:
             * une instance de DataProvider
             * on va appeler le second constructeur
             */
            : this(new DataProvider(), unMatin, unApresMidi, unSoir)
        {
        }


        /* Pour que notre DataProvider dans cette classe ne soit pas équialent à une instance de DataProvider
         * mais à une instance du Fake que l'on aura défini dans les tests: il faut passer l'INTERFACE en 
         * paramètre du second constructeur: on va lui demander de le STOCKER
         */
        public Message(IDataProvider dataProvider, int unMatin, int unApresMidi, int unSoir)
        {
            // un seul lieu on affecte les valeurs = réduit les sources de bug + code simple à entretenir
            this.dataProvider = dataProvider;
            this.matin = unMatin;
            this.apresMidi = unApresMidi;
            this.soir = unSoir;
        }

        private string messageDeSalutation()
        {
            DayOfWeek jourLocalActuel = this.dataProvider.Day;
            // On récupère l'heure depuis DataProvider de type IDataProvider 
            int heureActuel = this.dataProvider.Hour;


            if (jourLocalActuel != DayOfWeek.Monday && jourLocalActuel != DayOfWeek.Tuesday && jourLocalActuel != DayOfWeek.Wednesday && jourLocalActuel != DayOfWeek.Thursday && jourLocalActuel != DayOfWeek.Friday)
            {
                Console.WriteLine(BONWEEKEND + " " + nomUtilisateur);
                return BONWEEKEND;
            }
            else
            {
                if (heureActuel >= this.matin && heureActuel < this.apresMidi)
                {
                    //Console.WriteLine(BONJOUR + " " + nomUtilisateur);
                    return BONJOUR;
                }
                else if (heureActuel >= this.apresMidi && heureActuel < this.soir)
                {
                    Console.WriteLine(BONAPRESMIDI + " " + nomUtilisateur);
                    return BONAPRESMIDI;
                }
                else
                {
                    Console.WriteLine(BONSOIR + " " + nomUtilisateur);
                    return BONSOIR;
                }
            }
        }

        public string HelloMessage
        {
            get { return messageDeSalutation(); }

        }

    }
}
