using System;

namespace OOP
{
    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        public int HoursWorked
        {
            get { return hWorked; }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating rate...");
        }

        public int CalculateRate()
        {
            PrintMessage();
            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
        }

        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------");

        }
        public Staff(string fname, string lname)
        {
            nameOfStaff = fname + " " + lname; ;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int pay;

            Staff staff1 = new Staff("Rik", "Williams");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("pay = {0}", pay);
            Staff staff2 = new Staff("Lucy", "Williams");
            staff2.HoursWorked = 160;
            pay = staff2.CalculateRate();
            Console.WriteLine("pay = {0}", pay);
            Staff staff3 = new Staff("Tony", "Williams");
            staff3.HoursWorked = -160;
            pay = staff3.CalculateRate();
            Console.WriteLine("pay = {0}", pay);
        }
    }
}
