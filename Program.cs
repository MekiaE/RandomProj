using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDproject2
{
    class aRandomNumberGenerator : Random
    {

        public int Low;
        public int High;
        //public List<int> rngResult;
        public int[] rngResult; 
        // Random rand = new Random(Seed);
        public aRandomNumberGenerator(int low, int high, int s)
            : base(s)
        {
            Low = low;
            High = high;
            //Seed = s;

        }

        public override int Next()
        {
            return Next(High);
        }
        public override int Next(int highest)
        {
            return base.Next(Low, High);
        }
    }
    class aCoin : aRandomNumberGenerator
    {

        public aCoin(int seed)
            : base(0, 2, seed)
        {
            High = 2;
            Low = -1;
            rngResult = new int[2];
            for (int i = 0; i < 2; i++)
            {
                rngResult[i] = 0;
            }
        }

    }
    class aDie : aRandomNumberGenerator
    {
        public aDie(int seed)
            : base(1, 7, seed)
        {
            High = 7;
            Low = 0;
            rngResult = new int[7];
            for (int i = 0; i < 7; i++)
            {
                rngResult[i] = 0;
            }
        }
    }
    class aGaussian : aRandomNumberGenerator
    {
        aDie die;
        public aGaussian(int s)
            : base(1, 7, s)
        {
            aDie dice = new aDie(s);
            die = dice;
            rngResult = new int[37];
            High = 37;
            Low = 5;
            for (int i = 0; i < 37; i++)
            {
                rngResult[i] = 0;
            }
        }

        public override int Next()
        {
            return roll();
        }
        public int roll()
        {
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + die.Next();
            }
            return sum;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
