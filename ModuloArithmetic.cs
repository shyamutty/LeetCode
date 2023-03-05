//Compute a^b%n
//a^b = (a^2)^(b/2) // b is even
//a^b = a*a^(b-1) // b is odd

int FastPower(int a, int b)
{
  int res = 1;
  while (b > 0)
  {
    if(b % 2 != 0) //if( (b&1) != 0) //check if odd
    {
      res = res * a;
    }
    a = a * a;
    b = b / 2; //b >> 1 (right shift 1 = divide by 2)
   }
    return res;
}
  
//(a + b) % n = (a%n + b%n) % n
//(a * b) % n = (a%n * b%n) % n

long FastPower(long a, long b, int n)
{
  long res = 1;
  while(b > 0)
  {
    if((b&1) != 0)
    {
      //res = (res % n * a % n) % n; //res % n = res because ( 3%5 = 3)
      res = (res * a % n) % n;
    }
    a = (a % n * a % n) % n;
    b = b >> 1;
  }
  return res;
}


//https://www.youtube.com/watch?v=CnPreli2F-E&list=PLUcsbZa0qzu3yNzzAxgvSgRobdUUJvz7p&index=7
