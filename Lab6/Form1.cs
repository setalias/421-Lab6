using System;
using System.Windows.Forms;
using Lab6.Properties;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private GraphManager graphmanager;

        public Form1()
        {
            graphmanager = GraphManager.getInstance();
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedVertex = listBox2.SelectedItem.ToString();
        }

        private void addVertexButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var AddVertex = new VertexFormPopup(this);
                AddVertex.Show(this);
            }
            else
            {
                MessageBox.Show("Please Select a Graph");
            }
            
        }

        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var AddEdge = new EdgeFormPopup(this);
                AddEdge.Show(this);
            }
            else
            {
                MessageBox.Show("Please Select a Graph");
            }
        }

        public void updateList2(string data)
        {
            listBox2.Items.Add(data);
        }

        public void updateList3(string data)
        {
            listBox3.Items.Add(data);
        }

        private void createGraphButton_Click(object sender, EventArgs e)
        {
            graphmanager.create();
            listBox1.Items.Add(graphmanager.getselected().getID());
        }

        private void listBox3_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedEdge = listBox3.SelectedItem.ToString();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            graphmanager.print(e.Graphics);
        }

        private void copyGraphButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Add(graphmanager.copy(listBox1.SelectedItem.ToString()));
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a graph to copy");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGraph = listBox1.SelectedItem.ToString();
            graphmanager.revise(selectedGraph);
            listBox2.Items.Clear();
            graphmanager.getselected().getVertices()
                .ForEach(ve => listBox2.Items.Add(ve.getID()));
            listBox3.Items.Clear();
            graphmanager.getselected().getEdges()
                 .ForEach(ed => listBox3.Items.Add(ed.getID()));
            this.Refresh();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVertex = listBox2.SelectedItem.ToString();
            var ReviseVertex = new VertexFormPopup(this, selectedVertex);
            ReviseVertex.Show(this);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEdge = listBox3.SelectedItem.ToString();
            var ReviseEdge = new EdgeFormPopup(this, selectedEdge);
            ReviseEdge.Show(this);
        }

    } 
}
