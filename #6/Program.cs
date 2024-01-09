// Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.

Console.Write("Cate numere are vectorul? n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = GetVectorElements(n);
PrintArr(vector);

Console.Write("\nCe element doresti  sa elimini din vector? k: \n");
int k = Convert.ToInt32(Console.ReadLine());

if (k < n) {
    vector = RemoveElement(vector, k);
    Console.WriteLine("\nVectorul actualizat: ");
    PrintArr(vector);
}
else {
    Console.WriteLine($"Elementul {k} nu exista in vector.");
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
static int[] RemoveElement(int[] vector, int k)
{
    int n = vector.Length;
    int[] secondVector = new int[n - 1];

    for (int i = 0; i < n - 1; i++) {
        if (i < k) {
            secondVector[i] = vector[i];
        }
        else if (k < n - 1) {
            secondVector[i] = vector[i + 1];
        }
    }
    
    vector = new int[n - 1];
    for (int i = 0; i < n - 1; i++) {
        vector[i] = secondVector[i];
    }
    return vector;
}