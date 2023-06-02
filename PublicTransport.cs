using System;
using System.Windows.Forms;

namespace task5
{
    public abstract class PublicTransport : ITransport
    {
        public int capacity { get; set; }
        public int number { get; set; }
        public int power { get; set; }

        public PublicTransport(int capacity, int number, int power)
        {
            this.capacity = capacity;
            this.number = number;
            this.power = power;
        }

        public abstract void move();


        public abstract void stop();
        

        public abstract void boarding();
    }
}