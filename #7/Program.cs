// Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

using System.Linq.Expressions;

Console.Write("Cate numere are vectorul? n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = GetVectorElements(n);
PrintArr(vector);

vector = ReverseVector(vector);
PrintReversedArr(vector);

static int[] GetVectorElements(int n)
{
    int[] arr = new int[n];

    int i = 1;
    while (i < n) {
        arr[i] = i;
        i++;
    }
    return arr;
}
static void PrintArr(int[] arr)
{
    Console.WriteLine("\nVectorul este: ");
    foreach(int element in arr) {
        Console.Write(element + " ");
    }
}
static void PrintReversedArr(int[] arr)
{
    Console.WriteLine("\nVectorul inversat este: ");
    foreach(int element in arr) {
        Console.Write(element + " ");
    }
}
static int[] ReverseVector(int[] vector)
{
    int n = vector.Length;
    int[] secondVector = new int[n];

    int cnt = n - 1;
    for (int i = 0; i < n; i++) {
        secondVector[i] = vector[cnt];
        cnt = cnt - 1;

    }
    for (int i = 0; i < n; i++) {
        vector[i] = secondVector[i];
    }
    return vector;
}