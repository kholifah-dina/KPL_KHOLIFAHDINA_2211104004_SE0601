using System;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int input1, int input2)
        {
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }

        public int KPK(int input1, int input2)
        {
            return (input1 * input2) / FPB(input1, input2);
        }

        public string Turunan(int[] persamaan)
        {
            if (persamaan.Length <= 1) return "0";

            string result = "";
            int pangkat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i] * pangkat;
                if (koef == 0)
                {
                    pangkat--;
                    continue;
                }

                string tanda = koef > 0 && result != "" ? " + " : (koef < 0 ? " - " : "");
                int absKoef = Math.Abs(koef);
                string term = (absKoef == 1 && pangkat != 0) ? "" : absKoef.ToString();
                string variabel = pangkat == 0 ? "" : (pangkat == 1 ? "x" : $"x{pangkat}");

                result += $"{tanda}{term}{variabel}";
                pangkat--;
            }

            return result.Trim();
        }

        public string Integral(int[] persamaan)
        {
            string result = "";
            int pangkat = persamaan.Length;

            for (int i = 0; i < persamaan.Length; i++)
            {
                int newPangkat = pangkat - i;
                double koef = (double)persamaan[i] / newPangkat;

                string tanda = koef > 0 && result != "" ? " + " : (koef < 0 ? " - " : "");
                double absKoef = Math.Abs(koef);
                string koefStr = absKoef == 1 ? "" : absKoef.ToString("G");

                string variabel = newPangkat == 1 ? "x" : $"x{newPangkat}";
                result += $"{tanda}{koefStr}{variabel}";
            }

            result += " + C";
            return result.Trim();
        }
    }
}
