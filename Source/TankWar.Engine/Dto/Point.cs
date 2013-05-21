﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankWar.Engine
{
    public class Point
    {
        public int X { get;  set; }
        public int Y { get;  set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
                
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", X, Y);
        }
    }
}
