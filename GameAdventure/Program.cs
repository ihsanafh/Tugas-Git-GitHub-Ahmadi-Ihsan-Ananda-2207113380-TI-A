using System;

namespace GameAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To This Adventure Game");
            Console.WriteLine("Input Your Name : ");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine($"Hello!! {player.Name}, Ready To Play The Game?!?[Y/N]");
            string Answer = Console.ReadLine();
            if(Answer == "Y")
            {
                Console.WriteLine($"{player.Name} You Entering The World...");
                Enemy enemy1 = new Enemy("Butterfly");
                Console.WriteLine($"{player.Name} Is Encountering {enemy1.Name}");
                Console.WriteLine($"{enemy1.Name} Attacking You!...");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Run Away");

                while (!player.IsDead && !enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction)
                    {
                        case "1" :
                        Console.WriteLine($"{player.Name} Is Doing a Single Attack");
                        enemy1.GetHit(player.AttackPower);
                        player.Experience += 0.3f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.Write($"Player Health : {player.Health} | Enemy Health {enemy1.Health}\n");
                        break;
                        case "2" :
                        player.Swing();
                        player.Experience += 0.9f;
                        enemy1.GetHit(player.AttackPower);
                        Console.Write($"Player Health : {player.Health} | Enemy Health : {enemy1.Health}\n");
                        break;
                        case "3" :
                        player.Rest();
                        Console.WriteLine("Energy Is Being Restored...");
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        break;
                        case "4" :
                        Console.WriteLine($"{player.Name} Is Running Away...");
                        break;
                    }
                }
                Console.WriteLine($"{player.Name} Get {player.Experience} Experience Point...");
            }
            else 
            {
                Console.WriteLine("Good Bye...");
                Console.Read();
            }
        }
    }
    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Skillslot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();

        public Novice()
        {
            Health = 100;
            Skillslot = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
        }

        public void Swing()
        {
            if(Skillslot > 0)
            {
                Console.WriteLine("SWINGG!!!");
                AttackPower = AttackPower + rnd.Next(3, 11);
                Skillslot--;
            }
            else
            {
                Console.WriteLine("You Don't Have Any Energy!!");
            }
        }

        public void GetHit(int hitValue)
        {
            Console.WriteLine($"{Name}  Get Hit By {hitValue}");
            Health = Health - hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Rest()
        {
            Console.WriteLine($"{Name} Is Resting...");
            Skillslot = 3;
            AttackPower = 1;
        }

        public void Die()
        {
            Console.WriteLine("You Are Dead, Game Over!!!");
            IsDead = true;
        }
    }
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Health = 50;
            Name = name;
        }

        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1, 10);
        }

        public void GetHit(int hitValue)
        {
            Console.WriteLine($"{Name} Get Hit By {hitValue}");
            Health = Health - hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine($"{Name} Has Dead!!");
            IsDead = true;
        }
    }
}
//Nama   : Ahmadi Ihsan Ananda
//NIM    : 2207113380
//Matkul : Dasar Pemograman
//Prodi  : Teknik Informatika - A
//Tugas  : Project Game Adventure