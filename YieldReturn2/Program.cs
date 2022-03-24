using System;
using System.Collections.Generic;
using BenchmarkDotNet.Running;

namespace YieldReturn2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<HeroGeneratorBenchMarkr>();
        }

        private static void HeroApresentation(IEnumerable<Hero> heroes)
        {
            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Id}: {hero.Name}");
            }
        }
    }
}
