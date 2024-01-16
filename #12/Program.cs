// Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.

Console.WriteLine("Cate numere are sirul?");
int len = Convert.ToInt32(Console.ReadLine());
int[] vector = GetNums(len);

Console.WriteLine("Numerele din sir sunt");
PrintArr(vector);

vector = SelectionSort(vector);
Console.WriteLine("\n\nNumerele din sir (dupa ce au fost sortate) sunt");
PrintArr(vector);

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

static int[] SelectionSort (int[] arr)
{
    for (int i = 0; i < arr.Length; i++) {
        int minPos = i;
        // Stabileste care este cel mai mic element nesortat
        for (int j = i + 1; j < arr.Length; j++) {
            if (arr[j] < arr[minPos]) {
                minPos = j; 
            }
        }
        // Swapp-uieste elementul cel mai mic cu primul element nesortat
        int tempSwap = arr[minPos];
        arr[minPos] = arr[i];
        arr[i] = tempSwap; 
    }
    return arr;
}