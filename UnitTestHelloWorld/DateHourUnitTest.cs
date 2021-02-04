using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloWorld;
using UnitTestHelloWorld.Fakes;

namespace UnitTestHelloWorld
{
    [TestClass]
    public class Unit
    {
        [TestMethod]
        
        // Création d'une première fonction de test

        public void GetDateHour_fake_test()
        {
            //Instancier l'objet à tester avec le constructeur de FakeDataProvider
            FakeDataProvider unTestFake = new FakeDataProvider(10, DayOfWeek.Monday) ;
            // target = objet testé avec le bon constructeur
            // on donne à Message une interface en argument -> IDataProvider
            Message target = new Message(unTestFake, 8, 13, 18);
            // test avec une heure avec tous les messages:
            // Hour = 10 
            // Day = lundi
            Assert.AreEqual("Bonjour", target.HelloMessage);

          /*  // Hour = 15
            Assert.AreEqual("Bon après-midi", target.getHelloMessage);
            // Hour = 21
            Assert.AreEqual("Bonsoir", target.getHelloMessage);
*/



        }
    }
}
