using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMP_CourseWork
{
    internal class RungeKutta
    {
        public double fc {get;set;}
        public double sc { get;set;}
        public double tc { get;set;}
        public double frc { get; set; }
        public bool[] xc {get; set;}

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }

        public double Function(double argx, double argy, double argz)
        {
            if (xc[0] && xc[1])
            { return (-sc * argx * argz - tc * argx * argy + frc) / fc; }
            else if (xc[0] && !xc[1])
                return (-sc * argx * argz - tc * argy + frc) / fc;
            else if (!xc[0] && xc[1])
                return (-sc * argz - tc * argx * argy + frc) / fc;
            else if (!xc[0] && !xc[1])
                return (-sc * argz - tc * argy + frc) / fc;
            else return 0;
        }
    }
}
