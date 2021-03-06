﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Vcetor
    {
        //靜態變數
        public static int TotalVcetor { get; set; }

        public double X { get; set; }
        public double Y { get; set; }

        public Vcetor(double x, double y)
        {
            this.X = x;
            this.Y = y;
            Vcetor.TotalVcetor++;
        }

        public Vcetor()
        {
            this.X = 0.0;
            this.Y = 0.0;
            Vcetor.TotalVcetor++;
        }

        public double Lenght
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }

        public Vcetor add(Vcetor other)
        {
            this.X += other.X;
            this.Y += other.Y;
            return this;
        }

        public Vcetor add(double x, double y)
        {
            this.X += x;
            this.Y += y;
            return this;
        }

        public Vcetor Minus(Vcetor other)
        {
            this.X -= other.X;
            this.Y -= other.Y;
            return this;
        }

        public Vcetor Minus(double x, double y)
        {
            this.X -= x;
            this.Y -= y;
            return this;
        }
    }
}