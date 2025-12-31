using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        
        public Duration(int hours, int minutes, int seconds)
        {
            NormalizeTime(hours, minutes, seconds);
        }

        public Duration(int totalSeconds)
        {
            FromTotalSeconds(totalSeconds);
        }

        
        private void NormalizeTime(int hours, int minutes, int seconds)
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            FromTotalSeconds(totalSeconds);
        }

        private void FromTotalSeconds(int totalSeconds)
        {
            if (totalSeconds < 0) totalSeconds = 0;

            Hours = totalSeconds / 3600;
            int remainingSeconds = totalSeconds % 3600;
            Minutes = remainingSeconds / 60;
            Seconds = remainingSeconds % 60;
        }

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else if (Minutes > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            else
                return $"Seconds: {Seconds}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Hours, Minutes, Seconds).GetHashCode();
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, Math.Max(0, d.Minutes - 1), d.Seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(Math.Max(0, totalSeconds1 - totalSeconds2));
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            if (d1.Hours != d2.Hours) return d1.Hours > d2.Hours;
            if (d1.Minutes != d2.Minutes) return d1.Minutes > d2.Minutes;
            return d1.Seconds > d2.Seconds;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1.Hours != d2.Hours) return d1.Hours < d2.Hours;
            if (d1.Minutes != d2.Minutes) return d1.Minutes < d2.Minutes;
            return d1.Seconds < d2.Seconds;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1 > d2 || d1.Equals(d2);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1 < d2 || d1.Equals(d2);
        }

        public static bool operator true(Duration d)
        {
            return d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            DateTime now = DateTime.Now;
            return new DateTime(now.Year, now.Month, now.Day, d.Hours, d.Minutes, d.Seconds);
        }
    }

}
