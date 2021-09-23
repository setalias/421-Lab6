using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class GraphComponent : IGraphComponent
    {
        private int id;
        protected static int _id = 0;
        private DrawUtil drawutil = new DrawUtil();
        public abstract void draw(Graphics g);

        protected void setID()
        {
            GraphComponent._id += 1;
            this.id = GraphComponent._id;
        }

        public int getID()
        {
            return this.id;
        }
    }
}
