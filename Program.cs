using System;

namespace ArrayAsInExample
{
    public class A
    {
        public int[] M1(int[] l, int[] m)
        {
            int[] res = new int[l.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = l[i] + m[i];                
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            int[] j = new int[] {10,20,30,40 };
            int[] k = new int[] {50,60,70,80 };
            int[] res1 = a.M1(j, k);
            for (int i = 0; i < res1.Length; i++)
            {
                Console.WriteLine(res1[i]);
            }
            Console.ReadLine();
        }
    }
}
