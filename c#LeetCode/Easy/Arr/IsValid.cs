using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace c_LeetCode.Easy.Arr
{
    public  class IsValid
    {

        public bool IsValidimp ( string s )
        {

            var stack =  new Stack<char>();
            var match = new Dictionary<char, char> {



            { ')', '(' },
            { ']', '[' },
            { '}', '{' }



            };


            foreach (var ch in s )
            {

                if ( match.ContainsKey( ch ))
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if (top != match[ch]) return false;
                }


               

                else
                {
                    stack.Push( ch );

                }

              


            }
            return stack.Count == 0;







        }
    }
}
