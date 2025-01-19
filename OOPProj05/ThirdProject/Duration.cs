using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProj05.ThirdProject
{
    internal class Duration
    {
        #region 1- Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int TotalSeconds { get; set; }
        #endregion


        #region 2- Override All System.Object Members (ToString, Equals,GetHasCode) .


        public override string ToString()
        {
            return $"Hours:{Hours},Minutes:{Minutes},Seconds:{Seconds}";
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion


        #region 3- Define All Required Constructors to Produce this output
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            TotalSeconds = (hours * 3600)+(minutes * 60)+seconds;
        }

        public Duration(int seconds)
        {
            Hours = seconds/3600;
            Minutes = (seconds%3600)/60;
            Seconds = seconds%60;
             TotalSeconds = seconds;
        }

        #endregion



        #region 4- Implement All required Operators overloading to enable this Code


        public static Duration operator+(Duration left, Duration right)
        {

            return new Duration(left?.Hours + right?.Hours ?? 0 , left?.Minutes + right?.Minutes ?? 0 ,left?.Seconds+right?.Seconds??0);

        }
        public static Duration operator +(Duration left, int seconds)
        {
            int rightHours = seconds / 3600;
            int rightMinutes = (seconds % 3600) / 60;
            int rightSeconds = seconds % 60;

            return new Duration(left?.Hours + rightHours ?? 0, left?.Minutes + rightMinutes ?? 0, left?.Seconds + rightSeconds ?? 0);

        }
        public static Duration operator +( int seconds, Duration right)
        {
            int leftHours = seconds / 3600;
            int leftMinutes = (seconds % 3600) / 60;
            int leftSeconds = seconds % 60;

            return new Duration(right?.Hours + leftHours ?? 0, right?.Minutes + leftMinutes ?? 0, right?.Seconds + leftSeconds ?? 0);

        }
        public static Duration operator ++(Duration one)
        {
         

            return new Duration(one?.Hours??0,one?.Minutes + 1 ?? 0,one?.Seconds??0);

        }
        public static Duration operator --(Duration one)
        {


            return new Duration(one?.Hours ?? 0, one?.Minutes - 1 ?? 0, one?.Seconds ?? 0);

        }
        public static Duration operator -(Duration left, Duration right)
        {

            return new Duration(left?.Hours - right?.Hours ?? 0, left?.Minutes - right?.Minutes ?? 0, left?.Seconds - right?.Seconds ?? 0);

        }
        public static bool operator >(Duration left, Duration right)
        {

            if (left?.Hours == right?.Hours)
            { 
             if(left?.Minutes == right?.Minutes)
                {
                    return left?.Seconds > right?.Seconds;
                }
             else
                {
                    return left?.Minutes > right?.Minutes;
                }
            }
            return left?.Hours > right?.Hours;

        }

        public static bool operator <(Duration left, Duration right)
        {

            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                {
                    return left?.Seconds < right?.Seconds;
                }
                else
                {
                    return left?.Minutes < right?.Minutes;
                }
            }
            return left?.Hours < right?.Hours;

        }



        public static bool operator <=(Duration left, Duration right)
        {

            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                {
                    return left?.Seconds <= right?.Seconds;
                }
                else
                {
                    return left?.Minutes <= right?.Minutes;
                }
            }
            return left?.Hours <= right?.Hours;

        }

        public static bool operator >=(Duration left, Duration right)
        {

            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                {
                    return left?.Seconds >= right?.Seconds;
                }
                else
                {
                    return left?.Minutes >= right?.Minutes;
                }
            }
            return left?.Hours >= right?.Hours;

        }


        public static bool operator ==(Duration left, Duration right)
        {

            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                {
                    if (left?.Seconds == right?.Seconds)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;

        }

        public static bool operator !=(Duration left, Duration right)
        {

            if (left?.Hours != right?.Hours)
            {
                if (left?.Minutes != right?.Minutes)
                {
                    if (left?.Seconds != right?.Seconds)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;

        }

        public static  explicit operator DateTime(Duration d)
        {
            return new DateTime(d.TotalSeconds);
        }

        public static implicit operator bool(Duration d)
        {
            if(d?.Hours != null)
            {
                if (d?.Minutes != null)
                {
                    if (d?.Seconds != null)
                    {
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            else return false;
        }
        #endregion
    }
}
