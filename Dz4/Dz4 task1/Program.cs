using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Dz4_task1
{


   public class Program
    {
      
        
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
        public class BenchmarkClass
        {
            [Benchmark]
            public void testHashSetFound()
            {

                HashSet<String> foundStr = new HashSet<string>();

                for (int i = 0; i < 10000; i++)
                {
                    Random rand = new Random();
                    string value = Convert.ToString(rand.Next());
                    foundStr.Add(value);
                }

                foundStr.Contains("Hello word");

            }
            [Benchmark]
            public void testArrayFound()
            {
                string valueA = "12324214";
                string[] arrayFound = new string[10000];
                for (int i = 0; i < arrayFound.Length; i++)
                {
                    Random rand = new Random();
                    string value = Convert.ToString(rand.Next());
                    
                }

                foreach (string values in arrayFound)
                {
                    if(valueA == values)
                    {
                        break;
                    }


                }

            }

        }
    }
}
