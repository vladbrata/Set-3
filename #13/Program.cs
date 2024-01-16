// Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.

Console.WriteLine("Cate numere are sirul?");
int len = Convert.ToInt32(Console.ReadLine());
int[] vector = GetNums(len);

Console.WriteLine("Numerele din sir sunt");
PrintArr(vector);

vector = InsertionSort(vector);
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
static int[] InsertionSort(int[] arr) 
{
    for (int i = 1; i < arr.Length; i++) {
        int key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > key) {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }

    return arr;
}