﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankWar.Engine
{
    public class Sprite
    {
        public int Id { get; set; }

        public Point Point { get; set; }

        public Sprite()
        {
            Point = new Point();
        }

        public override string ToString()
        {
            return string.Format("id={0}, point={1}", Id, Point);
        }
    }
}
