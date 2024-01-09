// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
Console.Write("Cate numere are vectorul? n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = GetVectorElements(n);
PrintArr(vector);

Console.Write("\nCate pozitii sa se roteasca vectorul? k: ");
int k = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine("\nElementele vectorului rotite sunt: ");
    vector = RotateVector(vector, k);
    PrintArr(vector);
}
catch (IndexOutOfRangeException e)
{
    throw new ArgumentOutOfRangeException(
    "Numarul k este mai mare decat lungimea vectorului.", e);
}

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
    foreach(int element in arr) {
        Console.Write(element + " ");
    }
}
// TODO de  verificat functionalitate (nu functioneaza cum trebuie)
static int[] RotateVector(int[] vector, int k)
{
    int[] secondVector = new  int[vector.Length];
    int[] thirdVector = new  int[vector.Length];
    int n = vector.Length;
    int b = 0;

    for (int i = k; i < n; i++) {
        thirdVector[b] = vector[i];
        b++;
    }
    for (int i = 0; i < k; i++) {
        secondVector[i] = vector[i];
    }
    int a = n - k;
 
    for (int i = 0; i <= a; i++) {
        vector[i] = thirdVector[i];
    }
    for (int i = a; i < n; i++) {
        vector[i] = secondVector[b];
        b++;
    }
    return vector;
}