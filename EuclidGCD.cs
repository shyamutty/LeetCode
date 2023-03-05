//GCD(a,b) = GCD(a-b, b) // a > b
//GCD(a,b) = GCD(b, a%b) //a%b != 0

int Gcd(int a, int b)
{
  if(b == 0)
    return a;
  return Gcd(b, a%b);
}


//https://www.youtube.com/watch?v=dyrRM8dTEus&list=PLUcsbZa0qzu3yNzzAxgvSgRobdUUJvz7p&index=6

