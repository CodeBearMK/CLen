using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class CLen:IConvert
    {
        private double mult = 2.54;
        public double Mult
        {
            get { return mult; }
            set { mult = value; }
        }

        public void Convert(double inch)
        {
            double cm = inch * Mult;
            Console.WriteLine("英制單位 {0}吋 =公制單位 {1}公分", inch, cm.ToString("#.##"));
        }
    }
}
