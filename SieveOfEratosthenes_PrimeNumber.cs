bool[] SeiveOfEratoSthenes(int n)
{
  bool isPrime[] = new bool[n+1];

  for (int i = 0; i <= n; i++)
  isPrime[i] = true;

  isPrime[0] = false;
  isPrime[1] = false;

  for(int i = 2; i * i <= n; i++)
  {
    for(int j = 2*i; j<=n; j+=i)
    {
    isPrime[i] = false;
    }
  }
  return isPrime;
}

//https://www.youtube.com/watch?v=dyrRM8dTEus&list=PLUcsbZa0qzu3yNzzAxgvSgRobdUUJvz7p&index=6
