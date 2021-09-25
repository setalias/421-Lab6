using System;
using System.Drawing;


namespace Lab6
{
    abstract class GraphComponent : IGraphComponent
    {
        private String uuid;
        public abstract void draw(Graphics g);

        protected void setID()
        {
            this.uuid = Guid.NewGuid().ToString();
        }

        public String getID()
        {
            return this.uuid;
        }
    }
}
