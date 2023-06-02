using System;
using System.Windows.Forms;

namespace task5
{
    public class Tram : PublicTransport
    {
        public int weight { get; set; }
        public double maxSpeed { get; set; }

        public Tram(int capacity, int number, int power, double speed, int weight)
            : base(capacity, number, power)
        {
            this.weight = weight;
            this.maxSpeed = speed;
        }
        
        public override void move()
        {
            MessageBox.Show("Tram is moving");
        }
        
        public override void stop()
        {
            MessageBox.Show("Tram stops");
        }

        public override void boarding()
        {
            MessageBox.Show("Passengers enter the tram");
        }

        public void unloading()
        {
            MessageBox.Show("Passengers leave the tram");
        }
    }
}