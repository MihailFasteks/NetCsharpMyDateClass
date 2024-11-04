using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpMyDateClass
{
    internal class Employee
    {
        private string name {  get; set; }
        private string lastName { get; set; }
        private string sureName { get; set; }
        private string birthay {  get; set; }
        private string phone {  get; set; }
        private string email { get; set; }
        private string job {  get; set; }
        private string jobInfo{ get; set; }



        public Employee()
        {
            this.name = "";
            this.lastName = "";
            this.sureName = "";
            this.birthay = "";
            this.phone = "";
            this.email = "";
            this.job = "";
            this.jobInfo = "";
        }
        public Employee(string n) : this(n, "", "", "", "", "", "", "")
        {

        }
        public Employee(string n, string ln):this(n, ln, "", "", "", "", "", "")
        {

        }
        public Employee(string n, string ln, string sn) : this(n, ln, sn, "", "", "", "", "")
        {

        }
        public Employee(string n, string ln, string sn, string br) : this(n, ln, sn, br, "", "", "", "")
        {

        }
        public Employee(string n, string ln, string sn, string br, string ph) : this(n, ln, sn, br, ph, "", "", "")
        {

        }
        public Employee(string n, string ln, string sn, string br, string ph, string em) : this(n, ln, sn, br, ph, em, "", "")
        {

        }
        public Employee(string n, string ln, string sn, string br, string ph, string em, string j) : this(n, ln, sn, br, ph, em, j, "")
        {

        }
        public Employee(string n, string ln, string sn, string br, string ph, string em, string j, string ji)
        {
            this.name = n;
            this.lastName = ln;
            this.sureName = sn;
            this.birthay = br;
            this.phone = ph;
            this.email = em;
            this.job = j;
            this.jobInfo = ji;
        }
        public void Input()
        {
            Console.WriteLine("Input name: ");
            this.name += Console.ReadLine();
            Console.WriteLine("Input last name: ");
            this.lastName += Console.ReadLine();
            Console.WriteLine("Input sure name: ");
            this.sureName += Console.ReadLine();
            Console.WriteLine("Input birthay: ");
            this.birthay += Console.ReadLine();
            Console.WriteLine("Input phone: ");
            this.phone += Console.ReadLine();
            Console.WriteLine("Input email: ");
            this.email += Console.ReadLine();
            Console.WriteLine("Input job: ");
            this.job += Console.ReadLine();
            Console.WriteLine("Input jon info: ");
            this.jobInfo += Console.ReadLine();
        }
        public void Print()
        {
            Console.Write(this.name);
            Console.Write(this.lastName);
            Console.Write(this.sureName);
            Console.Write(this.birthay);
            Console.Write(this.phone);
            Console.Write(this.email);
            Console.Write(this.job);
            Console.Write(this.jobInfo);
            Console.WriteLine();
        }

    }
}
