using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadTasks.Model.JobExecution
{
    class AsyncPalindromeJob: SyncroPalindromeJob
    {
        public override bool Execute()
        {
            palindromeContester = palindromeContester.ToLower();
            palindromeContester = palindromeContester.Replace(" ", "");

            return isAsyncPolyndrom();
        }

        protected bool isAsyncPolyndrom()
        {
            reversed = String.Join("", palindromeContester.Reverse());
            bool result = true;
            Task<bool> temp;
            int lenght = reversed.Length;
            for (int i = 0; i < lenght; i++)
            {
                temp = AsyncCompare(palindromeContester[i], reversed[i]);
                temp.Wait();
                result &= temp.Result;
            }
            return result;
        }

        private async Task<bool> AsyncCompare(char first, char second)
        {
            return await Task.Run(()=> 
                CharCompare(first, second)
            );
        }
    }
}
