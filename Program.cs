Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}!");
Console.Write("Digite o ano do seu nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year; //+, - ,* ,/
Console.WriteLine($"Você tem {age} anos");

if(age >= 18 || name =="Fredi") // "||" significa "ou"
{
    Console.WriteLine("Você é maior de idade"); // "if" seria um "E se"
}
else
 {
    Console.WriteLine("Você é menor de idade"); // "else" seria um "E se não", mas neste caso também poderia ser usado "if" no lugar de "else
 }