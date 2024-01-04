namespace Homework7
{
    internal class Class2

    {
        int[] arr;
        public void input()
        {
            Console.Write("Enter Size of the Array: ");
            int size = int.Parse(Console.ReadLine());
            this.arr = new int[size];
            int i = 0;
            foreach (int x in arr)
            {
                int Input = int.Parse(Console.ReadLine());
                arr[i++] = Input;
            }
        }
        public void output()
        {
            int total = arr.Aggregate((a, b) => a + b);
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Averge: {total / arr.Length}");

        }
    }
}
