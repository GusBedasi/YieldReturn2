using System.Collections.Generic;

namespace YieldReturn2
{
    public static class HeroGenerator
    {
        public static List<Hero> GenerateMany(int numberOfHeros)
        {
            var heroes = new List<Hero>();

            for (var i = 0; i <= numberOfHeros; i++)
            {
                heroes.Add(new Hero() { Id = i, Name = $"Name {i}" });
            }

            return heroes;
        }

        public static IEnumerable<Hero> GenerateManyImproved(int numberOfHeroes)
        {
            for (var i = 0; i <= numberOfHeroes; i++)
            {
                yield return new Hero() { Id = i, Name = $"Name {i}" };
            }
        }
    }
}