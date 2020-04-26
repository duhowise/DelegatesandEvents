using System;

namespace SimpleEvents {
    class Program {
        static void Main (string[] args) {
            var cat = new Cat {
                Id = 1,
                Name = "some cat",
                Health = 200
            };
            cat.OnHealthChanged += CatOnHealthChanged;
            cat.OnHealthChanged += CatIsDead;

            for (int i = 0; i < 10; i++)
            {
                cat.Health-=20;
            }

        }

        private static void CatIsDead (object sender, int e) {
            var cat = (Cat) sender;
            if (cat.Health <= 0) {
                System.Console.WriteLine ($"{cat.Name} is no longer alive");
            }
        }

        private static void CatOnHealthChanged (object sender, int e) {
            var cat = (Cat) sender;
            System.Console.WriteLine ($"{cat.Name} has {e} health");
        }
    }
}