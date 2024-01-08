// Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.

Console.WriteLine("Cate elemente are vectorul?");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = new int[n];

GetVectorElements(n, vector);

Console.WriteLine("Suma elementelor din vector este: " + GetVectorSum(vector));

static int GetVectorSum(int[] vector)
{
    int vectorSum = 0;

    foreach (int element in vector) {
        vectorSum += element;
    }
    return vectorSum;
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