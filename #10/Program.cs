// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1

Console.WriteLine("Cate numere are sirul?");
int len = Convert.ToInt32(Console.ReadLine());
int[] vector = GetNums(len);

Console.WriteLine("Numerele din sir sunt");
PrintArr(vector);

Console.Write("\nCe numar vrei sa gasesti? K: ");
int k = Convert.ToInt32(Console.ReadLine());

vector = BubbleSort(vector);
Console.WriteLine("\nVectorul sortat este urmatorul: ");
PrintArr(vector);

int pos = BinarySearcch(vector, k);
if (pos == -1) {
    Console.WriteLine("\nElementul nu se regaseste in vector");
}
else {
    Console.WriteLine($"\nNumarul {k} se afla pe pozitia {pos} a vectorului");
}

static int[] GetNums(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];

    for (int i = 0; i < n; i++) {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

static void PrintArr(int[] arr)
{
    foreach(int num in arr) {
        Console.Write(num + " ");
    }
}

static int[] BubbleSort(int[] arr)
{
    bool swapped = false;
    int temp;
    for (int i = 0; i < arr.Length - 1; i++) {
        swapped = false;
        for (int j = 0; j < arr.Length - i - 1; j++) {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                swapped = true;
            }
        }
        if (swapped == false) {
            break;
        }
    }
    return arr;
}

static int BinarySearcch(int[] arr, int num)
{
    int small = 0;
    int big = arr.Length - 1;
    int pos = 0;

    while (small <= big) {
        int mid = (big + small) / 2;
        if (num == mid) {
            pos = Array.IndexOf(arr, mid);
            return pos;
        }
        else if (num < mid) {
            big = mid - 1;
        }
        else {
            small = mid + 1;
        }
    }
    return  -1;
}