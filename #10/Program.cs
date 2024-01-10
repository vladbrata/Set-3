// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1

Console.WriteLine("Cate numere are sirul?");
int len = Convert.ToInt32(Console.ReadLine());
int[] vector = GetNums(len);
Console.WriteLine("Numerele din sir sunt");
PrintArr(vector);

vector = BubbleSort(vector);

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

static void BinarySearcch(int[] arr)
{
    
}