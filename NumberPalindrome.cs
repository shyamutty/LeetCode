int lastDigit = -1; temp = n; result =0;

while (lastDigit !=0){
    lastDigit = temp % 10;
    temp = temp / 10;
    result = result * 10 + lastDigit;
}
return result;

//https://www.youtube.com/watch?v=69jsFIMINpI&list=PLUcsbZa0qzu3yNzzAxgvSgRobdUUJvz7p&index=6
