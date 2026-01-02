string primeFile = "primenumbers.txt";
string fibonacciFile = "fibonacci.txt";

List<int> primes = new List<int>();
List<int> fibonaccis = new List<int>();

for (int i = 0; i <= 100; i++)
{
    if (isPrime(i))
    {
        primes.Add(i);
    }
}

int a = 0;
int b = 1;

while (a <= 100)
{
    fibonaccis.Add(a);
    int next = a + b;
    a = b;
    b = next;
}


using (StreamWriter sw = new StreamWriter(primeFile))
{
    foreach (int p in primes)
    {
        sw.WriteLine(p);
    }
}

using (StreamWriter sw = new StreamWriter(fibonacciFile))
{
    foreach (int f in fibonaccis)
    {
        sw.WriteLine(f);
    }
}

Console.WriteLine("Prime Numbers: ");
Console.WriteLine(string.Join(", ", primes));

Console.WriteLine("========================================================");

Console.WriteLine($"Fibonacci Numbers: ");
Console.WriteLine(string.Join(", ", fibonaccis));

static bool isPrime(int number)
{
    if (number < 2)
    {
        return false;
    }

    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}
