﻿using System;

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
            if (this.value % 4 == 0)
            {
                if (this.value % 100 == 0)
                {
                    return (this.value % 400 == 0);
                }
                return true;
            }
            return false;
        }
    }
}