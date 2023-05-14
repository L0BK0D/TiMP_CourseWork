using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TiMP_CourseWork
{
    internal class InitValues
    {
        [Key]
        public int id_Eq {get;set;}
        public string[] Coefficents { get;set;}
        public double X0 { get;set;}    
        public double Y0 { get;set;}
        public double Z0 { get;set;}

        internal TimpPGSQLSender TimpPGSQLSender
        {
            get => default;
            set
            {
            }
        }

        internal RungeKutta RungeKutta
        {
            get => default;
            set
            {
            }
        }

        internal TiMPDbContext TiMPDbContext
        {
            get => default;
            set
            {
            }
        }
    }
}
