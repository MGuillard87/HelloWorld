using System;

namespace HelloWorld
{
    //DataProvider implémente le IDataprovider
    class DataProvider : IDataProvider
    {
        public int Hour
        {
            // création d'une propertie simple pour retourner une valeur: l'heure
            // quand la classe Message va appeler Hour du Dataprovider, le code ci-dessous va être exécuté
            get
            {
                return DateTime.Now.Hour;
            }
        }

        public DayOfWeek Day
        {
            get
            {
                return DateTime.Now.DayOfWeek;
            }
        }
    }
}
