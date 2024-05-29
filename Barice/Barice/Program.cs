using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barice
{
    internal class Program
    {
        // 1 - zid, 0 - prazno
        static void Main(string[] args)
        {
            int[,] primerA = {
                {1, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 1, 0, 0, 0, 1},
                {1, 0, 0, 1, 1, 0, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1}
            };

            int[,] primerB = {
                {1, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 1, 0, 0, 0, 1},
                {1, 0, 1, 1, 0, 0, 1, 1},
                {1, 1, 1, 1, 0, 0, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1}
            };

            Console.WriteLine("Primer A: " + IzracunajZapreminu(primerA));
            Console.WriteLine("Primer B: " + IzracunajZapreminu(primerB));

            Console.WriteLine("\nPritisni bilo koji taster za gasenje programa...");
            Console.ReadKey();
        }

        public static int IzracunajZapreminu(int[,] primer)
        {
            int redovi = primer.GetLength(0);
            int kolone = primer.GetLength(1);
            int zapremina = 0;

            int maksDubina = ProveriIvice(primer);

            // Popunjava od dole ka gore
            for (int i = redovi-1; i >= redovi-maksDubina-1; i--)
            {
                for (int j = 0; j < kolone; j++)
                {
                    if (primer[i, j] == 0)
                    {
                        zapremina += 1;
                    }
                }
            }

            return zapremina;
        }

        public static int ProveriIvice(int[,] primer)
        {
            int redovi = primer.GetLength(0);
            int kolone = primer.GetLength(1);
            int ivice = -1;

            // Ide od dole ka gore, proverava da li su obe ivice 1
            for (int i = redovi - 1; i >=0; i--)
            {
                if (primer[i, 0] == 1 && primer[i, kolone-1] == 1)
                {
                    ivice++;
                }
                else
                {
                    break;
                }
            }

            return ivice;
        }
    }
}
