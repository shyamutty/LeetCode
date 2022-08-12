Algorithm for Valid Parentheses
n: length of string

str: input string

Declare and initialize a stack S.
Run a loop on i from 0 to n.
If str[i] is an opening bracket, then push str[i] in the stack.
If str[i] is a closing bracket, then there are two possibilities:
If the top bracket present in the stack is the opening bracket of the same type, then pop top element of the stack.
Else, return false.
Return S.empty().


public bool IsValid(string s) {
        
        Stack<char> bracket = new Stack<char>();
        foreach (char c in s.ToCharArray()) {
             switch (c) {
                case '(': bracket.Push(c); 
                          break;
                case '{': bracket.Push(c); 
                          break;
                case '[': bracket.Push(c); 
                          break;
                case ')': if (bracket.Count == 0 || bracket.Peek()!='(') 
                          return false; 
                          else 
                          bracket.Pop(); 
                          break;
                case '}': if (bracket.Count == 0 || bracket.Peek()!='{') 
                          return false; 
                          else 
                          bracket.Pop(); 
                          break;
                case ']': if (bracket.Count == 0 || bracket.Peek()!='[') 
                          return false; 
                          else 
                          bracket.Pop(); 
                          break;
                default: break;
            }
        }
        
        if(bracket.Count > 0)
            return false;
        else
            return true;
        
    }
