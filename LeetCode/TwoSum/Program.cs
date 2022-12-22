using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        public int[] TwoSums(int[] nums, int target)
        {
            int[] result = new int[2];
            for(int i = 0; i< nums.Length; i++)
            {
                for(int j = i+1; j< nums.Length; j++)
                {
                    if (nums[j]== target - nums[i])
                    {
                        result[0] = i;
                        result[1] = j;
                        
                        Console.WriteLine(i+" "+j);
                        Console.ReadLine();
                    }
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the Length of nums array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] nums=new int[length];
            for(int i =0; i<length; i++)
            {
                Console.WriteLine("Enter the value for " + i + " position");
                nums[i] += Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter the target");
            int target = Convert.ToInt32(Console.ReadLine());
            p.TwoSums(nums, target);
            
            Console.ReadLine();
            
        }
    }
}
