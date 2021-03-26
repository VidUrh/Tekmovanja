using System;
using System.Collections.Generic;
using System.Linq;

namespace Tekmovanje2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> sladkarije = new Dictionary<int, int>();
            string podatki = Console.ReadLine();
            string[] asdf = podatki.Split(' ');
            int vse = Convert.ToInt32(asdf[0]);
            int kradene = Convert.ToInt32(asdf[1]);
            int kompromis = Convert.ToInt32(asdf[2]);
            string[] sladkarije1 = Console.ReadLine().Split(' ');
            string[] janko = Console.ReadLine().Split(' ');
            string[] metka = Console.ReadLine().Split(' ');
            int[] najbolse = new int[kradene];

            for(int x = 1; x <= vse; x++)
            {
                sladkarije.Add(x, Convert.ToInt32(sladkarije1[x-1]));
            }

            int[] vrednosti = new int[vse];
            for(int x = 1; x <= vse; x++)
            {
                vrednosti[x-1] = sladkarije[x];
                
            }
            Array.Sort(vrednosti);
            for(int k = 0; k<kradene;k++)
            {
                najbolse[k] = vrednosti[vse - k-1];

            }
            int[] najbolsiIndexi = new int[kradene];
            for(int a = 0; a < kradene; a++)
            {
                int iskana = najbolse[a];
                for (int b = 1; b <= sladkarije.Count; b++)
                {
                    if (sladkarije[b] == iskana)
                    {
                        najbolsiIndexi[a] = b;
                    }
                }
            }
            int l = 0;
            foreach (string i in janko)
            {
                for (int c = 0; c < kradene; c++)
                {
                    if (najbolsiIndexi[c] == Convert.ToInt32(i))
                    {
                        l++;
                    }
                }
            }
            int[] startne = najbolsiIndexi;
            while (l < kompromis)
            {
                int max = 0;
                int index = -1;
                bool first = true;
                foreach(string j in janko)
                {
                    if (first)
                    {
                        continue;
                    }
                    int sladkarija = Convert.ToInt32(j);
                    if (sladkarije[sladkarija] > max)
                    {
                        max = sladkarije[sladkarija];
                        index = sladkarija;
                        
                    } 
                    
                }
                if (!najbolsiIndexi.Contains(index)|index!=-1)
                {
                    najbolsiIndexi[kradene - l - 1] = index;
                    Console.WriteLine(kradene - l - 1);
                    l++;
                }
                
                else
                {
                    Console.WriteLine(index);
                    max = 0;
                    index = -1;
                    metka.Where(val => val != Convert.ToString(index)).ToArray();


                }

            }
            
            l = 0;
            while (l < kompromis)
            {
                int max = 0;
                int index = 0;
                bool first = true;
                foreach (string m in metka)
                {
                    if (first)
                    {
                        continue;
                    }
                    int sladkarija = Convert.ToInt32(m);
                    if (sladkarije[sladkarija] > max)
                    {
                        max = sladkarije[sladkarija];
                        index = sladkarija;
                    }

                }

                if (startne.Contains(index) | !najbolsiIndexi.Contains(index)|index!=0) 
                {
                    najbolsiIndexi[kradene - l - 1] = index;
                    Console.WriteLine(kradene - l - 1);
                    l++; 
                }
                else
                {
                    Console.WriteLine(index);
                    max = 0;
                    metka.Where(val => val != Convert.ToString(index)).ToArray();
                    

                }

            }
            int sum = 0;
            foreach(int al in najbolsiIndexi)
            {
                sum += sladkarije[al];
                Console.WriteLine(sum);
            }
            
        }
        
    }
}
