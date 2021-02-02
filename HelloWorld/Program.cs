using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Message unMessage = new Message();
            Console.WriteLine(unMessage.infoMessageSalutation);
      
            //ajouter du code pour suspendre l’application afin que la fenêtre de console ne se ferme pas 
            Console.ReadLine();
        }
    }
}
