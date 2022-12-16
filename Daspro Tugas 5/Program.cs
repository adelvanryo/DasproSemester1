using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome To My Adventure Game");
            Console.WriteLine("What is your name?");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi "+player.Name+", Are you ready to start? [y/n]");
            string bReady =  Console.ReadLine();
            if(bReady=="y")
            {
                Console.WriteLine(player.Name+" is entering the world...");
                Enemy enemy1 = new Enemy("Crab");
                Console.WriteLine(player.Name+" is encountering "+enemy1.Name);
                Console.WriteLine(enemy1.Name+" is attacking you..");
                Console.WriteLine("Choose your action :");
                Console.WriteLine("1. Basic Attack");
                Console.WriteLine("2. Skill Attack (Have higher power than basic attack. Every single use, will consume 1 Skillpoint..)");
                Console.WriteLine("3. Defend (You and enemy won't take damage! But you will restore your Skillpoint..)");
                Console.WriteLine("4. Run Away");

               while (!player.IsDead && !enemy1.IsDead && !player.IsRunningAway)
               {
                    string PlayerAction = Console.ReadLine();
                    switch (PlayerAction)
                    {
                       case "1":
                       Console.WriteLine(player.Name+" is doing basic attack!");
                       enemy1.GetHit(player.AttackPower);
                       player.Experience += 0.3f;
                       enemy1.Attack(enemy1.AttackPower);
                       player.GetHit(enemy1.AttackPower);
                       Console.WriteLine("Player Health : "+player.Health+" | Enemy Health : "+enemy1.Health);
                       Console.WriteLine("Choose Next action :");
                       break;
                       case "2":
                       player.Swing();
                       player.Experience += 0.9f;
                       enemy1.GetHit(player.AttackPower);
                       player.GetHit(enemy1.AttackPower);
                       Console.WriteLine("Your Skillpoint is : "+player.SkillSlot);
                       Console.WriteLine("Player Health : "+player.Health+" | Enemy Health : "+enemy1.Health);
                       Console.WriteLine("Choose Next action :");
                       break;
                       case "3":
                       player.Rest();
                       Console.WriteLine("Energy is being restored...");
                       Console.WriteLine("Your Skillpoint is : "+player.SkillSlot);
                       Console.WriteLine("Player Health : "+player.Health+" | Enemy Health : "+enemy1.Health);
                       Console.WriteLine("Choose Next action :");
                       break;
                       case "4":
                       Console.WriteLine(player.Name+" is running away...");
                       player.RunningAway();
                       break;
                    }
               }
               Console.WriteLine(player.Name+"Get "+player.Experience+" experience point..");

            }
            else
            {
                Console.WriteLine("Goodbye..");
                Console.Read();
            }
        }
    }

    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        public bool IsRunningAway { get; set; }
        Random rnd = new Random();

        public Novice()
        {
            Health = 100;
            SkillSlot =  0;
            AttackPower = 1;
            IsDead =  false;
            Experience = 0f;
            Name = "New Player";
        }

        public void Swing()
        {
            if(SkillSlot > 0)
            {
                Console.WriteLine("SWIIIING!!!!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SkillSlot--;
            }
            else
            {
                Console.WriteLine("You don't have an energy! You are silent, and enemy attacking you!");
                AttackPower = 0;
            }
            
        }

        public void GetHit(int HitValue)
        {
            Console.WriteLine(Name+" get hit by "+HitValue);
            Health = Health - HitValue;
            
            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Rest()
        {
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die()
        {
            Console.WriteLine("You are dead. Game Over");  
            IsDead = true;  
        }
        
        public void RunningAway()
        {
        IsRunningAway = true;
        }

    }

    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(String name)
        {
            Health = 50;
            Name = name;
        }

        public void Attack(int Damage)
        {
            AttackPower = rnd.Next(1,10);
        }

        public void GetHit(int HitValue)
        {
            Console.WriteLine(Name+" get hit by "+HitValue);
            Health = Health - HitValue;
            
            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine(Name+" is dead");
            IsDead = true;   
        }
    }
}
