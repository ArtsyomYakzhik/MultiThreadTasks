using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadTasks.Model.JobExecution
{
    class SyncroPalindromeJob: IJobExecution<bool>
    {
        public string palindromeContester;
        protected string reversed;
        virtual public bool Execute()
        {
            palindromeContester = palindromeContester.ToLower();
            palindromeContester = palindromeContester.Replace(" ", "");
            return CheckIsPalindrome();
        }

        virtual protected bool CheckIsPalindrome()
        {
            reversed = String.Join("", palindromeContester.Reverse());
            bool result = true;
            int lenght = reversed.Length;
            for(int i = 0; i < lenght; i++)
            {
                result = result & CharCompare(palindromeContester[i], reversed[i]);
            }
            return result;
        }

        protected bool CharCompare(char first, char second)
        {
            return first == second;
        }
    }
}
