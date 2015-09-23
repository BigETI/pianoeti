using System;

namespace PianoETI
{
    public class Fraction
    {
        #region Attributes
        private int numerator = 0;
        private uint divisor = 1;
        public static readonly char Delimiter = '|';
        #endregion

        #region Constructors
        public Fraction()
        {
            set(0, 1);
        }

        public Fraction(int numerator)
        {
            set(numerator, 1);
        }

        public Fraction(int numerator, uint divisor)
        {
            set(numerator, divisor);
        }

        public Fraction(Fraction fraction)
        {
            if (fraction == null)
                set(0, 1);
            else
                set(fraction.numerator, fraction.divisor);
        }
        #endregion

        #region Methods
        public static Fraction parse(string fraction)
        {
            Fraction ret = new Fraction();
            string[] f = fraction.Trim().Split(Delimiter);
            switch (f.Length)
            {
                case 1:
                    ret.set(Convert.ToInt32(f[0]), 1);
                    break;
                case 2:
                    ret.set(Convert.ToInt32(f[0]), Convert.ToUInt32(f[1]));
                    break;
            }
            return ret;
        }

        public override string ToString()
        {
            return numerator + (new string(Delimiter, 1)) + divisor;
        }

        public void set(int numerator, uint divisor)
        {
            if (divisor > 0)
            {
                this.numerator = numerator;
                this.divisor = divisor;
            }
            else
            {
                this.numerator = 0;
                this.divisor = 1;
            }
        }

        public double get()
        {
            return ((double)numerator) / ((double)divisor);
        }
        #endregion

        #region Getter/Setter
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                set(value, divisor);
            }
        }

        public uint Divisor
        {
            get
            {
                return divisor;
            }
            set
            {
                set(numerator, value);
            }
        }
        #endregion
    }
}
