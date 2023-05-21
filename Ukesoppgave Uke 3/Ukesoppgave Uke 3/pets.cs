namespace Ukesoppgave_Uke_3

    {
        public class Pet
        {
            public string Name { get; private set; }
            public string Type { get; private set; }
            public int Age { get; private set; }
            public int Happiness { get; private set; }
            public int Hunger { get; private set; }
            private readonly string favoriteFood;

            public Pet(string name, string type, int age, int happiness, int hunger, string favoriteFood)
            {
                Name = name;
                Type = type;
                Age = age;
                Happiness = happiness;
                Hunger = hunger;
                this.favoriteFood = favoriteFood;
            }

            public void Eat(string food)
            {
                if (food == favoriteFood)
                {
                    Hunger += 1;
                    Console.WriteLine($"Hurra! Dette er det beste jeg vet. Tusen takk for {food}!");
                }
                else
                {
                    Hunger += 2;
                    Console.WriteLine($"Takk for {food}!");
                }
            }

            public void Play()
            {
                Happiness += 1;
            }
        }
    }