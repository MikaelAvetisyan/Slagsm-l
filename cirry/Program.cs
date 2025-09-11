using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Threading;

Console.WriteLine("Enter name to play");

string name;
name = Console.ReadLine();
string paths;
int Hp = 120;
int EnemyHp = 100;
int EnemyHp2 = 100;
int EnemyHuge = 200;
int EnemyWiz = 80;

Console.WriteLine($"{name}, You entered a cave because you need some xp.");
    Console.WriteLine("You have 3 paths to take. Which one do you take?");
        Console.WriteLine("Path 1");
        Console.WriteLine("Path 2");
        Console.WriteLine("Path 3");
        Console.WriteLine();

paths = Console.ReadLine().Trim().ToUpper();


if (paths == "PATH 1" || paths == "1")
{
    Console.WriteLine("This path is very narrow, but you still got through it with ease, now you stumbled across 2 skeletons; they seemed ready to fight, so you took your stance");

    while (Hp > 0 && (EnemyHp > 0 || EnemyHp2 > 0))
    {
        Console.WriteLine();
        Console.WriteLine("----- Choose your action -----");
        Console.WriteLine("Attack = Simple attack");
        Console.WriteLine("Healing potion = 50% heal, 50% damage");
        Console.WriteLine("Parry = 75% damage resistance");
        Console.WriteLine("Run = try to escape");
        Console.WriteLine();

        string choise = Console.ReadLine().Trim().ToUpper();

        if (choise == "ATTACK")
        {
            Console.WriteLine("Light attack = normal attack");
            Console.WriteLine("heavy attack = You do extra damage but give a chanse for opponents to do more damage");
            String AttackType = Console.ReadLine().Trim().ToUpper();
            if (AttackType == "LIGHT ATTACK" || AttackType == "LIGHT")
            {
                Console.WriteLine();
                Console.WriteLine("Light attack!");
                Console.WriteLine("Both skeletons took -20 hp, because of the attack The skeletons were very hurt, but they still attacked, but it was weaker, -10 hp");
                Console.WriteLine();
                EnemyHp -= 20;
                EnemyHp2 -= 20;
                Hp -= 10;
            }

            else if (AttackType == "HEAVY ATTACK" || AttackType == "HEAVY")
            {
                Console.WriteLine("Heavy attack!");
                Random r = new Random();
                int ra = r.Next(1, 3);

                if (ra == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("You did huge damage and they got concussion");
                    Console.WriteLine("40 damage to both skeletons");
                    Console.WriteLine();
                    EnemyHp -= 40;
                    EnemyHp2 -= 40;
                }

                else if (ra == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("You did huge damage but left a window for the skeletons to attack back");
                    Console.WriteLine("40 damage to both skeletons, 30 damage to you");
                    Console.WriteLine();
                    EnemyHp -= 40;
                    EnemyHp2 -= 40;
                    Hp -= 30;
                }

            }
        }

        else if (choise == "HEALING POTION")
        {
            Random random = new Random();
            int number = random.Next(1, 5);

            if (number == 1)
            {
                Console.WriteLine();
                Console.WriteLine("The potion healed you for +20 hp");
                Console.WriteLine();
                Hp += 20;
            }

            else if (number == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Lucky you, the potion healed you big, +40 hp");
                Console.WriteLine();
                Hp += 40;
            }

            else if (number == 3)
            {
                Console.WriteLine();
                Console.WriteLine("The potion damaged you by -20 hp");
                Console.WriteLine();
                Hp -= 20;
            }

            else if (number == 4)
            {
                Console.WriteLine();
                Console.WriteLine("The potion damaged you big by -40 hp");
                Console.WriteLine();
                Hp -= 40;
            }
        }

        else if (choise == "PARRY")
        {
            Console.WriteLine();
            Console.WriteLine("You parried, reduced damage");
            Console.WriteLine();
            Hp -= 8;
        }

        else if (choise == "RUN")
        {
            Console.WriteLine();
            Console.WriteLine("You ran, but the entrance was blocked off somehow, so the skeletons caught up and hit you");
            Console.WriteLine("Skeletons damaged you for 40");
            Console.WriteLine();
            Hp -= 20;
        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("Emmm..... No, try again");
        }

        if (Hp <= 0)
        {
            Console.WriteLine();
            Console.WriteLine("You Lose! Your health dropped to zero.");
            Console.ReadLine();
            break;
        }

        else if (EnemyHp <= 0 && EnemyHp2 <= 0)
        {
            Console.WriteLine();
            Console.WriteLine("You Win! All skeletons defeated.");
            Console.ReadLine();
            break;
        }

    }

}

else if (paths == "PATH 2" || paths == "2")
{

    Console.WriteLine("You went through path 2, the cave entrance was really big, but you really didn't think about it");

    while (Hp > 0 && (EnemyHuge > 0))
    {
        Console.WriteLine();
        Console.WriteLine("----- Choose your action -----");
        Console.WriteLine("Attack = Simple attack");
        Console.WriteLine("Healing potion = 50% heal, 50% damage");
        Console.WriteLine("Parry = 75% damage resistance");
        Console.WriteLine("Run = try to escape");
        Console.WriteLine();

        string choise1 = Console.ReadLine().Trim().ToUpper();

        if (choise1 == "ATTACK")
        {
            Console.WriteLine("Light attack = normal attack or heavy attack = gives chanse for skeletons to do more damage");
            String AttackType = Console.ReadLine().Trim().ToUpper();
            if (AttackType == "LIGHT ATTACK" || AttackType == "LIGHT")
            {
                Console.WriteLine();
                Console.WriteLine("Light attack!");
                Console.WriteLine("The huge skeleton took -20 hp, reduced damaged taken -10");
                Console.WriteLine();
                EnemyHuge -= 20;
                Hp -= 10;
            }

            else if (AttackType == "HEAVY ATTACK" || AttackType == "HEAVY")
            {
                Console.WriteLine("Heavy attack!");
                Random r = new Random();
                int ra = r.Next(1, 3);

                if (ra == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("You did huge damage and the huge skeleton got concussion");
                    Console.WriteLine("40 damage to both skeletons");
                    Console.WriteLine();
                    EnemyHuge -= 40;
                }

                else if (ra == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("You did huge damage but left a window for the huge skeleton to attack back");
                    Console.WriteLine("40 damage to both skeletons, 30 damage to you");
                    Console.WriteLine();
                    EnemyHuge -= 40;
                    Hp -= 25;
                }

            }
        }

        else if (choise1 == "HEALING POTION")
        {
            Random random = new Random();
            int number = random.Next(1, 5);

            if (number == 1)
            {
                Console.WriteLine();
                Console.WriteLine("The potion healed you for +20 hp");
                Console.WriteLine();
                Hp += 20;
            }

            else if (number == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Lucky you, the potion healed you big, +40 hp");
                Console.WriteLine();
                Hp += 40;
            }

            else if (number == 3)
            {
                Console.WriteLine();
                Console.WriteLine("The potion damaged you by -20 hp");
                Console.WriteLine();
                Hp -= 20;
            }

            else if (number == 4)
            {
                Console.WriteLine();
                Console.WriteLine("The potion damaged you big by -40 hp");
                Console.WriteLine();
                Hp -= 40;
            }
        }

        else if (choise1 == "PARRY")
        {
            Console.WriteLine();
            Console.WriteLine("You parried, reduced damage");
            Console.WriteLine();
            Hp -= 10;
        }

        else if (choise1 == "RUN")
        {
            Console.WriteLine();
            Console.WriteLine("You ran, but the entrance was blocked off somehow, so the huge skeleton caught up and hit you");
            Console.WriteLine("Skeletons damaged you for 40");
            Console.WriteLine();
            Hp -= 20;
        }

        if (Hp <= 0)
        {
            Console.WriteLine();
            Console.WriteLine("You Lose! Your health dropped to zero.");
            Console.WriteLine();
            Console.ReadLine();
            break;
        }

        else if (EnemyHuge <= 0)
        {
            Console.WriteLine();
            Console.WriteLine("You Win! Huge skeleton defeated.");
            Console.WriteLine();
            Console.ReadLine();
            break;
        }
    }
}

else if (paths == "PATH 3" || paths == "3")
{
    Console.WriteLine("The path was normally sized. At the end of the tunnel, you stumble across a skeleton with a big stick. The stick has a big blue orb levitating on the top of the staff");

    while (Hp > 0 && (EnemyHp > 0 || EnemyHp2 > 0))
    {
        Console.WriteLine();
        Console.WriteLine("----- Choose your action -----");
        Console.WriteLine("Attack = Simple attack");
        Console.WriteLine("Healing potion = 50% heal, 50% damage");
        Console.WriteLine("Parry = 75% damage resistance");
        Console.WriteLine("Run = try to escape");
        Console.WriteLine();

        string choise = Console.ReadLine().Trim().ToUpper();

        if (choise == "ATTACK")
        {
            Console.WriteLine("Light attack = normal attack or heavy attack = gives chanse for skeletons to do more damage");
            String AttackType = Console.ReadLine().Trim().ToUpper();
            if (AttackType == "LIGHT ATTACK" || AttackType == "LIGHT")
            {
                Console.WriteLine();
                Console.WriteLine("Light attack!");
                Console.WriteLine("The wizard skeleton took -20 damage, skeleton casts fireball, -100 hp");
                Console.WriteLine();
                EnemyWiz -= 20;
                Hp -= 100;
            }

            else if (AttackType == "HEAVY ATTACK" || AttackType == "HEAVY")
            {
                Console.WriteLine();
                Console.WriteLine("Heavy attack!");
                Console.WriteLine();
                Random r = new Random();
                int ra = r.Next(1, 3);

                if (ra == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("You did huge damage and the wizard got concussion");
                    Console.WriteLine("40 damage to The wizard");
                    Console.WriteLine();
                    EnemyWiz -= 40;
                }

                else if (ra == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("You did huge damage but left a window for the skeletons to attack back");
                    Console.WriteLine("40 damage to the wizard skeletons, 100 damage to you");
                    Console.WriteLine();
                    EnemyWiz -= 40;
                    Hp -= 100;
                }

            }
        }

        else if (choise == "HEALING POTION")
        {
            Random random = new Random();
            int number = random.Next(1, 5);

            if (number == 1)
            {
                Console.WriteLine();
                Console.WriteLine("The potion healed you for +20 hp");
                Console.WriteLine();
                Hp += 20;
            }

            else if (number == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Lucky you, the potion healed you big, +40 hp");
                Console.WriteLine();
                Hp += 40;
            }

            else if (number == 3)
            {
                Console.WriteLine();
                Console.WriteLine("The potion damaged you by -20 hp");
                Console.WriteLine();
                Hp -= 20;
            }

            else if (number == 4)
            {
                Console.WriteLine();
                Console.WriteLine("The potion damaged you big by -40 hp");
                Console.WriteLine();
                Hp -= 40;
            }
        }

        else if (choise == "PARRY")
        {
            Console.WriteLine();
            Console.WriteLine("You parried, reduced damage");
            Console.WriteLine();
            Hp -= 25;
        }

        else if (choise == "RUN")
        {
            Console.WriteLine();
            Console.WriteLine("You ran, but the entrance was blocked off somehow, so the wizard skeleton cast a fireball on you");
            Console.WriteLine("Skeletons damaged you for 100");
            Console.WriteLine();
            Hp -= 100;
        }

        if (Hp <= 0)
        {
            Console.WriteLine();
            Console.WriteLine("You Lose! Your health dropped to zero.");
            Console.WriteLine();
            Console.ReadLine();
            break;
        }

        else if (EnemyWiz <= 0)
        {
            Console.WriteLine();
            Console.WriteLine("You actualy won?.");
            Console.WriteLine();
            Console.ReadLine();
            break;
        }
    }
}

else
{
    Console.WriteLine();
    Console.WriteLine("Emmm... no try again");
    Console.ReadLine();
}
