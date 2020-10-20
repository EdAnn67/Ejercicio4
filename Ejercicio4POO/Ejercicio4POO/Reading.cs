using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4POO
{
    class Reading
    {
        public int n;
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public int k;
        public int K
        {
            get { return k; }
            set { k = value; }
        }
        int[] lightlev = new int[24]; // Light Levels
        public int[] LightLev
        {
            get { return lightlev; }
            set { lightlev = value; }
        }
        public int[] LightLev2 { get; set; }
        public string stringll; // String Light Levels
        public string StringLL
        {
            get { return stringll; }
            set { stringll = value; }
        }


        public void getLL()
        {
            int x = 0;
            string chain = "";
            for (int i = 0; i < StringLL.Length; i++)
            {
                if(StringLL[i] != ' ')
                {
                    chain += StringLL[i];
                }
                else
                {
                    LightLev[x] = int.Parse(chain);
                    chain = "";
                    x++;
                }
                if(i == StringLL.Length - 1)
                {
                    LightLev[x] = int.Parse(chain);
                    chain = "";
                    x++;
                }
            }
        }


        public void ReadingHours(int s, int l)
        {
            int index = 0;
            int[] indexes = new int[s];
            LightLev2 = LightLev;
            Console.WriteLine();
            Array.Sort(LightLev2);
            Array.Reverse(LightLev2);

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < LightLev.Length; j++)
                {
                    if(LightLev2[s-1] == LightLev[j])
                    {
                        index = j + 1; 
                    }
                }
            }
            


            Array.Sort(indexes);
            Console.WriteLine("The reading hour with minor Light index is: {0} with {1}% of light", index, LightLev2[s - 1]);
            Console.Write("Reading hours: ");
            int b = 0;
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < LightLev.Length; j++)
                {
                    if (LightLev2[i] == LightLev[j])
                    {
                        Console.Write((j + 1) + " ");
                    }
                }
                Console.Write("Porcentaje de luz: " + LightLev2[i] + "  ");
            }
        }
    }
}
