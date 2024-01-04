namespace Homework7
{
    internal class Class6
    {
        private Class5[] list;
        public Class6()
        {

        }
        public Class6(int size)
        {

            list = new Class5[size];
        }
        public Class6(int size, Class5[] initialList)
        {
            list = new Class5[size];
            Array.Copy(initialList, list, Math.Min(size, initialList.Length));
        }
        public void Add(Class5 cus)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = cus;
        }
        public void Delete(string id)
        {
            int index = Array.FindIndex(list, c => c.CusId == id);
            if (index != -1)
            {
                list = list.Where((val, idx) => idx != index).ToArray();
            }

        }
        public void Update(string id, Class5 newCus)
        {
            int index = Array.FindIndex(list, c => c.CusId == id);
            if (index != -1)
            {
                list[index] = newCus;
            }

        }
        public Class5 Search(string id)
        {
            return list.FirstOrDefault(c => c.CusId == id);
        }
        public void GetShowList()
        {
            foreach (var cus in list)

            {
                Console.WriteLine($"Id: {cus.CusId}, Name: {cus.FirstName} {cus.LastName}");
            }

        }

    }
}
