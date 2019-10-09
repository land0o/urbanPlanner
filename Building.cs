using System;
using System.Collections.Generic;

namespace Planner
{

    public class Building
    {
        //private Fields
        private string _designer = "Curtis";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address;
        private string _owner;



        //public Properties

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        //constructor
        public Building(string address)
        {
            _address = address;
        }


        //public methods
        public DateTime GetDateConstructed()
        {
            return _dateConstructed;
        }

        public string GetAddress()
        {
            return _address;
        }

        public string GetBuyer(string owner)
        {
            return _owner = owner;
        }
        public string GetDesigner()
        {
            return _designer;
        }
        public string GetOwner(){
            return _owner;
        }
        public void Print()
        {
            // Console.WriteLine();
            // Console.WriteLine(this.GetAddress());
            // Console.WriteLine("-----------------");
            // Console.WriteLine($"Designed by {building.GetBuyer()}");
            // Console.WriteLine($"Build on {building.GetDate()}");
            // Console.WriteLine();
        }
    }
}



