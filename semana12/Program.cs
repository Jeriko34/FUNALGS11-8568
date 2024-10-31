void imprime(int[] lis)
{
    foreach (int i in lis)
    {
        Console.WriteLine(i);
    }
}
int[] lista = { 5, 6, 8, 9 };

imprime(lista);

Console.WriteLine("Ingrese nuevo numero");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese posición donde insertar");
int p = int.Parse(Console.ReadLine()) - 1;

Array.Resize(ref lista, lista.Length + 1);
for (int x = lista.Length - 1; x >= 0; x--)
{
    lista[x] = lista[x - 1];
}

lista[p] = n;

