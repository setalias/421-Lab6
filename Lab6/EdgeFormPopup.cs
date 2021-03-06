using Lab6.Properties;
using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class EdgeFormPopup : Form
    {
        private GraphManager graphmanager;
        private Form1 f1;
        private string edgeID;
        public EdgeFormPopup(Form1 _f1)
        {
            setup(_f1);
        }

        public EdgeFormPopup(Form1 _f1, string _edgeID)
        {
            setup(_f1);
            this.edgeID = _edgeID;
        }

        private void setup(Form1 _f1)
        {
            graphmanager = GraphManager.getInstance();
            InitializeComponent();
            this.f1 = _f1;

            graphmanager.getselected().getVertices()
                .ForEach(ve => listBox1.Items.Add(ve.getID()));

            graphmanager.getselected().getVertices()
                .ForEach(ve => listBox2.Items.Add(ve.getID()));
        }

        


        public void button1_Clicked(object sender, EventArgs e)
        {
            if ((listBox1.SelectedItem != null) && 
                (listBox2.SelectedItem != null))
            {
                if (listBox1.SelectedItem.ToString().Equals(listBox2.SelectedItem.ToString()))
                {
                    MessageBox.Show("Please select two different vertices");
                }
                else
                {
                    if (this.edgeID != null)
                    {
                        graphmanager.reviseEdge(
                            this.edgeID,
                            listBox1.SelectedItem.ToString(),
                            listBox2.SelectedItem.ToString());
                    }
                    else {
                        f1.updateList3(
                            graphmanager.addEdgeToSelectedGraph(
                                listBox1.SelectedItem.ToString(),
                                listBox2.SelectedItem.ToString()));
                    }
                    this.Close();
                    f1.Refresh();
                }
            }
            
            else
            {
                MessageBox.Show("Make a selection");
            }


        }

        


        




    }
}
