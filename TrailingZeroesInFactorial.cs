//Check how many 5s are there
int res = 0;
for(int i = 5; i<=n; i=i*5)
{
  res = res + n/i;
}
return res;
