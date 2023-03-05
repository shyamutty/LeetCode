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
  





//https://www.youtube.com/watch?v=CnPreli2F-E&list=PLUcsbZa0qzu3yNzzAxgvSgRobdUUJvz7p&index=7
