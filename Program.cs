// See https://aka.ms/new-console-template for more information
using ProjetoRPG.src.Entities;

//Criando os objetos:
Knight knight = new Knight("Arus", 23, "Knight", "Sword", 5);
Wizard whiteWizard = new Wizard("Jennica", 23, "White Wizard", "magic", 6);
Wizard blackWizard = new Wizard("Topapa", 25, "Black Wizard", "magic", 3);
Ninja ninja = new Ninja ("Wedge", 31, "Ninja", "kunai", 10);

//Características dos personagens:
Console.WriteLine(knight);
Console.WriteLine(whiteWizard);
Console.WriteLine(blackWizard);
Console.WriteLine(ninja);

//Ataques:
Console.WriteLine(knight.Attack(7));
Console.WriteLine(whiteWizard.Attack(2));
Console.WriteLine(blackWizard.Attack(9));
Console.WriteLine(ninja.Attack(9));

//Corrida:
Console.WriteLine(knight.Run());
Console.WriteLine(whiteWizard.Run());
Console.WriteLine(blackWizard.Run());
Console.WriteLine(ninja.Run());

