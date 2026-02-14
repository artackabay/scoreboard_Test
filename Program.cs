using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Scoreboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
        
            Console.Write("Oyuncu sayisini giriniz : ");
            int playerCount = int.Parse(Console.ReadLine());
            Console.WriteLine(" _________________________________");
            Console.WriteLine("");
            string[] players = new string[playerCount];
            

                for (int i = 0; i < playerCount; i++)
                {

                    Console.Write((i + 1) + ". Oyuncu için isim giriniz: ");
                    players[i] = Console.ReadLine();


                }
            
            
            int[] scores = new int[playerCount];
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
        point_one:
            Console.WriteLine("");
        point_two:
            Console.WriteLine("Ceza yiyen var mı?");
            Console.WriteLine("           1. Evet                   2. Hayır");
            Console.WriteLine("                ");
            int penaltyState = int.Parse(Console.ReadLine());
            if (penaltyState == 1) 
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("  ");
               
                
                    Console.WriteLine("");
                    Console.Write("Ceza yiyen kişinin oyuncu sırasını giriniz:  ");
                    int penalized = (int.Parse(Console.ReadLine()) - 1);
                    Console.WriteLine("");
                    Console.Write(players[penalized] + " - kişisine uygulanacak ceza sayısını giriniz: ");
                    scores[penalized] = scores[penalized] + (int.Parse(Console.ReadLine())*101 );
                    Console.WriteLine("---------------------------------------");

                goto point_two;

            }
            

                Console.WriteLine("                           " + (round) + ". El Skorlarını Giriniz");
            round++;
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("");
                Console.Write(players[i] + " oyuncusu için skor giriniz: ");
                scores[i] = scores[i] + int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-------------------------------------------------");

            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("");
                Console.Write( (i+1)+ ". " + players[i] + " : " + scores[i] );
                Console.WriteLine("");
                
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");

            if (round == 10) 
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("                                        Oyunun Bitmesine Son 2 El");
                Console.WriteLine("------------------------------------------------------------------------------------------");

            }
            if (round< 12) 
            { goto point_one; }
            else
            {
                Console.WriteLine("        Oyun bitti! Son durum şu şekilde;         ");
                Console.WriteLine("");
                for (int i = 0; i < players.Length; i++)
                {
                    Console.Write(players[i] + " : " + scores[i] + "|");

                }
            }

            for (int i = 0; i < players.Length; i++)
                {
                    Console.Write("|  " + players[i] + " : " + scores[i] );
                Console.WriteLine("");
                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

            }


        }
    }
}
