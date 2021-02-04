using System;


namespace HelloWorld
{
    public interface IDataProvider
    {
        /*interface IDataProvider contient une heure et un jour mais le get n'est pas implémenté: on définit 
        un comportement sans définir la manière dont c'est fait == le comportement d'une interface (différent
        de l'objet Dataprovider qui implémente le get)
        */
        int Hour { get; }
        DayOfWeek Day { get; }
    }
}
