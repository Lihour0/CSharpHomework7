namespace Homework7
{
    internal class Class3
    {
        string[,] arr;
        int size;
        public void input()
        {
            Console.Write("Enter the number of classes: ");
            int numClasses = Convert.ToInt32(Console.ReadLine());
            this.size = numClasses;

            for (int i = 0; i < numClasses; i++)
            {
                Console.Write("Enter class name, current enrollment, and maximum enrollment (separated by spaces): ");
                string[] input = Console.ReadLine().Split(' ');
                arr[i, 0] = input[0];
                arr[i, 1] = input[1];
                arr[i, 2] = input[2];
            }
        }

        public void output()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Class Name: {arr[i, 0]}, Current Enrollment: {arr[i, 1]}, Maximum Enrollment: {arr[i, 2]}");

            }

        }

    }
}
