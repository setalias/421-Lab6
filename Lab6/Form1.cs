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
        private GraphManager graphmanager;
        int x_source, x_dest;
        int y_source, y_dest;
        int size_source, size_dest;

        public Form1()
        {
            graphmanager = GraphManager.getInstance();
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        // Create Graph
        // saved logic: int.TryParse(textBox1.Text, out x_source)  && int.TryParse(textBox2.Text, out y_source) && int.TryParse(textBox3.Text, out size_source)
        private void button1_Click(object sender, EventArgs e)
        {
            graphmanager.create();
            listBox1.Items.Add(graphmanager.getselected().getID());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedGraph = listBox1.SelectedItem.ToString();
            graphmanager.revise(selectedGraph);
            listBox2.Items.Clear();
            graphmanager.getselected().getVertices()
                .ForEach(v => listBox2.Items.Add(v.getID()));
            listBox3.Items.Clear();
            graphmanager.getselected().getEdges()
                 .ForEach(e => listBox3.Items.Add(e.getID()));
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedVertex = listBox2.SelectedItem.ToString();
        }

        private void listBox3_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedEdge = listBox3.SelectedItem.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graph g1 = new Graph();
            Vertex v1 = new Vertex(200, 130);
            Vertex v2 = new Vertex(150, 300);
            Edge e1 = new Edge(v1, v2);
           /* g1.addVertex(200, 130);
            g1.addVertex(150, 300);
            g1.addEdge(v1, v2); */
            g1.print(e.Graphics);

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


       

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();

        }

    }
}
