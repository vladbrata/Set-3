// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 

Console.WriteLine("Cate numere are sirul?");
int len = Convert.ToInt32(Console.ReadLine());
int[] vector = GetNums(len);

Console.WriteLine("Numerele din sir sunt");
PrintArr(vector);

vector = RemoveDuplicate(vector);
Array.Sort(vector);
Console.WriteLine("\n\nNumerele din sir (dupa ce au fost eliminate elementele care se repeta si dupa ce a fost sortat) sunt");
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
static int[] MoveZero (int[] arr) 
{
    for (int i = 0; i < arr.Length; i++) {
        for (int j = i + 1; j < arr.Length; j++) {
            if (arr[i] == 0) {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}
static int[] RemoveDuplicate(int[] arr)
{
    //Parcurge fiecare element din sir
    //Modifica elementele care se repeta in 0
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++) {
        for (int j = i + 1; j < arr.Length; j++) {
            if (arr[i] == arr[j]) {
                arr[i] = 0;
            }
        }
    }
    //Numara cate elemente se repeta ca sa stim cate elemente sa eliminam
    foreach (int element in arr) {
        if (element == 0) {
            cnt++;
        }
    }
    //Mutam 0-urile la capatul sirului
    arr = MoveZero(arr);
    //Modificam dimensiunea sirului astfel incat sa elimine 0-urile
    Array.Resize(ref arr, arr.Length - cnt);
    return arr;
}
