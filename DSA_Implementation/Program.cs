using DSA_Implementation.ArrayImplementation;

namespace DSA_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> array = new MyArray<int>();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Insert(2, -1);
            array.Add(9);
            array.Add(9);
            array.Add(9);
            array.Add(9);

            Console.WriteLine(array.ToString());
            array.RemoveAll(9);
            Console.WriteLine(array.ToString());

            array.Clear();

            Console.WriteLine(array.ToString());




        }
    }
}
