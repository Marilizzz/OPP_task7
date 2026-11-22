using InterfacesDemo.Classes;
using InterfacesDemo.Interfaces;

// 01
IAnimal[] animals =
{
    new Dog(),
    new Cat()
};

foreach (var animal in animals)
{
    animal.Speak();
}

// 02
Warrior warrior = new Warrior
{
    Name = "Aragorn",
    Health = 100,
    AttackPower = 25
};

warrior.Attack();
warrior.Defend();
warrior.TakeDamage(10);

// 03
ICombatant[] fighters =
{
    new Warrior { Name = "Aragorn", Health = 100, AttackPower = 25 },
    new Mage { Name = "Merlin", Health = 80, AttackPower = 40 }
};

foreach (var fighter in fighters)
{
    fighter.Attack();
    fighter.Defend();
}

// 04
Mage mage = fighters[1] as Mage;
mage.Heal(30);

// 05
Knight knight = new Knight();

IAttack attack = knight;
attack.Attack();

IDefend defend = knight;
defend.Attack();