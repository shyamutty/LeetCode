Memoization with Fibonacci example

Memoization is a term that describes a specialized form of caching related to caching output values of a deterministic function
based on its input values. The key here is a deterministic function, which is a function that will return the same output based 
on a given input. This is true of the Fibonacci function shown above. It will always return the same output based on the input.


//Normal recursive call
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 51; i++)
        {
            Console.WriteLine($"Fib({i}) = {Fib(i)}");
        }
    }

    static long Fib(int n)
    {
        if (n < 2) return n;

        return Fib(n - 1) + Fib(n - 2);
    }
}


//With Memoization
class Program
{
    static Dictionary<int, long> _memo = new() { { 0, 0 }, { 1, 1 } };

    static void Main(string[] args)
    {
        for (int i = 0; i < 51; i++)
        {
            Console.WriteLine($"Fib({i}) = {Fib(i)}");
        }
    }

    static long Fib(int n)
    {
        if (_memo.ContainsKey(n))
            return _memo[n];

        var value = Fib(n - 1) + Fib(n - 2);

        _memo[n] = value;

        return value;
    }
}

