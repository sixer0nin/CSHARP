
int heroHp = 10;
int monsterHp = 10;

Random random = new Random();
int attack = random.Next(1, 11);

do
{


    attack = random.Next(1, 11);
    int heroAttack = attack;
    monsterHp -= heroAttack;

    System.Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHp} health.");
     
     if (monsterHp <=0 || heroHp <= 0) continue;// added || heroHp <= 0

    attack = random.Next(1, 11);
    int monsterAttack = attack;
    heroHp -= monsterAttack;

    System.Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHp} health.");

} while ((heroHp >= 1) && (monsterHp >= 1));

    System.Console.WriteLine(heroHp > monsterHp ? "Hero wins" : "Monster win!");




