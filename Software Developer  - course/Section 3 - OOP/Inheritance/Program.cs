using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            NormalMember mem1 = new NormalMember("Special Rate", "Rik", 1, 2020);
            VIPMember mem2 = new VIPMember("Jow", 2, 2021);

            mem1.CalculateAnnualFee();
            mem2.CalculateAnnualFee();
            Console.WriteLine(mem1.ToString());
            Console.WriteLine(mem2.ToString());

        }
    }

    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID + "\nMember Since: " + memberSince + "\nTotal Annual Fee: " + annualFee;

        }

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameter");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }
    }

    class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameter");
        }

        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }

    class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameter");
        }

        public void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }

}
