using System;

namespace LeapYearKata
{
    public class Year
    {
        private int value;

        public Year(int value)
        {
            this.value = value;
        }

        public bool IsLeap()
        {
            return (this.value % 4 == 0);
        }
    }
}