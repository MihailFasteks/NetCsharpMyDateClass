using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpMyDateClass
{
    internal class MyDate
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set {
                if (value>0 && value <= 31)
                {
                    day = value;
                }
                }
        }
        public int Month
        {
            get { return month; }
            set {
                if (value>0 && value <= 12)
                month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public MyDate() : this(0, 0, 0)
        {

        }
        public MyDate(int day):this(day, 0, 0)
        {

        }
        public MyDate(int day, int month) : this(day, month, 0)
        {

        }
        public MyDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Diff( MyDate m2)
        {
            try
            {
                if (this.year > m2.year || this.day <= 0 || this.month <= 0 || m2.day <= 0 || m2.month <= 0 || this.day > 31 || this.month > 12 || m2.day > 31 || m2.month > 12)
                {
                    throw new Exception("Wrong date");
                   
                }


                int daysCount = (this.year * 365 + this.month * 31 + this.day) - (m2.year * 365 + m2.month * 31 + m2.day);
                Console.WriteLine($"Diff days {daysCount}");
                return daysCount;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); return -1;
            }
        }
        public void ChangeDate(int d)
        {
            try
            {
                if (d < 0)
                {
                    throw new Exception("Wrong value");
                }

                this.day += d;
                if (this.day > 31)
                {
                    this.day -= 31;
                    this.month++;
                }
                if (this.month > 12)
                {
                    this.month -= 12;
                    this.year++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            
        }
        public void Print()
        {
            Console.WriteLine($"{this.day}.{this.month}, {this.year}");
        }
    }
}
