using System;

namespace CS_Static
{
    public class Date
    {
        private int year;
        private int month;
        private int day;

        
        public int Year
        {
            get { return this.year; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Year must be more than 1.");
                }
                this.year = value;
            }
        }

        public int Month
        {
            get { return this.month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Month must be between 1 and 12.");
                }
                this.month = value;
            }
        }

        public int Day
        {
            get { return this.day; }
            set
            {
                if (value < 1 || value > DaysInMonth(this.year, this.month))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Day must be between 1 and {DateTime.DaysInMonth(this.year, this.month)} for month {this.month}.");
                }
                this.day = value;
            }
        }

        public Date(int year, int month, int day)
        {
            this.Year = year; 
            this.Month = month; 
            this.Day = day; 
        }

        public override string ToString()
        {
            return $"{Year} / {Month} / {Day}";
        }

        public override bool Equals(object obj)
        {
            if (obj is not Date other)
            {
                return false;
            }

            return this.Year == other.Year && this.Month == other.Month && this.Day == other.Day;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Year, Month, Day);
        }

        public static Date operator +(Date date, int days)
        {
            DateTime dt = new DateTime(date.Year, date.Month, date.Day);
            dt = dt.AddDays(days);
            return new Date(dt.Year, dt.Month, dt.Day);
        }

        public static Date operator -(Date date, int days)
        {
            DateTime dt = new DateTime(date.Year, date.Month, date.Day);
            dt = dt.AddDays(-days);
            return new Date(dt.Year, dt.Month, dt.Day);
        }

        public static int operator -(Date date1, Date date2)
        {
            DateTime dt1 = new DateTime(date1.Year, date1.Month, date1.Day);
            DateTime dt2 = new DateTime(date2.Year, date2.Month, date2.Day);
            return (int)(dt1 - dt2).TotalDays;
        }
    }
}