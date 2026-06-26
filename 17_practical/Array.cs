using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_practical
{
    internal class MyArray : IOutput, IMath
    {
        private int[] arr;

        public MyArray(int[] numb)
        {
            arr = numb;
        }

        float IMath.Avg()
        {
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                avg = sum / arr.Length;
            }
            return avg;
        }

        int IMath.Max()
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        int IMath.Min()
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        bool IMath.Search(int valueToSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        void IOutput.Show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }

        void IOutput.Show(string info)
        {
            Console.WriteLine(info);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }

        
    }

}
