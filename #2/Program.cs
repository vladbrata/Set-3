// Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 

Console.WriteLine("Cate elemente are vectorul?");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = new int[n];

GetVectorElements(n, vector);

GetElementPosition(vector);

static void GetVectorElements(int n, int[] vector)
{
    for (int i = 0; i < n; i++) {
        Console.WriteLine($"Care este elementul aflat pe pozitia {i} al vectorului?");
        vector[i] = Convert.ToInt32(Console.ReadLine());
    }
}

static void GetElementPosition(int[] vector)
{
    Console.Write("Introduceti o valoare K: ");
    int k = Convert.ToInt32(Console.ReadLine());
    bool isK = false;

    for (int i = 0; i < vector.Length; i++) {
        if (vector[i] == k) {
            Console.WriteLine($"{k} se intalneste pentru prima data pe poitia {i} a vectorului");
            isK = true;
            break;
        }
    }
    if (!isK)
        Console.WriteLine("-1");
}