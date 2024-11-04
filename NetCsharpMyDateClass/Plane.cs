using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpMyDateClass
{
    internal class Plane
    {
        private string name { get; set; }
        private string manufact { get; set; }
        private int year {  get; set; }
        private string type {  get; set; }

        public Plane()
        {
            this.name = "";
            this.manufact = "";
            this.year = 0;
            this.type = "";
        }
        public Plane(string n) : this(n, "", 0, "")
        {

        }
        public Plane(string n, string mn) : this(n, mn, 0, "")
        {

        }
        public Plane(string n, string mn, int y) : this(n, mn, y, "")
        {

        }
        public Plane(string n, string mn, int y, string tp )
        {
            this.name=n;
            this.manufact=mn;
            this.year = y;
            this.type=tp;

        }
        public void Input()
        {
            Console.WriteLine("Input name: ");
            this.name += Console.ReadLine();
            Console.WriteLine("Input manufacture: ");
            this.manufact += Console.ReadLine();
            Console.WriteLine("Input year: ");
            this.year += int.Parse(Console.ReadLine());
            Console.WriteLine("Input type: ");
            this.type += Console.ReadLine();
        }
        public void Print()
        {
            Console.Write(this.name);
            Console.Write(this.manufact);
            Console.Write(this.year);
            Console.Write(this.type);
       
            Console.WriteLine();
        }
        public static bool operator <(Plane op1, Plane op2)
        {
            if (op1.year < op2.year)
                return true;
            else
                return false;
        }
        public static bool operator >(Plane op1, Plane op2)
        {
            if (op1.year > op2.year) return true;
            else return false;
        }
        public static bool operator ==(Plane op1, Plane op2)
        {
            if (op1.type == op2.type)
                return true;
            else
                return false;
        }
        public static bool operator !=(Plane op1, Plane op2)
        {
            if (op1.type != op2.type)
                return true;
            else
                return false;
        }

    }
}
