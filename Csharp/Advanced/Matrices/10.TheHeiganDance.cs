using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices
{
    public partial class Matrices
    {
        public static class _10TheHeiganDance
        {
            public static void Solution()
            {
                double damagePerTurn = double.Parse(Console.ReadLine());

                var player = new Player();
                var heigan = new Heigan();

                var chamberDimension = 15;
                var chamber = new char[chamberDimension][];

                for (int row = 0; row < chamberDimension; row++)
                {
                    chamber[row] = new char[chamberDimension];
                    for (int col = 0; col < chamberDimension; col++)
                    {
                        chamber[row][col] = '.';
                    }
                }

                chamber[player.Position.X][player.Position.Y] = 'P';

                while (player.Alive && heigan.Alive)
                {
                    // player takes poison damage if there is one
                    player.Debuff();

                    player.Hit(heigan, damagePerTurn);

                    var spell = ReadSpellInput(Console.ReadLine());

                    heigan.CastSpell(spell, chamber);

                    //Console.WriteLine("Line");
                    //foreach (var line in chamber)
                    //{
                    //    Console.WriteLine(string.Join(" ", line));
                    //}

                    if (chamber[player.Position.X][player.Position.Y] == 'S')
                    {
                        if (!player.Dodge(chamber))
                        {
                            player.TakeDamage(spell.Damage);
                            spell.Debuff();

                            if (spell.Duration >= 1)
                                player.TakeDebuff(spell);
                        }
                    }

                    ClearSpell(chamber, spell);
                    chamber[player.Position.X][player.Position.Y] = 'P';
                }

                //Console.WriteLine("Line");
                //foreach (var line in chamber)
                //{
                //    Console.WriteLine(string.Join(" ", line));
                //}

                Console.WriteLine($"Heigan: {(heigan.Alive ? heigan.Health.ToString("F2") : "Defeated!")}");

                var killedBy = String.Join(" ",
                    Regex.Split(
                        heigan.LastSpell().Type.ToString(),
                        "(?=[A-Z])"));

                Console.WriteLine($"Player: {(player.Alive ? player.Health.ToString() : $"Killed by{killedBy}")}");

                Console.WriteLine($"Final position: {player.Position.X}, {player.Position.Y}");
            }

            private static Spell ReadSpellInput(string input)
            {
                var args = input.Trim().Split();

                var spellType = args[0] == "Eruption" ? Spells.Eruption : Spells.PlagueCloud;
                var spellDamage = args[0] == "Eruption" ? 6000 : 3500;
                var spellDuration = args[0] == "Eruption" ? 1 : 2;
                var spellY = int.Parse(args[1]);
                var spellX = int.Parse(args[2]);

                return new Spell(spellType, spellDamage, new Position(spellY, spellX), spellDuration);
            }

            private static void ClearSpell(char[][] matrix, Spell spell)
            {
                for (int row = spell.EffectArea.X - 1; row <= spell.EffectArea.X + 1; row++)
                {
                    for (int col = spell.EffectArea.Y - 1; col <= spell.EffectArea.Y + 1; col++)
                    {
                        if (IsInRange(matrix, row, col) && matrix[row][col] == 'S')
                            matrix[row][col] = '.';
                    }
                }
            }

            private enum Spells
            {
                PlagueCloud = 0,
                Eruption = 1
            }

            private class Spell
            {
                public Spells Type { get; private set; }
                public double Damage { get; private set; }
                public bool IsDebuff { get; private set; }
                public int Duration { get; private set; }
                public Position EffectArea { get; private set; }

                public Spell(Spells type, double damage, Position effectArea)
                {
                    this.Type = type;
                    this.Damage = damage;
                    this.EffectArea = effectArea;
                    this.IsDebuff = false;
                }

                public Spell(Spells type, double damage,
                    Position effectArea, int duration)
                    :
                    this(type, damage, effectArea)
                {
                    this.IsDebuff = true;
                    this.Duration = duration;
                }

                public void Debuff()
                {
                    this.Duration--;
                }
            }

            private class Heigan
            {
                private double _health;
                private Stack<Spell> _castSpells;

                public double Health
                {
                    get { return _health; }
                    private set
                    {
                        this._health = value;

                        if (this._health <= 0)
                        {
                            this._health = 0;
                            this.Alive = false;
                        }
                    }
                }

                public bool Alive { get; private set; }

                public Heigan()
                {
                    this.Health = 3000000;
                    this.Alive = true;
                    this._castSpells = new Stack<Spell>();
                }

                public void Hit(Player player, double amount)
                {
                    player.TakeDamage(amount);
                }

                public void TakeDamage(double amount)
                {
                    this.Health -= amount;
                }

                public void CastSpell(Spell spell, char[][] matrix)
                {
                    this._castSpells.Push(spell);

                    for (int row = spell.EffectArea.X - 1; row <= spell.EffectArea.X + 1; row++)
                    {
                        for (int col = spell.EffectArea.Y - 1; col <= spell.EffectArea.Y + 1; col++)
                        {
                            if (IsInRange(matrix, row, col))
                                matrix[row][col] = 'S';
                        }
                    }
                }

                public Spell LastSpell()
                {
                    return this._castSpells.Peek();
                }
            }

            private struct Position
            {
                public Position(int x, int y)
                {
                    X = x;
                    Y = y;
                }

                public int X { get; set; }
                public int Y { get; set; }
            }

            private class Player
            {
                public double Health
                {
                    get { return _health; }
                    private set
                    {

                        this._health = value;

                        if (this._health <= 0)
                        {
                            this._health = 0;
                            this.Alive = false;
                        }
                    }
                }

                public bool Alive { get; private set; }
                public Position Position { get; private set; }

                private LinkedList<Spell> Debuffs;
                private double _health;

                public Player()
                {
                    this.Health = 18500;
                    this.Alive = true;
                    this.Debuffs = new LinkedList<Spell>();
                    this.Position = new Position(15 / 2, 15 / 2);
                }

                public void Hit(Heigan monster, double amount)
                {
                    monster.TakeDamage(amount);
                }

                public void TakeDamage(double amount)
                {
                    this.Health -= amount;
                }

                public void TakeDebuff(Spell debuff)
                {
                    Debuffs.AddFirst(debuff);
                }

                public void Debuff()
                {
                    var toRemove = new List<Spell>();
                    foreach (var debuff in this.Debuffs)
                    {
                        this.TakeDamage(debuff.Damage);
                        debuff.Debuff();

                        if (debuff.Duration < 1)
                            toRemove.Add(debuff);
                    }

                    foreach (var debuff in toRemove)
                        this.Debuffs.Remove(debuff);
                }

                public bool Dodge(char[][] matrix)
                {
                    var row = this.Position.X;
                    var col = this.Position.Y;

                    // try dodging up
                    row--;
                    if (IsInRange(matrix, row, col) && matrix[row][col] == '.')
                    {
                        this.Position = new Position(row, col);
                        matrix[row][col] = 'P';
                        return true;
                    }
                    row++;

                    // try dodging right
                    col++;
                    if (IsInRange(matrix, row, col) && matrix[row][col] == '.')
                    {
                        this.Position = new Position(row, col);
                        matrix[row][col] = 'P';
                        return true;
                    }
                    col--;

                    // try dodging down
                    row++;
                    if (IsInRange(matrix, row, col) && matrix[row][col] == '.')
                    {
                        this.Position = new Position(row, col);
                        matrix[row][col] = 'P';
                        return true;
                    }
                    row--;

                    // try dodging left
                    col--;
                    if (IsInRange(matrix, row, col) && matrix[row][col] == '.')
                    {
                        this.Position = new Position(row, col);
                        matrix[row][col] = 'P';
                        return true;
                    }

                    return false;
                }
            }

            private static bool IsInRange<T>(T[][] matrix, int row, int col)
            {
                return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
            }
        }
    }
}
