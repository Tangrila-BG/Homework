namespace Csharp.OOP.Basics.DefiningClasses._11.PokemonTrainer
{
    public static partial class _11PokemonTrainer
    {
        private class Pokemon
        {
            private string _name;
            private string _element;
            private int _health;

            public Pokemon(string name, string element, int health)
            {
                _name = name;
                _element = element;
                _health = health;
            }

            public string Element
            {
                get { return _element; }
                set { _element = value; }
            }

            public int Health
            {
                get { return _health; }
                set { _health = value; }
            }

            public void TakeDamage()
            {
                _health -= 10;
            }
        }
    }

}
