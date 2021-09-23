﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Properties
{
    class Vertex : GraphComponent
    {
        public static int SIZE = 25;
        private int x_coordinate;
        private int y_coordinate;
        

        public Vertex(int x, int y) 
        {
            this.x_coordinate = x;
            this.y_coordinate = y;
            this.setID();
        }
        public int getX() 
        {
            return x_coordinate;
        }

        public void setX(int x)
        {
            x = this.x_coordinate;
        }

        public int getY()
        {
            return y_coordinate;
        }

        public void setY(int y)
        {
            y = this.y_coordinate;
        }
        public override void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            int s = 25;
            int v = 1;
            Rectangle r = getRectangle();
            g.DrawEllipse(pen, r);

        }
        public static int getV(Rectangle r1, Rectangle r2)
        {
            if (r1.Y > r2.Y)
            {
                return -1;
            }
            return 1;
        }
        public Rectangle getRectangle()
        {            
            return new Rectangle(x_coordinate, y_coordinate, 2*SIZE, 2*SIZE);
        }
    }
}