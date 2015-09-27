using System;

namespace PianoETI
{
    /// <summary>
    /// <see cref="Fraction"/> class
    /// </summary>
    public class Fraction
    {
        #region Attributes
        /// <summary>
        /// Numerator
        /// </summary>
        private int numerator = 0;

        /// <summary>
        /// Divisor
        /// </summary>
        private uint divisor = 1;

        /// <summary>
        /// Delimiter
        /// </summary>
        public static readonly char Delimiter = '|';
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a <see cref="Fraction"/> instance
        /// </summary>
        public Fraction()
        {
            set(0, 1);
        }

        /// <summary>
        /// Creates a <see cref="Fraction"/> instance
        /// </summary>
        /// <param name="numerator">Numerator</param>
        public Fraction(int numerator)
        {
            set(numerator, 1);
        }

        /// <summary>
        /// Creates a <see cref="Fraction"/> instance
        /// </summary>
        /// <param name="numerator">Numerator</param>
        /// <param name="divisor">Divisor</param>
        public Fraction(int numerator, uint divisor)
        {
            set(numerator, divisor);
        }

        /// <summary>
        /// Creates a <see cref="Fraction"/> instance
        /// </summary>
        /// <param name="fraction"><see cref="Fraction"/> instance</param>
        public Fraction(Fraction fraction)
        {
            if (fraction == null)
                set(0, 1);
            else
                set(fraction.numerator, fraction.divisor);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts <see cref="string"/> to <see cref="Fraction"/>
        /// </summary>
        /// <param name="fraction"><see cref="Fraction"/> instance</param>
        /// <returns>A <see cref="Fraction"/> instance</returns>
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

        /// <summary>
        /// Converts <see cref="Fraction"/> to <see cref="string"/>
        /// </summary>
        /// <returns>Fraction string</returns>
        public override string ToString()
        {
            return numerator + (new string(Delimiter, 1)) + divisor;
        }

        /// <summary>
        /// Sets the numerator and dividor
        /// </summary>
        /// <param name="numerator">Numerator</param>
        /// <param name="divisor">Divisor</param>
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

        /// <summary>
        /// Gets the division of numerator and divisor
        /// </summary>
        /// <returns></returns>
        public double get()
        {
            return ((double)numerator) / ((double)divisor);
        }
        #endregion

        #region Getter/Setter
        /// <summary>
        /// Numerator
        /// </summary>
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

        /// <summary>
        /// Divisor
        /// </summary>
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
