using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        private List<ITransport> transportList = new List<ITransport>();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        //int capacity, int number, int power, double speed, int weight
        
        private void addButton_Click(object sender, EventArgs e)
        {
            int capacity = int.Parse(weightTextBox.Text);
            int number = int.Parse(materialTextBox.Text);
            int power = int.Parse(heightTextBox.Text);
            double speed = double.Parse(numShelvesTextBox.Text);
            int weight = int.Parse(colorTextBox.Text);

            Tram tram = new Tram(capacity, number, power, speed, weight);

            
            transportList.Add(tram);
            l.Items.Add(tram);

            
            l.SelectedItem = tram;
            propertyGrid.SelectedObject = tram;

            
            weightTextBox.Text = "";
            materialTextBox.Text = "";
            heightTextBox.Text = "";
            numShelvesTextBox.Text = "";
            colorTextBox.Text = "";
        }
        
        private void removeButton_Click(object sender, EventArgs e)
        {
            
           ITransport selectedTransport = l.SelectedItem as ITransport;

            
            if (selectedTransport != null)
            {
                transportList.Remove(selectedTransport);
                l.Items.Remove(selectedTransport);
                propertyGrid.SelectedObject = null;
            }
        }
        
        private void tarnsportListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ITransport selectedTransport = l.SelectedItem as ITransport;

            
            if (selectedTransport != null)
            {
                propertyGrid.SelectedObject = selectedTransport;
            }
            else
            {
                propertyGrid.SelectedObject = null;
            }
        }

        
    }
}