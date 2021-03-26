using System;
using System.Collections.Generic;

namespace RTK_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> rojstnidnevi = new Dictionary<int, int>();
            List<int> podatki = new List<int>();
            List<int> oddajo = new List<int>();
            List<int> prejmejo = new List<int>();
            List<Tuple<int,int>> obdarovanja = new List<Tuple<int,int>>();
            
            string[] podatki1;
            int stevilo;
            stevilo = Convert.ToInt32(Console.In.ReadLine());
            for (int x = 1; x <= stevilo; x++)
            {
                podatki.Clear();
                oddajo.Clear();
                prejmejo.Clear();
                rojstnidnevi.Clear();
                obdarovanja.Clear();

                Console.ReadLine();
                podatki1 = Console.ReadLine().Split(' ');
                foreach (string podatek in podatki1)
                {
                    podatki.Add(Convert.ToInt32(podatek));
                }
                for (int a = 1; a <= podatki[1]; a++)
                {
                    rojstnidnevi.Add(a, Convert.ToInt32(Console.ReadLine()));
                }
                for (int a = 0; a < podatki[2]; a++)
                {
                    string[] obdarovanje = Console.ReadLine().Split(' ');
                    obdarovanja.Add(new Tuple<int, int>(Convert.ToInt32(obdarovanje[0]), Convert.ToInt32(obdarovanje[1])));
                    oddajo.Add(Convert.ToInt32(obdarovanje[0]));
                    prejmejo.Add(Convert.ToInt32(obdarovanje[1]));
                }
                bool breaked = false;
                foreach (int oddana in oddajo)
                {
                    try
                    {
                        if (prejmejo.Remove(oddana))
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Pijanci so med nami!");
                            breaked = true;
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Pijanci so med nami!");
                        breaked = true;
                        break;
                    }

                }
                if (breaked) {
                    continue; 
                }



                int buteljke = 0;
                foreach(Tuple<int,int> obd in obdarovanja)
                {
                    if(rojstnidnevi[obd.Item1] > rojstnidnevi[obd.Item2])
                    {
                        buteljke++;
                    }
                }
                Console.WriteLine(buteljke);
            }           
        }
    }
}
