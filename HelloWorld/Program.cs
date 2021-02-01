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
            string nomUtilisateur = Environment.UserName;
            string bonjourMonde = "World";
            Console.WriteLine("Hello " + nomUtilisateur + " from " + bonjourMonde + " !");

            string bonjour = "Bonjour";
            string bonApresMidi = "Bon après-midi";
            string bonsoir = "Bonsoir";
            string bonWeekEnd = "Bon week-end";

            DateTime local = DateTime.Now;
            DateTime heure = DateTime.Now;
            int JourLocalActuel = local.Day;
            int HeureActuel = heure.Hour;
            HeureActuel = 19;
            JourLocalActuel = 1;

            if (JourLocalActuel == 1 || JourLocalActuel == 2 || JourLocalActuel == 3 || JourLocalActuel == 4 || JourLocalActuel == 5)

            {
                if (HeureActuel >= 9 && HeureActuel < 13)
                {
                    Console.WriteLine(bonjour + " " + nomUtilisateur);
                }
                else if (HeureActuel >= 13 && HeureActuel < 18)
                {
                    Console.WriteLine(bonApresMidi + " " + nomUtilisateur);
                }
                else if ((HeureActuel > 18 && JourLocalActuel == 5) || (HeureActuel <= 9 && JourLocalActuel == 1))
                {
                    Console.WriteLine(bonWeekEnd + " " + nomUtilisateur);
                }
                else if (HeureActuel > 18)
                {
                    Console.WriteLine(bonsoir + " " + nomUtilisateur);
                }
            }
        

            /* switch (jourLocalActuel)
             {

                 case 1:
                     {
                         if (heureActuel >= 9 && heureActuel <= 13)
                         {
                             Console.WriteLine(bonjour);
                         }
                         else if (heureActuel >= 13 && heureActuel <= 18)
                         {
                             Console.WriteLine(bonApresMidi);
                         }
                         else
                         {
                             Console.WriteLine(bonsoir + " et " + bonWeekEnd);
                         }

                     }
                     break;

                 case 2:
                     {
                         if (heureActuel >= 9 && heureActuel <= 13)
                         {
                             Console.WriteLine(bonjour);
                         }
                         else if (heureActuel >= 13 && heureActuel <= 18)
                         {
                             Console.WriteLine(bonApresMidi);
                         }
                         else
                         {
                             Console.WriteLine(bonsoir);
                         }
                     }
                     break;
                 case 3:
                     {
                         if (heureActuel >= 9 && heureActuel <= 13)
                         {
                             Console.WriteLine(bonjour);
                         }
                         else if (heureActuel >= 13 && heureActuel <= 18)
                         {
                             Console.WriteLine(bonApresMidi);
                         }
                         else
                         {
                             Console.WriteLine(bonsoir);
                         }
                     }
                     break;
                 case 4:
                     {
                         if (heureActuel >= 9 && heureActuel <= 13)
                         {
                             Console.WriteLine(bonjour);
                         }
                         else if (heureActuel >= 13 && heureActuel <= 18)
                         {
                             Console.WriteLine(bonApresMidi);
                         }
                         else
                         {
                             Console.WriteLine(bonsoir);
                         }
                     }
                     break;
                 case 5:
                     {
                         if (heureActuel >= 9 && heureActuel <= 13)
                         {
                             Console.WriteLine(bonjour);
                         }
                         else if (heureActuel >= 13 && heureActuel <= 18)
                         {
                             Console.WriteLine(bonApresMidi);
                         }
                         else
                         {
                             Console.WriteLine(bonsoir);
                         }
                         break;
                     }
             }*/

            //ajouter du code pour suspendre l’application afin que la fenêtre de console ne se ferme pas 
            Console.ReadLine();
        }
    }
}
