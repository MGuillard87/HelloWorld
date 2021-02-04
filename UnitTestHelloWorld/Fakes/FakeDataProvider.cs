using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld;

namespace UnitTestHelloWorld.Fakes
{
    // FakeDataProvider = une implémentation de l'interface IDataProvider qui va être propre à nos test
    public class FakeDataProvider : IDataProvider
    {
        //Création d'un constructeur avec l'utilisation que l'on veut en faire
      
        public FakeDataProvider(int hour, DayOfWeek day)
        {
            this.Hour = hour;
            this.Day = day;
        }
        /*Assignation de la valeur récupérer dans le constructeur pour les assigner à la propriété:
         * quand fake sera utiliser par Message, il accèdera directement à la valeur
        private set" pour dire qu'il n'y a que les méthodes de cette classe qui ont le droit 
        d'assigner la valeur hour
        */
        public int Hour { get; private set; }

        public DayOfWeek Day { get; private set; }

    }
}
