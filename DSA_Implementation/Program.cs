using DSA_Implementation.ArrayImplementation;

namespace DSA_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray();

            arr.Add(3);
            arr.Add(-1);
            arr.Add(3);
            arr.Add(10);
            arr.Add(0);

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("=======================");

            arr.RemoveAt(0);
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("=======================");

            arr.RemoveAt(2);
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("=======================");

        }
    }
}
