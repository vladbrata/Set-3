// Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).

Console.WriteLine("Cate elemente are vectorul?");
int len = Convert.ToInt32(Console.ReadLine());
int[] vector = GetNums(len);

vector = MoveZero(vector);
Console.WriteLine("Vectorul cu toate zero-urile mutate in dreapta:");
PrintArr(vector);

static int[] GetNums(int n)
{
    int[] arr = new int[n];

    for (int i = 0; i < n; i++) {
        Console.WriteLine($"Ce element se afla pe pozitia {i} a vectorului?");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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