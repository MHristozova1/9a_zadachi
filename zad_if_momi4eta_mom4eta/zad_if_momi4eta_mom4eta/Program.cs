using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_if_momi4eta_mom4eta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Колко сте в час?:");
            int broi=int.Parse(Console.ReadLine());
            Console.Write(" Кой часе сега?:");
            int chas = int.Parse(Console.ReadLine());
            Console.Write("Колко момичета са?:");
            int momi4eta = int.Parse(Console.ReadLine());
            // изход 1
            // всички променливи разделени с /
            Console.WriteLine(broi +"/"+ chas + "/" + momi4eta);
            //  изход 2
            // пресмятане и извеждане на момчетата
            int mom4eta = broi - momi4eta;
            Console.WriteLine(" момчетата са "+ mom4eta);
            // изход 3
             //ако момчетата са < 5 съобщение 
             //Вие сте супер герой
             // иначе - Вие сте ботове
             if(broi <5)
            {
                Console.WriteLine(" Вие сте супергерой " );

            }
             else {
                Console.WriteLine(" Вие сте бот ");
            }

        }
    }
}
