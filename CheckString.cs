using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTask
{
    class CheckString
    {

        public static bool IsStringBalanced(string strInput)
        {
            try
            {
                Stack<char> lastBracket = new Stack<char>();
                foreach (var c in strInput)
                {
                    switch (c)
                    {
                        case ')':
                            if (lastBracket.Count == 0 || lastBracket.Pop() != '(')  //to remove and check the open bracket when the close bracket found
                                return false;
                            break;
                        case ']':
                            if (lastBracket.Count == 0 || lastBracket.Pop() != '[')
                                return false;
                            break;
                        case '}':
                            if (lastBracket.Count == 0 || lastBracket.Pop() != '{')
                                return false;
                            break;
                        case '(':
                            lastBracket.Push(c);  //to add the open bracket in stack
                            break;
                        case '[':
                            lastBracket.Push(c);
                            break;
                        case '{':
                            lastBracket.Push(c);
                            break;
                    }
                }
                if (lastBracket.Count == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured:" + ex.Message);
                return false;
            }

        }


        static void Main(string[] args)
        {

            string strToCheck = "[{()}]";
            if (IsStringBalanced(strToCheck))
                Console.WriteLine("{0} is balanced", strToCheck);
            else
                Console.WriteLine("{0} is not balanced", strToCheck);
        }
    }
}
