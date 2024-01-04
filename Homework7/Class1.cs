namespace Homework7
{
    internal class Class1
    {
        int[] test;
        public void input()
        {
            Console.Write("Enter Size of the Array: ");
            int size = int.Parse(Console.ReadLine());
            this.test = new int[size];
            int i = 0;
            foreach (int x in test)
            {
                int Input = int.Parse(Console.ReadLine());
                test[i++] = Input;
            }
        }
        public void output()
        {
            foreach (int x in test)
            {
                Console.WriteLine(x);

            }

        }
    }
}
