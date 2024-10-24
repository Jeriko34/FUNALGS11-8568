int[] numero = new int [1];
Random n = new Random();

Console.WriteLine("Ingrese la cantidad de valores que gustes");
int num= int.Parse(Console.ReadLine());

for (int x = 0; x > num; num++)
{
    numero[x] = n.Next(50, 90); 
}
Console.WriteLine("¿Le gusta los números pares o impares? (p/i)");
string tipo = Console.ReadLine();

if (numero )
