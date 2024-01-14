// Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 

int[] a = GetVectorElements(1500);
int len = a.Length;
Console.Write("Introdu un numar n: ");
int n = Convert.ToInt32(Console.ReadLine());
a = CiurulLuiEratostene(a);

PrintCiurulLuiEratostene(a, n);

static int[] GetVectorElements(int n)
{
    int[] arr = new int[n];
    int i = 0;
    while (i < n)
    {
        arr[i] = i;
        i++;
    }
    return arr;
}

static int[] RemoveElement(int[] vector, int k)
{
    int n = vector.Length;
    int[] secondVector = new int[n - 1];

    for (int i = 0; i < n - 1; i++)
    {
        if (i < k)
        {
            secondVector[i] = vector[i];
        }
        else if (k < n - 1)
        {
            secondVector[i] = vector[i + 1];
        }
    }

    vector = new int[n - 1];

    for (int i = 0; i < n - 1; i++)
    {
        vector[i] = secondVector[i];
    }
    return vector;

}

static int[] RemoveMultiplu(int[] arr, int cnt)
{
    //Functie care elimina multiplii unui numar dintr-un array
    int len = arr.Length;
    int divisor = arr[cnt];
    for (int i = cnt + 1; i < len; i++)
    {
        if (arr[i] % divisor == 0)
        {
            len--;
            arr = RemoveElement(arr, i);
        }
    }
    return arr;
}

static int[] CiurulLuiEratostene(int[] arr)
{
    // Elimin 0 pentru ca 0 nu este numar prim
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] == 0)
        {
            arr = RemoveElement(arr, i);
            len--;
            break;
        }
    }
    // Elimin 1 pentru ca 1 nu este numar prim
    for (int i = 0; i < len; i++)
    {
        if (arr[i] == 1)
        {
            arr = RemoveElement(arr, i);
            len--;
            break;
        }
    }
    // Elimina toti multiplii primelor 7 numere prime. 
    for (int i = 0; i < 8; i++)
    {
        arr = RemoveMultiplu(arr, i);
    }

    return arr;
}

static void PrintCiurulLuiEratostene(int[] arr, int n)
{
    Console.WriteLine($"Numerele prime mai mici sau egale cu {n} sunt: ");
    for (int i = 0; arr[i] <= n; i++)
    {
        Console.Write(arr[i] + " ");
    }
}