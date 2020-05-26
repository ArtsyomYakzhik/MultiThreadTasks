using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadTasks.Model.JobExecution
{
    class MultiThreadPalindromeJob: SyncroPalindromeJob
    {
        private bool isPalindrome = true;
        private object locker = new object();

        protected override bool CheckIsPalindrome()
        {
            isPalindrome = true;
            reversed = String.Join("", palindromeContester.Reverse());
            bool result = true;
            int lenght = reversed.Length;
            for (int i = 0; i < lenght; i++)
            {
                new Thread(CharCompare).Start(new char[] { palindromeContester[i], reversed[i] });
            }
            result &= isPalindrome;
            return result;
        }

        protected void CharCompare(object arrayOfChars)
        {
            char[] array = (char[])arrayOfChars;
            lock(locker)
            {
                isPalindrome = CharCompare(array[0], array[1]);
            }
        }
    }
}
