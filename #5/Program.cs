// Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.

Console.WriteLine("Cate elemente are vectorul?");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = GetArr(n);
PrintArr(vector);

Console.Write("\nDa-mi o pozitie K: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("Da-mi un numar e: ");
int e = Convert.ToInt32(Console.ReadLine());

PrintNewArr(vector, e, k);

static int[] GetArr(int n)
{
    Random num = new Random();
    int[] nums = new int[n];
    for (int i = 0; i < n; i++)
    {
        nums[i] = num.Next(-100, 100);
    }
    return nums;
}
static void PrintArr(int[] arr)
{
    Console.WriteLine("Numere din vector: ");
    foreach (int number in arr)
    {
        Console.Write(number + " ");
    }
}
static int[] InsertElement(int e, int k, int[] vector)
{
    int[] secondArr = new int[vector.Length + 1];
    int cnt = 0;

    for (int i = 0; i < secondArr.Length; i++) {
        secondArr[i] = vector[cnt];
        if (i == k) {
            secondArr[i] = e;
        }
        else {
            cnt++;
        }
    }
    
    return secondArr;
}
static void PrintNewArr(int[] vector, int e, int k)
{
    Console.WriteLine($"\nNumarul {e} a fost introdus pe pozitia {k} a vectorului");
    int[] arr = InsertElement(e, k, vector);
    Console.WriteLine("Vectorul actualizat: ");
    foreach (int num in arr) {
        Console.Write(num + " ");
    }
}
