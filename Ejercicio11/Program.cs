Console.WriteLine("Ingrese la cantidad de numeros que desea:");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];
Random rnd = new Random();

for ( int x=0; x < n; x++ )
{
    numeros[x] = rnd.Next(50, 90);
}
Console.WriteLine("¿Le gusta los números pares o impares? (P/I)");
Console.WriteLine("chevere tu huev");
