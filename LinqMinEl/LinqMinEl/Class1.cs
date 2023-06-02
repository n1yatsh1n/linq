using System.Linq;
using System;
using System.Collections.Generic;

namespace LinqMinEl
{
    public class Class1
    {

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            Console.WriteLine(n/2);
            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            List<int> firstHalf = new List<int>(); 
            List<int> secondHalf = new List<int>();
            
            for (int k = 0; k < n; k++)
            {
                if (k<n/2) firstHalf.Add(nums[k]);
                if (k>n/2) secondHalf.Add(nums[k]);
            }

            var firstHalfSorted = from el in firstHalf orderby el select el;
            var secondHalfSorted = (from el in secondHalf orderby el select el).Reverse();
            Console.WriteLine("ОТВЕТ: ");
            foreach (var firstEl in firstHalfSorted)
            {
                Console.WriteLine(firstEl);
            }

            foreach (var secondEl in secondHalfSorted)
            {
                Console.WriteLine(secondEl);
            }
        }
    }
}