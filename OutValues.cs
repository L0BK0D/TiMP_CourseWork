using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMP_CourseWork
{
    internal class OutValues
    {
        public int id_result {get;set;}
        public double time {get;set;}   
        public double X { get; set;}
        public double Y { get; set;}
        public double Z { get; set;}

        internal TimpPGSQLSender TimpPGSQLSender
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
