// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz)

Console.WriteLine("Cate elemente are vectorul?");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = new int[n];

GetVectorElements(n, vector);

Console.WriteLine("\nCel mai mare element al vectorului este " + GetLargestElement(vector) + ".");
GetElementPositionInVector(vector, GetLargestElement(vector));

Console.WriteLine("\nCel mai mic element al vectorului este " + GetSmallestElement(vector) + ".");
GetElementPositionInVector(vector, GetSmallestElement(vector));

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
    int big = vector[0];

    for (int i = 0; i < vector.Length; i++) {
        if (vector[i] > big)
        {
            big = vector[i];
        }
    }
    return big;
}

static int GetSmallestElement(int[] vector)
{
    int small = vector[0];

    for (int i = 0; i < vector.Length; i++) {
        if (vector[i] < small) {
            small = vector[i];
        }
    }
    return small;
}

static void GetElementPositionInVector(int[] vector, int a)
{
    for (int i = 0; i < vector.Length; i++) {
        if (vector[i] == a) {
            Console.WriteLine($"{a} se afla pe poitia {i} a vectorului");
            break;
        }
    }
}