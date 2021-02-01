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
            String nom_de_utilisateur = Environment.UserName;
             Console.WriteLine("Hello " + nom_de_utilisateur + " !");
            //ajouter du code pour suspendre l’application afin que la fenêtre de console ne se ferme pas 
            Console.ReadLine();
        }
    }
}
