// Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.

using System.Runtime.CompilerServices;

Console.WriteLine("Cate elemente are vectorul?");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = new int[n];
GetVectorElements(n, vector);

vector = RotateVector(vector);
PrintArr(vector);

static void GetVectorElements(int n, int[] vector)
{
    int i = 0;
    while (i < n)
    {
        Console.WriteLine($"Care este elementul aflat pe pozitia {i} al vectorului?");
        vector[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
}
static void PrintArr(int[] arr)
{
    Console.WriteLine("Elementele vectorului rotite sunt: ");
    foreach (int element in arr)
    {
        Console.Write(element + " ");
    }
}
static int[] RotateVector(int[] vector)
{
    int n = vector.Length;
    int[] secondVector = new int[n];

    int cnt = 0;
    for (int i = 1; i < n; i++) {
        secondVector[cnt] = vector[i];
        if (i == n - 1) {
            secondVector[i] = vector[0];
        }
        cnt++;
    }

    for (int i = 0; i < n; i++) {
        vector[i] = secondVector[i];
    }

    return vector;
}