using System;

namespace EvanAlmighty
{
    public class Star
    {
        private string _name;
        private long _diameter;
        private int _x;
        private int _y;
        private Planet[] _planets;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public long Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Planet[] Planets
        {
            get { return _planets; }
            set { _planets = value; }
        }

        public Star(string name, long diameter, int x, int y, Planet[] planets)
        {
            Name = name;
            Diameter = diameter;
            X = x;
            Y = y;
            Planets = planets;
        }
    }
}
