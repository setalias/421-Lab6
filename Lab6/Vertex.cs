using System.Drawing;


namespace Lab6.Properties
{
    class Vertex : GraphComponent, ICloneable<Vertex>
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

        public Vertex Clone()
        {
            Vertex newVertex = (Vertex)MemberwiseClone();
            newVertex.setID();
            return newVertex;
        }

        public int getX() 
        {
            return x_coordinate;
        }

        public void setX(int x)
        {
            this.x_coordinate = x;
        }

        public int getY()
        {
            return y_coordinate;
        }

        public void setY(int y)
        {
            this.y_coordinate = y;
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
