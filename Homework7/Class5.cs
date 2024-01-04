namespace Homework7
{
    internal class Class5
    {
        public string CusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public int OldNum { get; set; }
        public int NewNum { get; set; }
        public string MeterCode { get; set; }

        public Class5()
        {
        }

        public Class5(string cusId, string firstName, string lastName, string gender, string address, string tel, int oldNum, int newNum, string meterCode)
        {
            CusId = cusId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Address = address;
            Tel = tel;
            OldNum = oldNum;
            NewNum = newNum;
            MeterCode = meterCode;
        }
    }
}
