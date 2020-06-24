using System;

namespace _3Sum_Closest
{
    class Program
    {
        public class Solution
        {
            public static int ThreeSumClosest(int[] nums, int target)
            {
                int[] ThreeSum;
                ThreeSum = new int[nums.Length*(nums.Length-1)*(nums.Length-2)/6];
                for (int i = 0, m = 0; i < nums.Length - 2; i++)
                {
                    for (int j = i + 1; j < nums.Length - 1; j++)
                    {
                        for (int k = j + 1; k < nums.Length; k++)
                        {
                            ThreeSum[m] = nums[i] + nums[j] + nums[k]-target;
                            m++;
                        }
                    }
                }
                int[] Distance;
                Distance = new int[ThreeSum.Length];
                int flag1 = 1000000;
                int flag2 = 0;
                for (int i = 0; i < ThreeSum.Length; i++)
                {
                    if (ThreeSum[i] >= 0)
                    {
                        Distance[i] = ThreeSum[i];
                    }
                    else
                    {
                        Distance[i] = 0 - ThreeSum[i];
                    }
                    if (Distance[i] <= flag1) {
                        flag1 = Distance[i];
                        flag2 = i;
                    }
                }
                return ThreeSum[flag2] + target;
         

                
                

            }
            static void Main(string[] args)
            {
                int[] a = { -1,2,1,-4 };
                int Target = 1;
                ThreeSumClosest(a, Target);
               
                
            }
        }
    }
}
