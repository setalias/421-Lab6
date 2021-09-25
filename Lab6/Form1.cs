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

        public Form1()
        {
            graphmanager = GraphManager.getInstance();
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        // Create Graph
        // saved logic: int.TryParse(textBox1.Text, out x_source)  && int.TryParse(textBox2.Text, out y_source) && int.TryParse(textBox3.Text, out size_source)

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
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
                graphmanager.copy(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a graph to copy");
            }
            
        }










        /*
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";

        } */
    } 
}
