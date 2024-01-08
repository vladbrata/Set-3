// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.

Console.WriteLine("Cate elemente are vectorul?");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = new int[n];

GetVectorElements(n, vector);

PrintLargest(vector);
PrintSmallest(vector);

static void PrintLargest(int[] vector)
{
    Console.WriteLine("\nCel mai mare element al vectorului este " + GetLargestElement(vector) + ".");
    GetElementPositionInVector(vector, GetLargestElement(vector));
}

static void PrintSmallest(int[] vector)
{
    Console.WriteLine("\nCel mai mic element al vectorului este " + GetSmallestElement(vector) + ".");
    GetElementPositionInVector(vector, GetSmallestElement(vector));
}

static void GetVectorElements(int n, int[] vector)
{
    int i = 0;
    while (i < n) {
        Console.WriteLine($"Care este elementul aflat pe pozitia {i} al vectorului?");
        vector[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
}

static int GetLargestElement(int[] vector)
{
    int big = 0;

    foreach (int element in vector) {
        if (element > big) {
            big = element;
        }
    }
    return big;


}

static int GetSmallestElement(int[] vector)
{
    int small = GetLargestElement(vector);

    foreach (int element in vector) {
        if (element < small) {
            small = element;
        }
    }
    return small;
}

static void GetElementPositionInVector(int[] vector, int a)
{
    for (int i = 0; i < vector.Length; i++) {
        if (vector[i] == a) {
            Console.WriteLine($"{a} se afla pe poitia {i} a vectorului.");
            break;
        }
    }
}