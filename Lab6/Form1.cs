using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6.Properties;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graph g1 = new Graph();
            Vertex v1 = new Vertex(200, 130);
            Vertex v2 = new Vertex(150, 300);
            Edge e1 = new Edge(v1, v2);
            g1.addVertex(200, 130);
            g1.addVertex(150, 300);
            g1.addEdge(v1, v2);
            g1.print(e.Graphics);

        }




    }
}
