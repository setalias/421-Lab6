using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Properties
{
    class Vertex : GraphComponent
    {
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
            throw new NotImplementedException();
        }
    }
}
