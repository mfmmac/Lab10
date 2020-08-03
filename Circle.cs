using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public double CalculateCircumference
        {
            get { return 2 * Math.PI * Radius; }
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference);
        }
        public double CalculateArea
        {
           get { return Radius * Radius * Math.PI; }
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea);
        }
        private string FormatNumber(double r)
        {
            return Math.Round(r, 2).ToString();
        }
    }
}

