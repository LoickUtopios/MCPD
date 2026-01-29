
using Exercice11.Classes;
using Exercice11.Enum;

Travailleur t = new Travailleur("Toto", "Titi", "012345679", "test@test.com", "TestFactory", "TestLand", "9876543210");
Scientifique s = new Scientifique("Toto", "Titi", "012345679", "test@test.com", "TestFactory", "TestLand", "9876543210", TypeEnum.EXPERIMENTAL, DisciplineEnum.MATHEMATIQUE);

Console.WriteLine(t);
Console.WriteLine(s);