﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Temperature
    {
        private double? _degree;
        public double? Degree { get { return _degree; } set { _degree = value; } }


        private string _scale;
        public string Scale { get { return _scale; } set { _scale = value; } }


        public Temperature(double? degree, string scale)
        {
            // to be implimented
        }

        public new string ToString()
        {
            // to be implimented
            string myString = "";
            return (myString);
        }
    }
}
