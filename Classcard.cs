using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Classcard
    {
        public long CardCode { get; set; }
        public int CardCVV { get; set; }
        public string CardValidthru { get; set; }

        public string CardHolder { get; set; }
        public string Bank { get; set; }

        public decimal CardBalance { get; set; }


        public void Medaxil(decimal money)
        {
            CardBalance += money;
        }


        public void Mexaric(decimal money)
        {
            CardBalance -= money;
        }




    }
}
