using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLinq
{
    public static  class ExtenionMethod
    {
        public static int[]  MyOrderByDescending(this int[] arr  ,Func<int,int> del)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (del(arr[i]) < del(arr[j]))
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public static int[] MyOrderBy(this int[] arr, Func<int, int> del)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (del(arr[i]) > del(arr[j]))
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
        public static int[] MyTake(this int[] arr, int count)
        {
            if (count > arr.Length)
                count = arr.Length;

            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = arr[i];
            }

            return result;
        }
        public static int[] MySkip(this int[] arr, int count)
        {
            if (count >= arr.Length)
                return new int[0];

            int[] result = new int[arr.Length - count];

            for (int i = count; i < arr.Length; i++)
            {
                result[i - count] = arr[i];
            }

            return result;
        }
        public static int MyLast(this int[] arr)
        {
            if (arr.Length == 0)
                throw new InvalidOperationException(" arr contains no elements");

            return arr[arr.Length - 1];
        }
        public static int[] MyTakeWhile(this int[] arr, Func<int, bool> del)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (del(arr[i]))
                    count++;
                else
                    break;
            }

            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = arr[i];
            }

            return result;
        }


    }
}
