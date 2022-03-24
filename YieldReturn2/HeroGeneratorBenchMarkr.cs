using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace YieldReturn2
{
    [MemoryDiagnoser]
    public class HeroGeneratorBenchMarkr
    {
        [Benchmark]
        public void HeroApresentation()
        {
            var heroesList1 = HeroGenerator.GenerateMany(1_000);
            foreach (var hero in heroesList1)
            {
                if (hero.Id < 500)
                    Console.WriteLine($"{hero.Id}: {hero.Name}");
                else
                    break;
            }
        }
        
        public static List<Hero> GenerateMany(int numberOfHeros)
        {
            var heroes = new List<Hero>();

            for (var i = 0; i < numberOfHeros; i++)
            {
                heroes.Add(new Hero() { Id = i, Name = $"Name {i}" });
            }

            return heroes;
        }
        
        [Benchmark]
        public void HeroApresentationYieldApproach()
        {
            var heroesList1 = HeroGenerator.GenerateManyImproved(
                1_000);
            
            foreach (var hero in heroesList1)
            {
                if (hero.Id < 500)
                    Console.WriteLine($"{hero.Id}: {hero.Name}");
                else
                    break;
            }
        }
        
        public static IEnumerable<Hero> GenerateManyImproved(int numberOfHeroes)
        {
            for (var i = 0; i < numberOfHeroes; i++)
            {
                yield return new Hero() { Id = i, Name = $"Name {i}" };
            }
        }
    }
}