namespace Problem04.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class BalancedParenthesesSolve : ISolvable
    {
        public bool AreBalanced(string parentheses)
        {
            if(parentheses.Length == 0 || parentheses.Length % 2 != 0)
            {
                return false;
            }
            Stack<char> openBracket = new Stack<char>();
            for(int i = 0; i < parentheses.Length; i++)
            {
                char currentSymbol = parentheses[i];
                if (currentSymbol == '[' || currentSymbol == '{' || currentSymbol == '(')
                {
                    openBracket.Push(currentSymbol);
                }
                else
                {
                    switch (currentSymbol)
                    {
                        case ')':
                            if(openBracket.Peek().Equals('('))
                            {
                                openBracket.Pop();
                            }
                            break;
                            case ']':
                            if (openBracket.Peek().Equals('['))
                            {
                                openBracket.Pop();
                            }
                            break;
                        case '}':
                            if (openBracket.Peek().Equals('{'))
                            {
                                openBracket.Pop();
                            }
                            break;
                            default:
                            return false;
                    }
                }
            }
            if(openBracket.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
